
NinjaScript \> Language Reference \> Strategy \> OrderFillResolutionValue
OrderFillResolutionValue
| \<\< [Click to Display Table of Contents](orderfillresolutionvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> OrderFillResolutionValue | [Previous page](orderfillresolutiontype-1.md) [Return to chapter overview](strategy-1.md) [Next page](strategy_performancemetrics-1.md) |
| --- | --- |
## Definition
Determines the bars period interval value which will be used for historical fill processing.
## 
| Note: This property will only be valid if the [OrderFillResolution](orderfillresolution-1.md) is set to OrderFillResolution.High |
| --- |

## 
## Property Value
A int representing the interval used for the bars period during historical order processing.  Default value is set to 1\.
 
## Syntax
OrderFillResolutionValue
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |

## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {                  Name \= "ExampleStrategy";        // use one second bars for filling orders      OrderFillResolution       \= OrderFillResolution.High;                     OrderFillResolutionType   \= BarsPeriodType.Second;      OrderFillResolutionValue   \= 1;     }        } |

 
