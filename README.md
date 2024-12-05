# dabomase-italian-datetime-utils

## Introduction

### Hello everybody!

My name is __Dabomase.ItalianDateTimeUtils__ and I'm a class library originally written by [Davide Borghi](https://www.linkedin.com/in/davide-borghi-87364014a/). 
He wrote me because he was bored to copy and paste a static class in every project he was working on.

Another stubborn developer, [Massimo Serra](https://www.linkedin.com/in/massimo-serra/), also decided to support Davide with my code.

As a humble, simple and pluggable .NET Standard 2.0 utility library, my role is to help Italian developers or any developer who need support when dealing with Italian holidays (both national and customizable local ones) and work days calculations, which sometimes can be really boring!

**Even if I have a good set of unit tests, my developers are committed to extend my features and documentation too, so be patient with me, I promise, they're working hard on these things in their spare time!**

For this reason, please, feel free to file comments, open issues and, if you want, even fork my code and open pull requests: only bear in mind to check my open source license to be nice with me.

You can find me on **[NuGet](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils)**!

And by the way, if you want to know me better, [here's my changelog](https://github.com/massimo93/dabomase-italian-datetime-utils/blob/develop/CHANGELOG.md).

## Developers' guide

### Installation and prerequisites

The library uses .NET Standard 2.0 to support both .NET Framework and .NET (Core).

You should install the latest version [via NuGet](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils):

    Install-Package Dabomase.ItalianDateTimeUtils
    
Or via the .NET Core command line interface:

    dotnet add package Dabomase.ItalianDateTimeUtils

### A general overview
These are the main utility static classes:
- `DateUtils.cs` provides `DateTime` general purpose utility methods;
- `ItalianHolidaysUtils.cs` has methods to work with Italian holidays checks;
- `ItalianWorkDaysUtils.cs` gives you methods to deal with Italian work days calculations.

While the following classes offers custom extensions to the `DateTime` type:
- `DateTimeExtensions.cs` supports equality check, week and weekends, days of months, quarters and four-month periods;
- `DateTimeHolidaysExtensions.cs` adds to the `DateTime` simple boolean methods to check if given date is an Italian holiday or not.

### A quick start
Let's say you want me to check if a given date is an Italian holiday:
```cs
bool isHoliday = ItalianHolidaysUtils.IsHoliday(new DateTime(2024, 1, 1));
```
or you want me to list all yearly Italian holidays or from a selected `DateTime` range:
```cs
var startDate = new DateTime(2024, 3, 15);
var endDate = new DateTime(2025, 12, 15);

var italianHolidaysFor2024 = ItalianHolidaysUtils.GetYearlyItalianHolidays(2024);
var italianHolidaysInRange = ItalianHolidaysUtils.GetItalianHolidaysInRange(startDate, endDate);
```

When it comes to work days calculations, I can either calculate the number of office days given two dates:
```cs
var startDate = new DateTime(2024, 7, 16);
var endDate = new DateTime(2024, 12, 15);

var italianOfficeDaysInRangeCount = 
    ItalianWorkDaysUtils.HowManyItalianOfficeDaysBetweenDates(startDate, endDate);
```
or even use `Func` to specify what kind of work days condition you want, either built-in or your own; let me show you:
```cs
var startDate = new DateTime(2024, 7, 16);
var endDate = new DateTime(2024, 12, 15);

var italianOfficeDaysInRangeCount = 
    ItalianWorkDaysUtils.HowManyItalianOfficeDaysBetweenDates(startDate, endDate);

var workDaysInRangeExcludingSundaysCount = 
    ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(
        startDate, endDate, 
        workDaysCondition: ItalianWorkDaysUtils.ExcludeSundaysCondition);

var evenWorkDaysInRangeCount = 
    ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(
        startDate, endDate, 
        workDaysCondition: ItalianWorkDaysUtils.IncludeOnlyEvenDaysCondition);

var allDaysAsWorkingDaysInRangeCount = 
    ItalianWorkDaysUtils.HowManyItalianWorkDaysBetweenDates(
        startDate, endDate, 
        workDaysCondition: date => true);
```

### Full user documentation
You can find generated markdown files documenting the available APIs [here](https://github.com/massimo93/dabomase-italian-datetime-utils/blob/develop/docs/generated/Dabomase/ItalianDateTimeUtils/index.md) to foresee more advanced use cases and utilities.

Keep also in mind to regularly check my [GitHub repo](https://github.com/massimo93/dabomase-italian-datetime-utils) to see if me developers either packed a new release version or added new use case samples.

Feel free to take a look at the tests project to further explore what I can do for you with real world data sets.

## Maintainers' guide

### In short
Maintainers can find under the [docs](https://github.com/massimo93/dabomase-italian-datetime-utils/tree/develop/docs) directory the following files:
1. [NuGet checklist](https://github.com/massimo93/dabomase-italian-datetime-utils/blob/develop/docs/nuget-checklist.md) to help them pack and release a new version of the NuGet package;
2. [Docs generation checklist](https://github.com/massimo93/dabomase-italian-datetime-utils/blob/develop/docs/docs-generation-checklist.md) to guide them generate documents from code using an open source CLI tool;
3. [Generated docs' parent folder](https://github.com/massimo93/dabomase-italian-datetime-utils/tree/develop/docs/generated).

### Code of conduct
Currently used code of conduct can be found [here](https://github.com/massimo93/dabomase-italian-datetime-utils/blob/develop/CODE_OF_CONDUCT.md).
