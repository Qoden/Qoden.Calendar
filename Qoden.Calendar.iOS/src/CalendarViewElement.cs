using System;
using Foundation;
using UIKit;
using CoreGraphics;
using Qoden.UI;

namespace Qoden.Calendar.iOS
{
    public class CalendarViewElement : QodenView
    {
        public CalendarViewElement()
        {
        }

        public CalendarViewElement(NSCoder coder) : base(coder)
        {
        }

        public CalendarViewElement(NSObjectFlag t) : base(t)
        {
        }

        public CalendarViewElement(IntPtr handle) : base(handle)
        {
        }

        public CalendarViewElement(CGRect frame) : base(frame)
        {
        }

        UILabel title;

        public UILabel Title
        {
            get
            {
                if (title == null)
                {
                    title = new UILabel();
                    AddSubview(title);
                    SendSubviewToBack(title);
                }
                return title;
            }
        }

        protected override void OnLayout(LayoutBuilder layout)
        {
            if (title != null)
            {
                layout.View(title)
                     .AutoSize()
                     .CenterVertically().CenterHorizontally();
            }
        }

        public string ReuseId { get; set; }
    }
}
