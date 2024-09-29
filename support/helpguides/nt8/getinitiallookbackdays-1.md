


NinjaScript \> Language Reference \> Bars Type \> GetInitialLookBackDays()






















GetInitialLookBackDays()







| \<\< [Click to Display Table of Contents](getinitiallookbackdays.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Bars Type](bars_type-1.md) \> GetInitialLookBackDays() | [Previous page](defaultchartstyle-1.md) [Return to chapter overview](bars_type-1.md) [Next page](getpercentcomplete-1.md) |
| --- | --- |











## Definition


Determines how many days of data load when a user makes a "bars back" data request.


 


## Method Return Value


This method returns an int value.


## 


## Method Parameters




| barsPeriod | The [bars period](barsperiod-1.md) chosen by the user when utilizing this Bars type |
| --- | --- |
| tradingHours | The [trading hours](tradinghours-1.md) chosen by the user when utilizing this Bars type |
| barsBack | The bars back chosen by the user when utilizing this Bars type |



 


## Syntax
You must override the method in your Bars Type with the following syntax.


   

public override int GetInitialLookBackDays(BarsPeriod barsPeriod, TradingHours tradingHours, int barsBack)   

{  

   

}


 


## 


## Examples




| ns |
| --- |
| public override int GetInitialLookBackDays(BarsPeriod barsPeriod, TradingHours tradingHours, int barsBack) {      // Returns the minimum number of days needed to successfully load the number      // of bars back requested for a monthly Bars type      return (int) barsPeriod.Value \* barsBack \* 31; } |



 


 




| Tip:  Try to request an amount of data that is just right for what is needed. Requesting too large a data set will result in unnecessary data being loaded. Requesting too small a data set will result in multiple requests being done. |
| --- |









