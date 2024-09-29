


NinjaScript \> Language Reference \> Common \> AddDataSeries() \> CurrentBars






















CurrentBars







| \<\< [Click to Display Table of Contents](currentbars.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [AddDataSeries()](adddataseries-1.md) \> CurrentBars | [Previous page](barsperiods-1.md) [Return to chapter overview](adddataseries-1.md) [Next page](alert__debugging_and_sharing-1.md) |
| --- | --- |











## Definition


Holds an array of int values representing the number of the current bar in a Bars object. An int value is added to this array when calling the [AddDataSeries()](adddataseries-1.md) method. Its purpose is to provide access to the [CurrentBar](currentbar-1.md) of all Bars objects in a multi\-instrument or multi\-time frame script. 


 




| Note:    In [multi series](multi-time_frame__instruments-1.md) processing, the CurrentBars starting value will be \-1 until all series have processed the first bar. |
| --- |



 


## 


## Property Value


An array of int values.


 




| Warning: This property should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |



 


 


## Syntax


CurrentBars\[int barSeriesIndex]


 


## Examples




| ns Indicator ([BarsRequiredToPlot](barsrequiredtoplot-1.md)) |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          // Adds a 5\-minute Bars object to the script. It will automatically be assigned          // a Bars object index of 1 since the primary data the indicator is run against          // set by the UI takes the index of 0\.          AddDataSeries("AAPL", BarsPeriodType.Minute, 5);      } }   protected override void OnBarUpdate() {      // Evaluates to make sure we have at least 20 (default value of BarsRequiredToPlot)      // or more bars in both Bars objects before continuing.      if (CurrentBars\[0] \< BarsRequiredToPlot \|\| CurrentBars\[1] \< BarsRequiredToPlot)          return;        // Indicator script logic calculation code... } |



 


## 




| ns Strategy ([BarsRequiredToTrade](barsrequiredtotrade-1.md)) |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          // Adds a 5\-minute Bars object to the script. It will automatically be assigned          // a Bars object index of 1 since the primary data the indicator is run against          // set by the UI takes the index of 0\.          AddDataSeries("AAPL", BarsPeriodType.Minute, 5);      } }   protected override void OnBarUpdate() {      // Evaluates to make sure we have at least 20 (default value of BarsRequiredToTrade)      // or more bars in both Bars objects before continuing.      if (CurrentBars\[0] \< BarsRequiredToTrade \|\| CurrentBars\[1] \< BarsRequiredToTrade)          return;        // Strategy script logic calculation code... } |









