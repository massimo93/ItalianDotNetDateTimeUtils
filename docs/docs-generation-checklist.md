## Docs generation checklist

### Introduction and scope
This markdown file aims to be an initial short guide to follow when markdown docs need to be generated and added to the repo.
Generally, every time a new release is ready, we as maintainers should update the available docs.

### Used tools
We picked the following open source [Markdown generator tool](https://github.com/ap0llo/mddocs), that is able to produce markdown files starting from targeted assemblies.
This generator offers a CLI tool that has been used to upstart the documentation that can be found under 'generated/Dabomase' directory.

### Guided checklist

1. Install or update the CLI tool as a .NET global tool using the following command:

    **dotnet tool install --global Grynwald.MdDocs**

2. Prepare to generate the markdown docs files:
    - Before starting the docs generation, **make sure** you created the _local_ Nuget package (see [here](nuget-checklist.md)) and that the Dabomase.ItalianDateTimeUtils.csproj has _GenerateDocumentationFile_ set to **True** : this is because Grynwald.MdDocs makes use of the .NET documentation XML file that these setting triggers when the project is built, otherwise the generation either won't work or will produce any updated document
    - To generated updated docs, bear in mind to specify the destination folder with caution, because the tool **overrides** all the speciefied folder content.
    - To keep consistency in the repository, PROJECT_ASSEMBLY_PATH should be something like _src/Dabomase.ItalianDateTimeUtils/bin/release/netstandard2.0/Dabomase.ItalianDateTimeUtils.dll_ and GENERATED_DOCS_FOLDER should be replaced with _docs/generated_, only bear in mind to launch the command inside the main repository directory, i.e. _dabomase-italian-datetime-utils_.
    - With this in mind, run the following command, replacing PROJECT_ASSEMBLY_PATH and GENERATED_DOCS_FOLDER placeholders with respective values:
    
    **mddocs apireference -a PROJECT_ASSEMBLY_PATH -o GENERATED_DOCS_FOLDER**

4. Commit and push your changes to GitHub.

5. As always, now you deserve to enjoy your :coffee: or :tea: or :beer:!
