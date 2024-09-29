


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> Series\<T\>






















Series\<T\>







| \<\< [Click to Display Table of Contents](seriest.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> Series\<T\> | [Previous page](iseriest-1.md) [Return to chapter overview](iseriest-1.md) [Next page](reset-1.md) |
| --- | --- |











## Definition


A Series\<T\> is a special generic type of data structure that can be constructed with any chosen data type and holds a series of values equal to the same number of elements as bars in a chart. If you have 200 bars loaded in your chart with a moving average plotted, the moving average itself holds a Series\<double\> object with 200 historical values of data, one for each bar. Series\<double\> objects can be used as input data for all [indicator methods](indicators-1.md). The Series\<T\> class implements the ISeries\<T\> interface.


## 




| Note:  By default NinjaTrader limits the number of values stored for Series\<T\> objects to 256 from the current bar being processed. This drastically improves memory performance by not holding onto old values that are generally not needed. Should you need more values than the last 256 please be sure to create the Series\<T\> object so that it stores all values instead through the use of the [MaximumBarsLookBack](maximumbarslookback-1.md) property. |
| --- |



## 


## Constructors




| Series\<T\>(ninjaScriptBase) | Creates a Series\<T\> object synchronized to the primary data series of the provided NinjaScript |
| --- | --- |
| Series\<T\>(ninjaScriptBase, maximumBarsLookBack) | Creates a Series\<T\> object synchronized to the primary data series of the provided NinjaScript. This constructor also allows controlling the Series\<T\>'s [MaximumBarsLookBack](maximumbarslookback-1.md) |
| Series\<T\>(bars) | Creates a Series\<T\> object synchronized to the provided [Bars](bars-1.md) object, for Multi Time Frame scripts, this could be given from [BarsArray](barsarray-1.md) |
| Series\<T\>(bars, maximumBarsLookBack) | Creates a Series\<T\> object synchronized to the provided [Bars](bars-1.md) object, for Multi Time Frame scripts, this could be given from [BarsArray](barsarray-1.md). While this constructor allows controlling the Series\<T\>'s [MaximumBarsLookBack](maximumbarslookback-1.md), it is forced to MaximumBarsLookBack.Infinite |



## 


## 


## Parameters




| ninjaScriptBase | The NinjaScript object used to create the Series |
| --- | --- |
| bars | The [Bars](bars-1.md) object used to create the Series |
| maximumBarsLookBack | A [MaximumBarsLookBack](maximumbarslookback-1.md) value used for memory performance |



## 


## Methods and Properties




| [GetValueAt()](getvalueat-1.md) | Returns the underlying input value at a specified bar index value. |
| --- | --- |
| [IsValidDataPoint()](isvaliddatapoint-1.md) | Determines if the specified input is set at a barsAgo value relative to the current bar. |
| [Reset()](reset-1.md) | Resets the internal marker which is used for [IsValidDataPoint()](isvaliddatapoint-1.md) back to false. |
| [Count](count-1.md) | The total number of bars or data points. |



 


## 


## Creating Series\<T\> Objects


When creating custom indicators, Series\<double\> objects are automatically created for you by calling the [AddPlot()](addplot-1.md) method and can be subsequently referenced by the [Value](value-1.md) and/or [Values](values-1.md) property. However, you may have a requirement to create a Series\<T\> object to store values that are part of an overall indicator value calculation. This can be done within a custom indicator or strategy. 


 




| Note:  Custom Series\<T\> objects will hold the number of values specified by the [MaximumBarsLookBack](maximumbarslookback-1.md) property when the custom series object is instantiated. |
| --- |



 


 


To create a Series\<T\> object:


 


1\.Determine the data type of the Series\<T\> object you wish to create. This could be double, bool, int, string or any other object type you want.

2\.Define a variable of type Series\<T\> that will hold a Series\<T\> object. This example will create "myDoubleSeries" as a Series\<double\>.

3\.In the [OnStateChange()](onstatechange-1.md) method, in the State.DataLoaded create a new Series\<T\> object and assign it to the "myDoubleSeries" variable

 




| ns |
| --- |
| private Series\<double\> myDoubleSeries; // Define a Series\<T\> variable. In this instance we want it                                        // as a double so we created a Series\<double\> variable.   private Series\<double\> mySecondaryDoubleSeries; // Define a Series\<T\> variable. In this instance we want it                                                // as a double so we created a Series\<double\> variable.   // Create a Series object and assign it to the variable protected override void OnStateChange()  {      if (State \=\= State.Configure)      {          // Add a secondary data series to sync our Secondary Series\<double\>          AddDataSeries(BarsPeriodType.Minute, 1);      }      else if (State \=\= State.DataLoaded)      {          // "this" refers to the NinjaScript object itself. This syncs the Series object to historical data bars          // MaximumBarsLookBack determines how many values the Series\<double\> will have access to          myDoubleSeries \= new Series\<double\>(this, MaximumBarsLookBack.Infinite);            // "BarsArray\[1]" refers to the first data series added to the script with AddDataSeries.          mySecondaryDoubleSeries \= new Series\<double\>(BarsArray\[1]);      } } |



 


 


## Setting Values


You can set the value for the current bar being evaluated by choosing a "barsAgo" value of "0" or, for historical bars, by choosing a "barsAgo" value that represents the number of bars ago that you want the value to be stored at.


 




| ns Setting Series\<T\> values |
| --- |
| protected override void OnBarUpdate() {      myDoubleSeries\[0] \= Close\[0]; } |



 


 




| Note:  The "barsAgo" value is only guaranteed to be in sync with the recent current bar during core data event methods, such as OnBarUpdate(), OnMarketUpdate(), and during strategy related order events such as OnOrderUpdate(), OnExecutionUpdate(), OnPositionUpdate().  For scenarios where you may need to set a value outside of a core data/order event, such as OnRender() or a custom event, you must first synchronize the "barsAgo" pointer via the [TriggerCustomEvent()](triggercustomevent-1.md) method. |
| --- |



 


## 


## Checking for Valid Values
It is possible that you may use a Series\<T\> object but decide not to set a value for a specific bar. However, you should not try to access a Series\<T\>value that has not been set. Internally, a dummy value does exists, but you want to check to see if it was a valid value that you set before trying to access it for use in your calculations.  Please see [IsValidDataPoint()](isvaliddatapoint-1.md) more information.


 




| Warning:  Calling IsValidDataPoint() will only work a [MaximumBarsLookBackInfinite](maximumbarslookback-1.md) series.  Attempting to check IsValidDataPoint() MaximumBarsLookBack256 series throw an error.  Please check the Log tab of the Control Center |
| --- |



 


## 


## Getting Values
You can access Series\<T\> object values using the syntax Series\<T\>\[int barsAgo] where barsAgo represents the data value n (number of bars ago).


## 




| ns Accessing Series object values |
| --- |
| protected override void OnBarUpdate() {    // Prints the current and last bar value    Print("The values are " \+ myDoubleSeries\[0] \+ " " \+ myDoubleSeries\[1]); } |



 


Alternatively, you can access a value at an absolute bar index using the [GetValueAt()](getvalueat-1.md) method.


 




| Note:  In most cases, you will access the historical price series using a core data event handler such as OnBarUpdate().  For more advance developers, you may find situations where you wish to access historical price series outside of the core data event methods, such as OnRender(), or your own custom event.  In these advanced scenarios, you may run into situations where the "barsAgo" pointer is not in sync with the current bar, and may result in errors when trying to obtain this information.  In those cases, please use the Bars.Get...() methods with the absolute bar index, e.g., [GetValueAt()](getvalueat-1.md). |
| --- |



 


 


## Methods that Accept ISeries\<T\> as Arguments
All [indicator methods](indicators-1.md) accept ISeries\<double\> objects as arguments. Carrying from the prior examples, let's print out the 10 period simple moving average of range.


## 




| ns Using a custom Series object as indicator input |
| --- |
| protected override void OnBarUpdate() {    // Calculate the range of the current bar and set the value      myDoubleSeries\[0] \= (High\[0] \- Low\[0]);        // Print the current 10 period SMA of range      Print("Value is " \+ SMA(myDoubleSeries, 10)\[0]);          } |









