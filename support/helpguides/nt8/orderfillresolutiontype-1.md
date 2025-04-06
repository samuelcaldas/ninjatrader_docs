



OrderFillResolutionType

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\orderfillresolutiontype.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  OrderFillResolutionType | [Previous page](orderfillresolution-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](orderfillresolutionvalue-1.htm) |

Definition
----------

Determines the bars type which will be used for historical fill processing.

|  |
| --- |
| Note: This property will only be valid if the [OrderFillResolution](orderfillresolution-1.htm) is set to OrderFillResolution.High |

Property Value
--------------

A [BarsPeriodType](barsperiod-1.htm) representing the type of bars during historical order processing.  Default value is set to BarsPeriodType.Minute.

Syntax 
OrderFillResolutionType
-------------------------------

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults |

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {                   Name = "ExampleStrategy";          // use one second bars for filling orders       OrderFillResolution       = OrderFillResolution.High;                      OrderFillResolutionType   = BarsPeriodType.Second;       OrderFillResolutionValue   = 1;      }          } |