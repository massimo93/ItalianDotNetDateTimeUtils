# Change Log
All notable changes to this project will be documented in this file.

## [1.1.1](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/1.1.1) - 2025-02-03
Authors' Copyright update for 2025.

### Changed
- Update package's authors list and new year Copyright.

## [1.1.0](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/1.1.0) - 2024-12-08
Improved user's documentation and new names for some existing methods, while keeping backward compatibility.

### Added
- Improve user's documentation
- New code usage samples in README.md
- New console application to provide users some relevant code samples and real world usages as part of the GitHub repository.

### Changed
#### A first draft of some methods' new names to reduce their verbosity:

- `IsItalianWorkersDay()` method will start replacing `IsWorkersDay()`
- `GetYearlyHolidays()` method will start replacing `GetYearlyItalianHolidays()`
- `GetHolidaysInRange()` method will start replacing `GetItalianHolidaysInRange()`
- `HowManyOfficeDaysBetweenDates()` method will start replacing `HowManyItalianOfficeDaysBetweenDates()`
- `HowManyWorkDaysBetweenDates()` method will start replacing `HowManyItalianWorkDaysBetweenDates()`.

## [1.0.5](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/1.0.5) - 2024-11-30
Update license acceptance terms.

### Changed
- Ask user to accept the license terms when installing and using the library.

## [1.0.3](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/1.0.3) - 2024-11-30
Initial publicly available release based on a fork of the [original project](https://github.com/davideborghi/ItalianDotNetDateTimeUtils).

### Added
- Migration to **[.NET Standard 2.0](https://learn.microsoft.com/dotnet/standard/net-standard?tabs=net-standard-2-0)**
- Relevant rewrite and **refactor** of core components
- New `DateUtils.cs` class providing simple static `DateTime` utility methods
- New `ItalianHolidaysUtils.cs` class providing static utility methods when working with Italian holidays checks
- New `ItalianWorkDaysUtils.cs` class providing static utility methods when dealing with Italian work days calculations
- New `DateTimeExtensions.cs` class to provide extension methods for `DateTime`, supporting equality check, week and weekends, days of months, quarters and four-month periods
- New `DateTimeHolidaysExtensions.cs` class to provide extension methods when working with DateTime objects related to national holidays.

### Changed
- Standardize APIs language from Italian to English.

### Removed
- APIs using the Italian language as method name.
