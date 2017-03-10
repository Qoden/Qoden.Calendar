using System;
using Foundation;
using UIKit;
using CoreGraphics;
using Qoden.UI.iOS;

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

		public override void LayoutSubviews()
		{
			if (title != null)
			{
				title.SizeToFit();
				title.Frame = this.LayoutBox()
					.CenterVertically().CenterHorizontally().Width(title).Height(title)
					.AsCGRect();
			}
		}

		public string ReuseId { get; set; }
	}
}
