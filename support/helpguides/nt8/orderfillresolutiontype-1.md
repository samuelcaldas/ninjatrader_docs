


NinjaScript \> Language Reference \> Strategy \> OrderFillResolutionType






















OrderFillResolutionType







| \<\< [Click to Display Table of Contents](orderfillresolutiontype.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> OrderFillResolutionType | [Previous page](orderfillresolution-1.md) [Return to chapter overview](strategy-1.md) [Next page](orderfillresolutionvalue-1.md) |
| --- | --- |











## Definition


Determines the bars type which will be used for historical fill processing.


## 




| Note: This property will only be valid if the [OrderFillResolution](orderfillresolution-1.md) is set to OrderFillResolution.High |
| --- |



## 


## 


## Property Value


A [BarsPeriodType](barsperiod-1.md) representing the type of bars during historical order processing.  Default value is set to BarsPeriodType.Minute.


 


## Syntax
OrderFillResolutionType


## 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |



 


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {                  Name \= "ExampleStrategy";        // use one second bars for filling orders      OrderFillResolution       \= OrderFillResolution.High;                     OrderFillResolutionType   \= BarsPeriodType.Second;      OrderFillResolutionValue   \= 1;     }        } |



 








