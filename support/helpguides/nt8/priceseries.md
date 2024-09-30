
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\>
PriceSeries\<double\>
| \<\< [Click to Display Table of Contents](priceseries.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> PriceSeries\<double\> | [Previous page](reset.md) [Return to chapter overview](iseriest.md) [Next page](close.md) |
| --- | --- |
## Definition
Represents historical data as an ISeries\<double\> interface which can be used for custom NinjaScript object calculations.
 
| Note:  In most cases, you will access the historical price series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical price series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, which may cause errors when trying to obtain this information.  In those cases, please use the Bars.Get...() methods with the absolute bar index, e.g., [Bars.GetClose()](getclose.md), [Bars.GetOpen()](getopen.md), etc. |
| --- |

## Single ISeries\<double\>
| [Close](close.md) | A collection of historical bar close prices. |
| --- | --- |
| [High](high.md) | A collection of historical bar high prices. |
| [Input](input.md) | A collect of the the main historical input values. |
| [Low](low.md) | A collection of historical bar low prices. |
| [Median](median.md) | A collection of historical bar median prices. |
| [Open](open.md) | A collection of historical bar open prices. |
| [Typical](typical.md) | A collection of historical bar typical prices. |
| [Value](value.md) | A collection of historical references to the first object (Values\[0]) in the indicator |
| [Weighted](weighted.md) | A collection of historical bar weighted prices. |

## 
## 
## Multi\-Time Frame ISeries\<double\>
| [Closes](closes.md) | Holds an array of ISeries\<double\> objects holding historical bar close prices. |
| --- | --- |
| [Highs](highs.md) | Holds an array of ISeries\<double\> objects holding historical bar high prices. |
| [Inputs](inputs.md) | Holds an array of ISeries\<double\> objects holding main historical input values |
| [Lows](lows.md) | Holds an array of ISeries\<double\> objects holding historical bar low prices. |
| [Medians](medians.md) | Holds an array of ISeries\<double\>objects holding historical bar median prices. |
| [Opens](opens.md) | Holds an array of ISeries\<double\> objects holding historical bar open prices. |
| [Typicals](typicals.md) | Holds an array of ISeries\<double\> objects holding historical bar typical prices. |
| [Values](values.md) | Holds an array of ISeries\<double\> objects holding hold the indicator's underlying calculated values. |
| [Weighteds](weighteds.md) | Holds an array of ISeries\<double\> objects holding historical bar weighted prices. |

 
