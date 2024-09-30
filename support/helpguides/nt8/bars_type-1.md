
NinjaScript \> Language Reference \> Bars Type

Bars Type
| \<\< [Click to Display Table of Contents](bars_type.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> Bars Type | [Previous page](tabcontrolmanager-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](addbar-1.md) |
| --- | --- |
Creating custom Bars Types allows for incredible flexibility in the way you want to present data in a chart. The methods and properties covered in this section are unique to custom Bars Type development.
 
## Methods and Properties
| [AddBar()](addbar-1.md) | Adds new data points for the Bars Type. |
| --- | --- |
| [ApplyDefaultBasePeriodValue](applydefaultbaseperiodvalue-1.md) | Sets the default base values used for the [BarsPeriod](barsperiod-1.md) selected by the user (e.g., the default PeriodValue, DaysToLoad, etc.) for your custom Bar Type. |
| [ApplyDefaultValue](applydefaultvalue-1.md) | Sets the default [BarsPeriod](barsperiod-1.md) values used for a custom Bar Type. |
| [BuiltFrom](builtfrom-1.md) | Determines the base dataset used to build the BarsType (i.e., Tick, Minute, Day). |
| [GetInitialLookBackDays()](getinitiallookbackdays-1.md) | Determines how many days of data load when a user makes a "bars back" data request. |
| [GetPercentComplete()](getpercentcomplete-1.md) | Determines the value your BarsType would return for [Bars.PercentComplete](percentcomplete-1.md) |
| [Icon](icon_barstype-1.md) | The shape which displays next to the Bars Type menu item. |
| [IsRemoveLastBarSupported](isremovelastbarsupported-1.md) | Determines if the bars type can use the [RemoveLastBar()](removelastbar-1.md) method when true, otherwise an exception will be thrown. |
| [IsTimebased](barstype_istimebased-1.md) | Used to indicate the BarsType is built from time\-based bars (day, minute, second). |
| [OnDataPoint()](ondatapoint-1.md) | OnDataPoint() method is where you should adjust data points (bar values) of your series through [AddBar()](addbar-1.md) and [UpdateBar()](updatebar-1.md). |
| [RemoveLastBar()](removelastbar-1.md) | Removes the last data point for the Bars Type. |
| [SessionIterator](barstype_sessioniterator-1.md) | Provides trading session information to the bars type. Must be built using the bars object. |
| [UpdateBar()](updatebar-1.md) | Updates a data point in our Bars Type. |
