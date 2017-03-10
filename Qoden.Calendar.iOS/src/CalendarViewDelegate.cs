using System;

namespace Qoden.Calendar.iOS
{
	public interface ICalendarViewDelegate
	{
		CalendarViewElement GetHeader(CalendarView view, DayOfWeek weekDay, DayRange range);

		CalendarViewElement GetCell(CalendarView view, DateTime day, DayRange range);

		void CellSelected(CalendarView view, DateTime day, CalendarViewElement cell);
	}

	public class CalendarViewDelegate : ICalendarViewDelegate
	{
		public virtual CalendarViewElement GetHeader(CalendarView view, DayOfWeek weekDay, DayRange range)
		{
			var cell = view.DequeReusableElement("Header") ?? new CalendarViewElement { ReuseId = "Header" };
			cell.Title.Text = GetHeaderTitle(view, weekDay, range);
			return cell;
		}

		public virtual CalendarViewElement GetCell(CalendarView view, DateTime day, DayRange range)
		{
			var cell = view.DequeReusableElement("Day") ?? new CalendarViewElement { ReuseId = "Day" };
			cell.Title.Text = GetCellTitle(view, day, range);
			return cell;
		}

		public virtual void CellSelected(CalendarView view, DateTime day, CalendarViewElement cell)
		{
		}

		public virtual string GetHeaderTitle(CalendarView view, DayOfWeek weekDay, DayRange range)
		{
			return view.Culture.DateTimeFormat.AbbreviatedDayNames[(int)weekDay];
		}

		public virtual string GetCellTitle(CalendarView view, DateTime day, DayRange range)
		{
			return day.Day.ToString();
		}
	}

}
