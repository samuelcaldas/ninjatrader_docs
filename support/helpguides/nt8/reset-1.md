
NinjaScript > Language Reference > Common > ISeries<T> > Series<T> > Reset()
Reset()
| << [Click to Display Table of Contents](reset.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [ISeries<T>](iseriest-1.md) > [Series<T>](seriest-1.md) > Reset() | [Previous page](seriest-1.md) [Return to chapter overview](seriest-1.md) [Next page](priceseries-1.md) |
| --- | --- |
## Definition
Resets the internal marker which is used for [IsValidDataPoint()](isvaliddatapoint-1.md) back to false.  Calling the Reset() method is unique and can be very powerful for custom indicator development. [Series<T>](seriest-1.md) objects will always contain a value which is assigned, however calling Reset() simply means you effectively ignore the value of the current bar for plotting purposes. For calculation purposes you will want to use [IsValidDataPoint()](isvaliddatapoint-1.md) to ensure you are not calculating off of any reset values assigned by the Reset() method.
 
| Series Type | Value after Reset() |
| --- | --- |
| Series<bool> | false |
| Series<double> | 0.00 |
| Series<DateTime> | DateTime.MinValue |
| Series<float> | 0 |
| Series<int> | 0 |
| Series<long> | 0 |
| Series<string> | null |

 
## Method Return Value
This method does not return a value
 
## Syntax
Reset()  

Reset(int barsAgo)
 
## Parameters
| barsAgo | An int representing from the current bar the number of historical bars the method will check.  If no barsAgo value is supplied, the current bar value will be reset instead (barsAgo 0) |
| --- | --- |

## 
 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    // set MyPlot to Low of current bar minus 1 tick    MyPlot[0] = Low[0] - (1 * TickSize);                  //reset MyPlot every 10 bars    if(CurrentBar % 10 == 0)      MyPlot.Reset();          // only calculate MyPlot value if it has not be reset    if(MyPlot.IsValidDataPoint(0))      Print(CurrentBar + " Value is: " + MyPlot[0]);          } |
