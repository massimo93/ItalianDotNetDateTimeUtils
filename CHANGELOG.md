# Change Log

All notable changes to this project will be documented in this file.

## Unreleased
Upgrade to .NET Standard 2.0 and include a relevant overall refactoring.

### Added
- Migration to **[.NET Standard 2.0](https://learn.microsoft.com/it-it/dotnet/standard/net-standard?tabs=net-standard-2-0)**;
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

## [1.0.2](https://www.nuget.org/packages/DavideBorghi.ItalianDotNetDateTimeUtils/1.0.2) - 2022-07-11
Add support to _trimestri_ (quarters) and _quadrimestri_ (four month periods).

## [1.0.1](https://www.nuget.org/packages/DavideBorghi.ItalianDotNetDateTimeUtils/1.0.1) - 2021-06-15
Add calculation of the last-n working days.

## [1.0.0](https://www.nuget.org/packages/DavideBorghi.ItalianDotNetDateTimeUtils/1.0.0) - 2021-02-07
No release notes.

## [0.0.0.1](https://www.nuget.org/packages/DavideBorghi.ItalianDotNetDateTimeUtils/0.0.0.1) - 2021-01-25
Initial release