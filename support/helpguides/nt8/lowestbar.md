


NinjaScript \> Language Reference \> Common \> Analytical \> LowestBar()






















LowestBar()







| \<\< [Click to Display Table of Contents](lowestbar.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> LowestBar() | [Previous page](least_recent_occurence_lro.md) [Return to chapter overview](market_data.md) [Next page](most_recent_occurence_mro.md) |
| --- | --- |











## Definition


Returns the number of bars ago the lowest price value occurred within the specified look\-back period. 


## 


## Method Return Value


An int value representing a value of bars ago.


 


## Syntax
LowestBar(ISeries\<double\> series, int period)


 


## Parameters




| period | The number of bars to check for the test condition |
| --- | --- |
| series | Any Series\<double\> type object such as an indicator, Close, High, Low, etc... |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {       // store the lowest bar ago value    int lowestBar \= LowestBar(Low, Bars.BarsSinceNewTradingDay);        //evaluate low price from lowest bar ago value    double lowestPrice \= Low\[lowestBar];                 //Printed result:  Lowest price of the session: 2087\.25 \- occurred 362 bars ago    Print(string.Format("Lowest price of the session: {0} \- occurred {1} bars ago", lowestPrice, lowestBar));             } |









