



CurrentBars

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\currentbars.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [AddDataSeries()](adddataseries-1.htm) >  CurrentBars | [Previous page](barsperiods-1.htm) [Return to chapter overview](adddataseries-1.htm) [Next page](alert__debugging_and_sharing-1.htm) |

Definition
----------

Holds an array of int values representing the number of the current bar in a Bars object. An int value is added to this array when calling the [AddDataSeries()](adddataseries-1.htm) method. Its purpose is to provide access to the [CurrentBar](currentbar-1.htm) of all Bars objects in a multi-instrument or multi-time frame script.

 

|  |
| --- |
| Note:    In [multi series](multi-time_frame__instruments-1.htm) processing, the CurrentBars starting value will be -1 until all series have processed the first bar. |

Property Value
--------------

An array of int values.

|  |
| --- |
| Warning: This property should NOT be accessed within the [OnStateChange()](onstatechange-1.htm) method before the State has reached State.DataLoaded |

Syntax
------

CurrentBars[int barSeriesIndex]

Examples
--------

| ns Indicator ([BarsRequiredToPlot](barsrequiredtoplot-1.htm)) |
| --- |
| protected override void OnStateChange()  {       if (State == State.Configure)       {           // Adds a 5-minute Bars object to the script. It will automatically be assigned           // a Bars object index of 1 since the primary data the indicator is run against           // set by the UI takes the index of 0.           AddDataSeries("AAPL", BarsPeriodType.Minute, 5);       }  }     protected override void OnBarUpdate()  {       // Evaluates to make sure we have at least 20 (default value of BarsRequiredToPlot)       // or more bars in both Bars objects before continuing.       if (CurrentBars[0] < BarsRequiredToPlot || CurrentBars[1] < BarsRequiredToPlot)           return;          // Indicator script logic calculation code...  } |

| ns Strategy ([BarsRequiredToTrade](barsrequiredtotrade-1.htm)) |
| --- |
| protected override void OnStateChange()  {       if (State == State.Configure)       {           // Adds a 5-minute Bars object to the script. It will automatically be assigned           // a Bars object index of 1 since the primary data the indicator is run against           // set by the UI takes the index of 0.           AddDataSeries("AAPL", BarsPeriodType.Minute, 5);       }  }     protected override void OnBarUpdate()  {       // Evaluates to make sure we have at least 20 (default value of BarsRequiredToTrade)       // or more bars in both Bars objects before continuing.       if (CurrentBars[0] < BarsRequiredToTrade || CurrentBars[1] < BarsRequiredToTrade)           return;          // Strategy script logic calculation code...  } |