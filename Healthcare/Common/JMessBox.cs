using Healthcare.JMessbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
namespace Healthcare.JMessbox
{
    public class JMessBox
    {
        public Action<bool> Completed;
        Popup popup = new Popup();
        private string messageText;

        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }
        //这里定义个静态变量，避免每次初始化都变为0
        //静态变量，个人理解，只会初始化一次
        static int clickCount = 0;
        public JMessBox(string text)
        {
            this.MessageText = text;
        }
        public void Show()
        {
            //2s之内连续按2次，退出
            if (clickCount > 0)
            {
                if (Completed != null)
                {
                    Completed(true);
                }
            }
            else
            {
                clickCount++;

                if (Completed != null)
                {
                    Completed(false);
                }

                var tips = new JMessboxControl();
                tips.TBMessage.Text = this.messageText;
                popup.Height = 65;
                popup.Width = 200;
                popup.Margin = new Thickness(140, 380, 0, 0);
                popup.IsOpen = false;
                popup.Child = tips;

                //渐变效果:透明度200毫秒内从0->1
                Storyboard story = new Storyboard();
                DoubleAnimation topAnimation = new DoubleAnimation();
                topAnimation.From = 0;
                topAnimation.To = 1;
                topAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                Storyboard.SetTarget(topAnimation, tips);
                Storyboard.SetTargetProperty(topAnimation, new PropertyPath("(UIElement.Opacity)"));

                story.Children.Add(topAnimation);

                popup.IsOpen = true;
                story.Begin();
                //动画延迟2秒
                story.Duration = new Duration(new TimeSpan(0, 0, 2));
                //story.BeginTime = new TimeSpan(0, 0, 0, 0, 1);
                story.Completed += (s1, e1) =>
                {
                    //2s后执行此方法
                    clickCount = 0;
                    popup.IsOpen = false;
                    story.Stop();
                };
            }

        }
    }
}