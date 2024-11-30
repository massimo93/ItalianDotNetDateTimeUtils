## NuGet checklist

### Introduction and scope
This markdown file aims to be an initial short guide to follow when a new release needs to be packed and published to NuGet.

### Guided checklist
The following checklist content has been suggested by reading this [blog post](https://ardalis.com/nuget-publication-checklist) by Steve Smith (Ardalis). 

1. Update **Dabomase.ItalianDateTimeUtils.csproj** providing:
    - Version number update (e.g.: <Version>2.0.0</Version>);
    - Package release notes (e.g.: <PackageReleaseNotes>Fix #120 and #121 issues.<PackageReleaseNotes>);
    - Update Copyright, if relevant (e.g.: <copyright>Copyright 2024</copyright>).

2. Create a package locally by navigating to _src/Dabomase.ItalianDateTimeUtils_ directory and by runnning the following command:

    **dotnet pack -c Release**

3. Push package to NuGet by navigating inside _src/Dabomase.ItalianDateTimeUtils/bin/release_ directory and by running the following command, specifying YOUR_NUGET_API_KEY with valid (i.e. not expired) API Key value from [NuGet &#8594; Account &#8594; Api Keys](https://www.nuget.org/account/apikeys) menu
and PACKAGE_VERSION (e.g: 2.0.0):

    **dotnet nuget push -s https://www.nuget.org/api/v2/package -k YOUR_NUGET_API_KEY Dabomase.ItalianDateTimeUtils.PACKAGE_VERSION.nupkg**

4. Check if the new version of the package is already available on [NuGet](https://www.nuget.org/packages/Dabomase.ItalianDateTimeUtils/).

5. Update the [CHANGELOG](../CHANGELOG.md) file adding the new detailed entry.

6. Now, you deserve to enjoy your :coffee: or :tea: or :beer:!
