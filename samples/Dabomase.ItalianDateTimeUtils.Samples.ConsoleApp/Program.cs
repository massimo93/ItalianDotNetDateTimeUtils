using System.Reflection;
using Dabomase.ItalianDateTimeUtils;

Console.WriteLine("\n********************************************************");
Console.WriteLine($"*** {Assembly.GetExecutingAssembly().GetName().Name} ***");
Console.WriteLine("********************************************************\n");

//IsHoliday method usage samples
var isTodayItalianHoliday = ItalianHolidaysUtils.IsHoliday(DateTime.UtcNow);
var wasLastNovemberTheFirstItalianHoliday = ItalianHolidaysUtils.IsHoliday(new DateTime(2024, 11, 1));

//Get holidays
var italianHolidaysFor2024 = ItalianHolidaysUtils.GetYearlyHolidays(2024);
var italianHolidaysInRange = ItalianHolidaysUtils.GetHolidaysInRange(new DateTime(2024, 3, 15), new DateTime(2025, 12, 15));

//Get work days
var startDate = new DateTime(2024, 7, 16);
var endDate = new DateTime(2024, 12, 15);

var italianOfficeDaysInRangeCount = ItalianWorkDaysUtils.HowManyOfficeDaysBetweenDates(startDate, endDate);
var workDaysInRangeExcludingSundaysCount = ItalianWorkDaysUtils.HowManyWorkDaysBetweenDates(startDate, endDate, workDaysCondition: ItalianWorkDaysUtils.ExcludeSundaysCondition);
var evenWorkDaysInRangeCount = ItalianWorkDaysUtils.HowManyWorkDaysBetweenDates(startDate, endDate, workDaysCondition: ItalianWorkDaysUtils.IncludeOnlyEvenDaysCondition);
var allDaysAsWorkingDaysInRangeCount = ItalianWorkDaysUtils.HowManyWorkDaysBetweenDates(startDate, endDate, workDaysCondition: _ => true);

//Console printouts
Console.WriteLine($"{nameof(isTodayItalianHoliday)}: {isTodayItalianHoliday}");
Console.WriteLine($"{nameof(wasLastNovemberTheFirstItalianHoliday)}: {wasLastNovemberTheFirstItalianHoliday}");

Console.WriteLine("\nItalian holidays in 2024:");
foreach (var holiday in italianHolidaysFor2024)
{
    Console.WriteLine(holiday.Date.ToString("yyyy-M-d dddd"));
}

Console.WriteLine("\nItalian holidays in given range:");
foreach (var holiday in italianHolidaysInRange)
{
    Console.WriteLine(holiday.Date.ToString("yyyy-M-d dddd"));
}

Console.WriteLine($"\nNo. of Italian office days in given range: {italianOfficeDaysInRangeCount}");
Console.WriteLine($"No. of Italian work days excluding Sundays in given range: {workDaysInRangeExcludingSundaysCount}");
Console.WriteLine($"No. of Italian even work days in given range: {evenWorkDaysInRangeCount}");
Console.WriteLine($"No. of Italian all work days in given range: {allDaysAsWorkingDaysInRangeCount}");