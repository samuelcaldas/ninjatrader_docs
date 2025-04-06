



Valid Input Data for Indicator Methods

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\valid_input_data_for_indicator.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [System Indicator Methods](indicators-1.htm) >  Valid Input Data for Indicator Methods | [Previous page](indicators-1.htm) [Return to chapter overview](indicators-1.htm) [Next page](accumulation_distribution_adl-1.htm) |

System indicator methods require valid input data to function property. Indicator methods can accept the following forms of input data:

Default Input 
The default input (Inputs[[BarsInProgress](barsinprogress-1.htm)]) of the custom indicator, Market Analyzer row or strategy is used if input is not specified.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

| ns |
| --- |
| // Printing the current value of the 10 period SMA of closing prices  // using the default input.  double value = SMA(10)[0];   Print("The current SMA value is " + value.ToString()); |

 

Price Series
------------

Open, High, Low, Close and Volume can all be used as input for an indicator method.

| ns |
| --- |
| // Passing in the a price series of High prices and printing out the current value of the  // 14 period simple moving average  double value = SMA(High, 14)[0];  Print("The current SMA value is " + value.ToString()); |

Indicator 
Indicators can be used as input for other indicators.
----------------------------------------------------------------

| ns |
| --- |
| // Printing the current value of the 20 period simple moving average of a 14 period RSI  // using a data series of closing prices  double value = SMA(RSI(Close, 14, 3), 20)[0];  Print("The current SMA value is " + value.ToString()); |

Series<double> 
[Series<double>](seriest-1.htm) can be used as input for indicators.
------------------------------------------------------------------------------------

| ns |
| --- |
| // Instantiating a new Series<double> object and passing it in as input to calculate  // a simple moving average  Series<double> myDataSeries = new Series<double>(this);  double value = SMA(myDataSeries, 20)[0]; |

Bars Object 
A Bars object (which holds a series that contains OHLC data) can be used as input for indicators.
--------------------------------------------------------------------------------------------------------------

| ns |
| --- |
| // Passing in the second Bars object held in a multi-instrument and timeframe strategy  // The default value used for the SMA calculation is the close price  double value = SMA(BarsArray[1], 20)[0];  Print("The current SMA value is " + value.ToString());; |

|  |  |  |
| --- | --- | --- |
| Tip: The input series of an indicator cannot be the hosting indicator itself, as this will cause recursive loops.    | ns | | --- | | // Using the hosting indicator in this way will cause errors with recursive loops  double value = SMA(this, 20)[0]; | |