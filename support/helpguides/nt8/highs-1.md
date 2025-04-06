



Highs

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\highs.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [PriceSeries<double>](priceseries-1.htm) >  Highs | [Previous page](high-1.htm) [Return to chapter overview](priceseries-1.htm) [Next page](input-1.htm) |

Definition
----------

Holds an array of ISeries<double> objects holding historical bar high prices. A ISeries<double> object is added to this array when calling the [AddDataSeries()](adddataseries-1.htm) method. Its purpose is to provide access to the high prices of all Bars objects in a multi-instrument or multi-time frame script.

Property Value
--------------

An array of ISeries<double> objects.

Syntax 
Highs[int barSeriesIndex][int barsAgo]
----------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.Configure)       {           // Adds a 5-minute Bars object to the strategy and is automatically assigned           // a Bars object index of 1 since the primary data the strategy is run against           // set by the UI takes the index of 0.           AddDataSeries("AAPL", BarsPeriodType.Minute, 5);       }  }     protected override void OnBarUpdate()  {       // Compares the primary bar's high price to the 5-minute bar's high price       if (Highs[0][0] > Highs[1][0])           Print("The primary bar's high price is greater");  } |