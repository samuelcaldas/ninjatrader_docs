
NinjaScript > Language Reference > Bars Type

Bars Type
| << [Click to Display Table of Contents](bars_type.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > Bars Type | [Previous page](tabcontrolmanager.md) [Return to chapter overview](language_reference_wip.md) [Next page](addbar.md) |
| --- | --- |
Creating custom Bars Types allows for incredible flexibility in the way you want to present data in a chart. The methods and properties covered in this section are unique to custom Bars Type development.
 
## Methods and Properties
| [AddBar()](addbar.md) | Adds new data points for the Bars Type. |
| --- | --- |
| [ApplyDefaultBasePeriodValue](applydefaultbaseperiodvalue.md) | Sets the default base values used for the [BarsPeriod](barsperiod.md) selected by the user (e.g., the default PeriodValue, DaysToLoad, etc.) for your custom Bar Type. |
| [ApplyDefaultValue](applydefaultvalue.md) | Sets the default [BarsPeriod](barsperiod.md) values used for a custom Bar Type. |
| [BuiltFrom](builtfrom.md) | Determines the base dataset used to build the BarsType (i.e., Tick, Minute, Day). |
| [GetInitialLookBackDays()](getinitiallookbackdays.md) | Determines how many days of data load when a user makes a "bars back" data request. |
| [GetPercentComplete()](getpercentcomplete.md) | Determines the value your BarsType would return for [Bars.PercentComplete](percentcomplete.md) |
| [Icon](icon_barstype.md) | The shape which displays next to the Bars Type menu item. |
| [IsRemoveLastBarSupported](isremovelastbarsupported.md) | Determines if the bars type can use the [RemoveLastBar()](removelastbar.md) method when true, otherwise an exception will be thrown. |
| [IsTimebased](barstype_istimebased.md) | Used to indicate the BarsType is built from time-based bars (day, minute, second). |
| [OnDataPoint()](ondatapoint.md) | OnDataPoint() method is where you should adjust data points (bar values) of your series through [AddBar()](addbar.md) and [UpdateBar()](updatebar.md). |
| [RemoveLastBar()](removelastbar.md) | Removes the last data point for the Bars Type. |
| [SessionIterator](barstype_sessioniterator.md) | Provides trading session information to the bars type. Must be built using the bars object. |
| [UpdateBar()](updatebar.md) | Updates a data point in our Bars Type. |
