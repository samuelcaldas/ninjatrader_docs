
NinjaScript \> Language Reference \> Strategy \> OrderFillResolution
OrderFillResolution
| \<\< [Click to Display Table of Contents](orderfillresolution.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> OrderFillResolution | [Previous page](submitorderunmanaged.md) [Return to chapter overview](strategy.md) [Next page](orderfillresolutiontype.md) |
| --- | --- |
## Definition
Determines how strategy orders are filled during historical states.  
 
Please see [Understanding Historical Fill Processing](understanding_historical_fill_.md) for general information on historical fill processing.
 
## Property Value
An enum value that determines how the strategy orders are filled.  Default value is set to OrderFillResolution.Standard.  Possible values are:
| OrderFillResolution.Standard | Faster \- Uses the existing bar type and interval that you are running the backtest on to fill your orders. |
| --- | --- |
| OrderFillResolution.High | More granular \- Allows you to set a secondary bar series to be used as the price data to fill your orders.   (See also [OrderFillResolutionType](orderfillresolutiontype.md) and [OrderFillResolutionValue](orderfillresolutionvalue.md)) |

 
## Syntax
OrderFillResolution
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |

## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {                  Name \= "ExampleStrategy";      OrderFillResolution \= OrderFillResolution.Standard;    } } |

 
