


NinjaScript \> Language Reference \> Add On \> IIntervalProvider Interface






















IIntervalProvider Interface







| \<\< [Click to Display Table of Contents](iintervalprovider_interface.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> IIntervalProvider Interface | [Previous page](iinstrumentprovider_instrument-1.md) [Return to chapter overview](add_on-1.md) [Next page](iintervalprovider_barsperiod-1.md) |
| --- | --- |











When creating your [NTTabPage](nttabpage_class-1.md), if you wish to use the [interval link](linking_windows-1.md), be sure to implement the IIntervalProvider interface.


 


## 


## Examples




| ns |
| --- |
| public class MyWindowTabPage : NTTabPage, IIntervalProvider {      public MyWindowTabPage()      {          /\* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts          if we so choose here as well.             Note: XAML with event handlers defined inside WILL FAIL when attempted to load.           Note: XAML with "inline code" WILL FAIL when attempted to load \*/      }        // IIntervalProvider member      public BarsPeriod BarsPeriod { get; set; }        // Be sure to include all the required NTTabPage members as well } |









