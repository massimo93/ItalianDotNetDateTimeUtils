using System.Reflection;
using Dabomase.ItalianDateTimeUtils;

Console.WriteLine("\n********************************************************");
Console.WriteLine($"*** {Assembly.GetExecutingAssembly().GetName().Name} ***");
Console.WriteLine("********************************************************\n");

//IsHoliday method usage samples
var isTodayItalianHoliday = ItalianHolidaysUtils.IsHoliday(DateTime.UtcNow);
var wasLastNovemberTheFirstItalianHoliday = ItalianHolidaysUtils.IsHoliday(new DateTime(2024, 11, 1));

//Console printouts
Console.WriteLine($"{nameof(isTodayItalianHoliday)}: {isTodayItalianHoliday}");
Console.WriteLine($"{nameof(wasLastNovemberTheFirstItalianHoliday)}: {wasLastNovemberTheFirstItalianHoliday}");