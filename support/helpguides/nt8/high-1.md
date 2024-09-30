
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> High
High
| \<\< [Click to Display Table of Contents](high.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [PriceSeries\<double\>](priceseries-1.md) \> High | [Previous page](closes-1.md) [Return to chapter overview](priceseries-1.md) [Next page](highs-1.md) |
| --- | --- |
## Definition
A collection of historical bar high prices.
 
## Property Value
An ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.
 
## Syntax
High  

High\[int barsAgo]
## 
 
## 
## Examples
| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {      // Make sure we have at least 20 bars      if (CurrentBar \< 20)          return;        // Evaluates for higher highs      if (High\[0] \> High\[1] \&\& High\[1] \> High\[2])          Print("Two successive higher highs");        // Gets the current value of a 20 period SMA of high prices      double value \= SMA(High, 20)\[0];      Print("The value is " \+ value.ToString()); } |

