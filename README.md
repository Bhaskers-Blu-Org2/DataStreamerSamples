<!---
  samplefwlink: https://aka.ms/DataStreamerSamples
--->

# Microsoft Data Streamer (available in Excel) app samples

This repo contains the samples that demonstrate the API communication patterns for the Microsoft Data Streamer (available in Excel) in the Windows Software Development Kit (SDK) for Windows 10. These code samples were created with the Universal Windows Platform templates available in Visual Studio, and are designed to run on desktop, mobile, and future devices that support the Universal Windows Platform.

> **Note:** If you are unfamiliar with Git and GitHub, you can download the entire collection as a 
> [ZIP file](https://github.com/Microsoft/DataStreamerSamples/archive/master.zip), but be 
> sure to unzip everything to access shared dependencies. For more info on working with the ZIP file, 
> the samples collection, and GitHub, see [Get the UWP samples from GitHub](https://aka.ms/DataStreamerSamples). 
> For more samples, see the [Samples portal](https://github.com/Microsoft/Windows-universal-samples). 

## Data Streamer communication app development

These samples require Visual Studio 2017 Update 4 or higher and the Windows Software Development Kit (SDK) version 17134 for Windows 10.

   [Get a free copy of Visual Studio 2017 Community Edition with support for building Universal Windows Platform apps](http://go.microsoft.com/fwlink/p/?LinkID=280676)

Additionally, to stay on top of the latest updates to Windows and the development tools, become a Windows Insider by joining the Windows Insider Program.

   [Become a Windows Insider](https://insider.windows.com/)

## Using the samples

The easiest way to use these samples without using Git is to download the zip file containing the current version (using the following link or by clicking the "Download ZIP" button on the repo page). You can then unzip the entire archive and use the samples in Visual Studio 2017.

   [Download the samples ZIP](../../archive/master.zip)

   **Notes:** 
   * Before you unzip the archive, right-click it, select **Properties**, and then select **Unblock**.
   * Be sure to unzip the entire archive, and not just individual samples. The samples all depend on the SharedContent folder in the archive.   
   * In Visual Studio 2017, the platform target defaults to ARM, so be sure to change that to x64 or x86 if you want to test on a non-ARM device. 
   
The samples use Linked files in Visual Studio to reduce duplication of common files, including sample template files and image assets. These common files are stored in the SharedContent folder at the root of the repository, and are referred to in the project files using links.

**Reminder:** If you unzip individual samples, they will not build due to references to other portions of the ZIP file that were not unzipped. You must unzip the entire archive if you intend to build the samples.

For more info about the programming models, platforms, languages, and APIs demonstrated in these samples, please refer to the guidance, tutorials, and reference topics provided in the Windows 10 documentation available in the [Windows Developer Center](http://go.microsoft.com/fwlink/p/?LinkID=532421). These samples are provided as-is in order to indicate or demonstrate the functionality of the programming models and feature APIs for Windows.

## Contributions

These samples are direct from the feature teams and we welcome your input on issues and suggestions for new samples. At this time we are not accepting new samples from the public, but check back here as we evolve our contribution model.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## See also
 
For additional UWP samples, see the [Samples portal](https://github.com/Microsoft/Windows-universal-samples). 
For additional Windows samples, see [Windows on GitHub](http://microsoft.github.io/windows/). 
