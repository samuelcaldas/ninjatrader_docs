
NinjaScript > Language Reference > Strategy > OrderFillResolutionValue
OrderFillResolutionValue
| << [Click to Display Table of Contents](orderfillresolutionvalue.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > OrderFillResolutionValue | [Previous page](orderfillresolutiontype.md) [Return to chapter overview](strategy.md) [Next page](strategy_performancemetrics.md) |
| --- | --- |
## Definition
Determines the bars period interval value which will be used for historical fill processing.
## 
| Note: This property will only be valid if the [OrderFillResolution](orderfillresolution.md) is set to OrderFillResolution.High |
| --- |

## 
## Property Value
A int representing the interval used for the bars period during historical order processing.  Default value is set to 1.
 
## Syntax
OrderFillResolutionValue
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |

## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {                  Name = "ExampleStrategy";        // use one second bars for filling orders      OrderFillResolution       = OrderFillResolution.High;                     OrderFillResolutionType   = BarsPeriodType.Second;      OrderFillResolutionValue   = 1;     }        } |

 
