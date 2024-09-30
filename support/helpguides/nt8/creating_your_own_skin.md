
Configuration \> Options \> General \> Creating your own Skin
Creating your own Skin
| \<\< [Click to Display Table of Contents](creating_your_own_skin.md) \>\> **Navigation:**     [Configuration](configuration.md) \> [Options](options.md) \> [General](general_section.md) \> Creating your own Skin | [Previous page](general_section.md) [Return to chapter overview](general_section.md) [Next page](enabling_disabling-multi-provi.md) |
| --- | --- |
You can create your own skin by creating a copy of the skin template located in the "My Documents \> NinjaTrader \> Templates \> Skins" directory. Do not modify skin templates directly, as on each new installation they will be overwritten by the NinjaTrader installer. Instead, first make a copy of a skin directory, then rename the folder to the desired skin name. On restart of NinjaTrader, the new skin directory will be detected, allowing you to switch over to the skin to activate it.
 
## Skin File Structure
Skins consist of [XAML](https://msdn.microsoft.com/en-us/library/Cc295302.aspx) files corresponding to different windows in the NinjaTrader platform. Each pre\-built skin includes a "BluePrint.xaml" file that contains most of the shared application keys that can be used. In addition to this file, you will find individual XAML files for windows such as FXPro, BasicEntry, and Level2\. 
 
## Creating A New Skin
The most efficient way to customize a skin for NinjaTrader is to begin with an existing skin located in the C:\\Users\\\<user\>\\Documents\\NinjaTrader 8\\templates\\Skins directory on your PC. Each XAML file in the Skins that come pre\-loaded with NinjaTrader is fully commented, with notes pointing to the areas of the application affected by each logical grouping of XAML tags. The following general process can be used when creating a new skin.
 
- Determine which pre\-built skin most closely resembles your end goal

- Copy the folder containing all of the skin's files, then paste and rename the folder in the same directory

oThe files in this new folder will comprise your new skin

- Open BluePrint.xaml for your new skin, and begin to edit the XAML tags as desired

- If you wish to test a change at any time, first save the file you are working on, then close and restart NinjaTrader to view the change

- When finished with BluePrint.xaml, repeat the process for each of the other files 

oThese other files are significantly smaller than BluePrint.xaml
