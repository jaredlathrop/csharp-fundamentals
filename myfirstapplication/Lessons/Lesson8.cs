
namespace myfirstapplication;

internal class Lesson8
	{
	/*
	 Constants and static
	 */
	public const int Months = 12;
	public const int Weeks = 52;
	public const int Days = 365; // per year
	public const int Hours = 24; // per day

	public const double DaysPerMonth = (double)Days / (double)Months;

	public static int DayCount;
	public static int _days;
	public Lesson8(int CallDays)
    {
		_days = CallDays;
    }

	public static int CalculateDayCount()
    {
		return ++DayCount;
    }

	public void CalcHours()
    {
		int total = Hours * _days;
		Console.WriteLine($"The total hours for {_days} is {total}");
		CalculateDayCount();
    }

	public void CalcHoursV2()
    {
		Func<int, int> totalHours = static value => Hours * value;
		Console.WriteLine($"The total version 2 hours for {_days} is" +
			$" {totalHours(_days)}");
    }
		
	/*
	 
	 */
	} // end class

