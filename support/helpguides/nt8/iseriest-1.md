﻿
NinjaScript > Language Reference > Common > ISeries<T>
ISeries<T>
| << [Click to Display Table of Contents](iseriest.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > ISeries<T> | [Previous page](url-1.md) [Return to chapter overview](common-1.md) [Next page](seriest-1.md) |
| --- | --- |
## Definition
ISeries<T> is an interface that is implemented by all NinjaScript classes that manage historical data as an ISeries<double> (Open, High, Low, Close, etc), used for indicator input, and other object data.  Please see the help guide article on [Working with Price Series](working_with_price_series-1.md) for a basic overview on how to access this information.
 
## Types of ISeries
| [Series<T>](seriest-1.md) | Represents a generic custom data structure for custom development |
| --- | --- |
| [PriceSeries](priceseries-1.md) | Historical price data structured as an ISeries<double> interface (Close[0], High[0], Low[0], etc) |
| [TimeSeries](timeseries-1.md) | Historical time stamps structured as an ISeries<DateTime> interface (Time[0]) |
| [VolumeSeries](volumeseries-1.md) | Historical volume data structured as an ISeries<double> interface (Volume[0]) |

## Methods and Properties
| [GetValueAt()](getvalueat-1.md) | Returns the underlying input value at a specified bar index value. |
| --- | --- |
| [IsValidDataPoint()](isvaliddatapoint-1.md) | Indicates if the specified input is set at a barsAgo value relative to the current bar. |
| [IsValidDataPointAt()](isvaliddatapointat-1.md) | Indicates if the specified input is set at a specified bar index value. |
| [Count](iseries_count-1.md) | Return the number total number of values in the ISeries array |

 
| Tips: (see examples below)  1.By specifying a parameter of type ISeries<double>, you can then pass in an array of closing prices, an indicator, or a user defined data series.2.When working with ISeries<double> objects in your code you may come across situations where you are not sure if the value being accessed is a valid value or just a "placeholder" value. To check if you are using valid values for your logic calculations that have been explicitly set, please use .IsValidDataPoint(int barsAgo) to check. |
| --- |

 
## 
## Examples
| ns Using ISeries as a method parameter |
| --- |
| //create custom a method named DoubleTheValue that accepts any object that implements  // the ISeries<double> interface as a parameter private double DoubleTheValue(ISeries<double> priceData) {      return priceData[0] * 2; }   protected override void OnBarUpdate() {    // This custom method is then used twice,     //the first time passing in an array of closing prices       Print(DoubleTheValue(Close));    //and the second time passing in a 20 period simple moving average.      Print(DoubleTheValue(SMA(20))); } |

 
## 
| ns Checking ISeries value before accessing |
| --- |
| protected override void OnBarUpdate() {      // Only set our plot if the input is a valid value      if (Input.IsValidDataPoint(0))          Plot0[0] = Input[0]; } |
