


NinjaScript \> Language Reference \> Common \> OnBarUpdate()






















OnBarUpdate()







| \<\< [Click to Display Table of Contents](onbarupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> OnBarUpdate() | [Previous page](maximumbarslookback-1.md) [Return to chapter overview](common-1.md) [Next page](barsperiod-1.md) |
| --- | --- |











## Definition


An event driven method which is called whenever a bar is updated. The frequency in which OnBarUpdate is called will be determined by the "[Calculate](calculate-1.md)" property. OnBarUpdate() is the method where all of your script's core bar based calculation logic should be contained.


 




| Notes:   •For [multi\-timeframe and instrument scripts](multi-time_frame__instruments-1.md), the OnBarUpdate method is called for each Bars object of a strategy.  You MUST filter for the exact bar update events using the "[BarsInProgress](barsinprogress-1.md)" property you want your system logic to execute against. •Hosted indicators will need to be accessed by the hosting script to ensure OnBarUpdate functionality. This can be done by: 1\) Calling [Update](update-1.md) on the hosted indicator within the host script, 2\) Including a plot in the hosted indicator and accessing the plot in the host script, 3\) Including a plot in the hosted indicator and adding the indicator to the chart with [AddChartIndicator](addchartindicator-1.md) (strategies only) |
| --- |



 


 


## Related Methods and Properties




| [BarsPeriod](barsperiod-1.md) | The primary Bars object time frame (period type and interval). |
| --- | --- |
| [Calculate](calculate-1.md) | Determines how often [OnBarUpdate()](onbarupdate-1.md) is called for each bar. |
| [Count](count-1.md) | The total number of bars or data points. |
| [CurrentBar](currentbar-1.md) | A number representing the current bar in a Bars object that the OnBarUpdate() method in an indicator or strategy is currently processing. |
| [IsDataSeriesRequired](isdataseriesrequired-1.md) | Determines if a Data Series is required for calculating this NinjaScript object. |
| [IsFirstTickOfBar](isfirsttickofbar-1.md) | Indicates if the incoming tick is the first tick of a new bar. |
| [IsResetOnNewTradingDays](isresetonnewtradingdays-1.md) | Determines if the specified bar series is using Break at EOD. |
| [IsTickReplays](istickreplays-1.md) | Indicates the specified bar series is using Tick Replay. |
| [Update()](update-1.md) | Forces the OnBarUpdate() method to be called so that indicator values are updated to the current bar. |



 


 


## Method Return Value


This method does not return a value.


 


 


## Syntax
You must override this method with the following syntax:


## 


protected override void OnBarUpdate()  

{


   

}


 




| Tip:  The NinjaScript code wizards automatically generates the method syntax for you. |
| --- |



## 


## 


## Parameters


## This method does not take any parameters


## 


## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      if (CurrentBar \< 1)          return;        // Compares the primary bar's low price to the 5\-minute bar's low price      if (Low\[0] \> Lows\[1])          Print("The current bar's low price is greater"); } |









