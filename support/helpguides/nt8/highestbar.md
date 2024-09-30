
NinjaScript > Language Reference > Common > Analytical > HighestBar()
HighestBar()
| << [Click to Display Table of Contents](highestbar.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Analytical](market_data.md) > HighestBar() | [Previous page](getmedian.md) [Return to chapter overview](market_data.md) [Next page](falling.md) |
| --- | --- |
Definition
Returns the number of bars ago the highest price value occurred within the specified look-back period. 
## 
## Method Return Value
An int value representing a value of bars ago.
 
## Syntax
HighestBar(ISeries<double> series, int period)
 
## Parameters
| period | The number of bars to include in the calculation |
| --- | --- |
| series | Any Series<double> type object such as an indicator, Close, High, Low, etc... |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {       // store the highest bars ago value    int highestBarsAgo = HighestBar(High, Bars.BarsSinceNewTradingDay);        //evaluate high price from highest bars ago value    double highestPrice = High[highestBarsAgo];                 //Printed result:  Highest price of the session: 2095.5 - occurred 24 bars ago    Print(string.Format("Highest price of the session: {0} - occurred {1} bars ago", highestPrice, highestBarsAgo));             } |

