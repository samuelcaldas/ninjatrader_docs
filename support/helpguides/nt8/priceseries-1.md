
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\>

PriceSeries\<double\>

| \<\< [Click to Display Table of Contents](priceseries.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> PriceSeries\<double\> | [Previous page](reset-1.md) [Return to chapter overview](iseriest-1.md) [Next page](close-1.md) |
| --- | --- |
## Definition
Represents historical data as an ISeries\<double\> interface which can be used for custom NinjaScript object calculations.
 

| Note:  In most cases, you will access the historical price series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical price series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, which may cause errors when trying to obtain this information.  In those cases, please use the Bars.Get...() methods with the absolute bar index, e.g., [Bars.GetClose()](getclose-1.md), [Bars.GetOpen()](getopen-1.md), etc. |
| --- |

## Single ISeries\<double\>

| [Close](close-1.md) | A collection of historical bar close prices. |
| --- | --- |
| [High](high-1.md) | A collection of historical bar high prices. |
| [Input](input-1.md) | A collect of the the main historical input values. |
| [Low](low-1.md) | A collection of historical bar low prices. |
| [Median](median-1.md) | A collection of historical bar median prices. |
| [Open](open-1.md) | A collection of historical bar open prices. |
| [Typical](typical-1.md) | A collection of historical bar typical prices. |
| [Value](value-1.md) | A collection of historical references to the first object (Values\[0]) in the indicator |
| [Weighted](weighted-1.md) | A collection of historical bar weighted prices. |
## 
## 
## Multi\-Time Frame ISeries\<double\>

| [Closes](closes-1.md) | Holds an array of ISeries\<double\> objects holding historical bar close prices. |
| --- | --- |
| [Highs](highs-1.md) | Holds an array of ISeries\<double\> objects holding historical bar high prices. |
| [Inputs](inputs-1.md) | Holds an array of ISeries\<double\> objects holding main historical input values |
| [Lows](lows-1.md) | Holds an array of ISeries\<double\> objects holding historical bar low prices. |
| [Medians](medians-1.md) | Holds an array of ISeries\<double\>objects holding historical bar median prices. |
| [Opens](opens-1.md) | Holds an array of ISeries\<double\> objects holding historical bar open prices. |
| [Typicals](typicals-1.md) | Holds an array of ISeries\<double\> objects holding historical bar typical prices. |
| [Values](values-1.md) | Holds an array of ISeries\<double\> objects holding hold the indicator's underlying calculated values. |
| [Weighteds](weighteds-1.md) | Holds an array of ISeries\<double\> objects holding historical bar weighted prices. |
 
