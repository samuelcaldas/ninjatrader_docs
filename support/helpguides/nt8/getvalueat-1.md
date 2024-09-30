
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> GetValueAt()
GetValueAt()
| \<\< [Click to Display Table of Contents](getvalueat.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> GetValueAt() | [Previous page](iseries_count-1.md) [Return to chapter overview](iseriest-1.md) [Next page](isvaliddatapoint-1.md) |
| --- | --- |
## Definition
Returns the underlying input value at a specified bar index value.
 
## Method Return Value
A double value representing the value at a specified bar.
 
## Syntax
GetValueAt(int barIndex)
ISeries\<T\>.GetValueAt(int barIndex)
 
| Tip:  If called directly from the instance of the NinjaScript object, the value which is returned corresponds to the input series the object is running. (e.g., Close, High, Low, SMA, etc.).  If you're attempting to obtain another indicator value, you will need to pull this from the calculated indicator Value or Plot:   SMA(20).GetValueAt(123); // bar value SMA(20).Values\[0].GetValueAt(123); // indicator value (Input as Indicator).Values\[0].GetValueAt(123) // passed in indicator value |
| --- |

## Parameters
| barIndex | An int representing an absolute bar index value |
| --- | --- |

## 
 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // make sure there are bars displayed on the chart and the chart control is ready before running    if (Bars \=\= null \|\| chartControl \=\= null)      return;            // loop through all the visable bars on the chart    for (int i \= ChartBars.FromIndex \- 1; i \>\= BarsRequiredToPlot; i\-\-)    {      double value \= GetValueAt(i);      Print(string.Format("The value at bar {0} is {1}", i, value));          } } |
