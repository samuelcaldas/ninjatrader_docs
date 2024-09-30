
NinjaScript \> Language Reference \> Strategy \> OrderFillResolutionType
OrderFillResolutionType
| \<\< [Click to Display Table of Contents](orderfillresolutiontype.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> OrderFillResolutionType | [Previous page](orderfillresolution.md) [Return to chapter overview](strategy.md) [Next page](orderfillresolutionvalue.md) |
| --- | --- |
## Definition
Determines the bars type which will be used for historical fill processing.
## 
| Note: This property will only be valid if the [OrderFillResolution](orderfillresolution.md) is set to OrderFillResolution.High |
| --- |

## 
## 
## Property Value
A [BarsPeriodType](barsperiod.md) representing the type of bars during historical order processing.  Default value is set to BarsPeriodType.Minute.
 
## Syntax
OrderFillResolutionType
## 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |

## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {                  Name \= "ExampleStrategy";        // use one second bars for filling orders      OrderFillResolution       \= OrderFillResolution.High;                     OrderFillResolutionType   \= BarsPeriodType.Second;      OrderFillResolutionValue   \= 1;     }        } |

 
