# Change Log

All notable changes to this project will be documented in this file.

## [1.0.0](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/1.0.0) - 2024-11-29
Initial release based on a fork of the [original project](https://github.com/davideborghi/ItalianDotNetDateTimeUtils).

### Added
- Migration to **[.NET Standard 2.0](https://learn.microsoft.com/dotnet/standard/net-standard?tabs=net-standard-2-0)**;
- Relevant rewrite and **refactor** of core components;
- New `DateUtils.cs` class providing simple static `DateTime` utility methods;
- New `ItalianHolidaysUtils.cs` class providing static utility methods when working with Italian holidays checks;
- New `ItalianWorkDaysUtils.cs` class providing static utility methods when dealing with Italian work days calculations; 
- New `DateTimeExtensions.cs` class to provide extension methods for `DateTime`, supporting equality check, week and weekends, days of months, quarters and four month periods;
- New `DateTimeHolidaysExtensions.cs` class to provide extension methods when working with DateTime objects related to national holidays.

### Changed
- Standardize APIs language from Italian to English.

### Removed
- APIs using the Italian language as method name.
