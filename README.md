# Enhanced Console Application Template

[![Nuget](https://img.shields.io/nuget/v/TH.Utility.EnhancedConsoleApplicationTemplate?label=NuGet)](https://www.nuget.org/packages/TH.Utility.EnhancedConsoleApplicationTemplate/)

![Nuget](https://img.shields.io/nuget/dt/TH.Utility.EnhancedConsoleApplicationTemplate?label=Downloads)

Console application template with appsettings configuration, dependency injection, and some useful extensions.

## Using this template with the dotnet CLI && NuGet

1. Make sure that you have [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) installed

2. Open your terminal of choice and use the following command to download and install the latest version of the template:

    ```bash
    dotnet new --install TH.Utility.EnhancedConsoleApplicationTemplate::1.2.5
    ```

3. Navigate to a directory where the new console app should be created

4. Use the following command (with or without optional configurations) to create your project:

    ```bash
    dotnet new enhancedasyncconsole -n "Your Project Name Here" --title "Your Console Window Title Here"
    ```
    
## Using this template with the dotnet CLI and a local clone of this repository

1. Make sure that you have [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) installed

2. Clone the repository (can be achieved from the command line using the following command)
    ```bash
    git clone https://github.com/thall90/EnhancedConsoleAppTemplate.git
    ```

2. Open your terminal of choice and use the following command to install the template from the local repository directory:

    ```bash
    dotnet new --install YourCodeDirectory/EnhancedConsoleAppTemplate/EnhancedConsole.ApplicationTemplate
    ```

3. Navigate to a directory where the new console app should be created

4. Use the following command (with or without optional configurations) to create your project:

    ```bash
    dotnet new enhancedasyncconsole -n "Your Project Name Here" --title "Your Console Window Title Here"
    ```

## Resources

[Hosted NuGet Page](https://www.nuget.org/packages/TH.Utility.EnhancedConsoleApplicationTemplate/)
