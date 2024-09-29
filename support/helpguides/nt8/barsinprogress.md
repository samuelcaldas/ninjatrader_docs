


NinjaScript \> Language Reference \> Common \> AddDataSeries() \> BarsInProgress






















BarsInProgress







| \<\< [Click to Display Table of Contents](barsinprogress.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [AddDataSeries()](adddataseries.md) \> BarsInProgress | [Previous page](barsarray.md) [Return to chapter overview](adddataseries.md) [Next page](barsperiods.md) |
| --- | --- |











## Definition


An index value of the current Bars object that has called the [OnBarUpdate()](onbarupdate.md) method. In a multi\-bars script, the OnBarUpdate() method is called for each Bars object of a script. This flexibility allows you to separate trading logic from different bar events. 


 




| Notes:   1\.In a single Bars script this property will always return an index value of 0 representing the primary Bars and instrument the script is running on. 2\.See additional information on running [multi\-bars scripts](multi-time_frame__instruments.md). |
| --- |



 


 


## Property Value


An int value represents the [Bars](bars.md) object that is calling the OnBarUpdate() method.


 


## Syntax


BarsInProgress


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          // Add a 5 minute Bars object: BarsInProgress index \= 1           AddDataSeries(BarsPeriodType.Minute, 5);      } }    protected override void OnBarUpdate()  {       // Check which Bars object is calling the OnBarUpdate() method       if (BarsInProgress \=\= 0)       {           // A value of zero represents the primary Bars which is the ES 09\-14           // 1 minute chart.           // Do something within the context of the 1 minute Bars here       }       else if (BarsInProgress \=\= 1)       {           // A value of 1 represents the secondary 5 minute bars added in OnStateChange() State.Configure           // Do something within the context of the 5 minute Bars       }  } |









