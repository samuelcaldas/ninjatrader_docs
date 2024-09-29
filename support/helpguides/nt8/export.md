


NinjaScript \> Distribution \> Export






















Export







| \<\< [Click to Display Table of Contents](export.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Distribution](distribution.md) \> Export | [Previous page](import.md) [Return to chapter overview](distribution.md) [Next page](remove-ninjascript-assembly.md) |
| --- | --- |














You can export NinjaScript for others to import in several formats:   

 


•Source files \- NinjaScript source files that can be imported and edited by others 

•Assemblies \- A compiled assembly (DLL) of NinjaScript that "hides" your source code. This can be further [protected by SecureTeam's Agile.NET](protection_dll_security.md) to prevent theft of your intellectual property.

![tog_minus](tog_minus.gif)




| You may want to provide other NinjaTrader users with source files of your NinjaScript in a format where they are able to view and edit them.   1\.From the Control Center window select the menu Tools \> Export \> NinjaScript... to open the "Export NinjaScript" dialog window   2\.Press "add"  3\.Use the "Type" drop down to filter available NinjaScript types   4\.Select all of the files that you want to export and press the "OK" button  5\.A list of all files that will be exported will be shown  6\.Press the "Export" button to export the selected files  7\.A file dialog will open where you can choose the location your zip export file will be created in. Per default the NinjaScript Archive File (.zip) file will be created in My Documents\\\<NinjaTrader Folder\>\\bin\\Custom\\ExportNinjaScript.  8\.The file can be [imported](import.md) by another NinjaTrader application on a different PC | ExportNinjaScript_1 | ExportNinjaScript_2 |
| --- | --- | --- |
|  | | |



![tog_minus](tog_minus.gif)        [Exporting NinjaScript as Assembly](javascript:HMToggle('toggle','ExportingninjascriptAsAssembly','ExportingninjascriptAsAssembly_ICON'))




| You may want to provide other NinjaTrader users with access to your proprietary indicators or strategies in a secure format preventing them from being able to see your proprietary source code. You can do this by exporting your NinjaScript indicators as a compiled Microsoft .NET assembly (DLL) file.    •This is a great distribution option if your proprietary indicator or strategy files do not reference external DLL's •If your proprietary indicator or strategy references external DLL's then its advised to create your own custom installer   1\.From the Control Center window select the menu Tools \> Export \> NinjaScript... to open the "Export NinjaScript" dialog window 2\.Select the option "Export as compiled assembly".3\.You can optionally select "Protect compiled assembly" (For information on protection see the "[Protection/DLL Security](protection_dll_security.md) page) 4\.Press "add"5\.Use the "Type" drop down to filter available NinjaScript types6\.Select all of the files that you want to export and press the "OK" button7\.A list of all files that will be exported will be shown8\.Optionally enter information that describes the assembly in the "Product" and "Version" fields9\.Press the "Export" button to export the selected files 10\.A file dialog will open where you can choose the location your zip export file will be created in. Per default the NinjaScript Archive File (.zip) file will be created in My Documents\\\<NinjaTrader Folder\>\\bin\\Custom\\ExportNinjaScript.11\.The file can be imported by another NinjaTrader application on a different PC | ExportNinjaScript_3 |
| --- | --- |
|  | |










