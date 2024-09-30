
NinjaScript \> Language Reference \> Market Analyzer Column \> CurrentValue
CurrentValue
| \<\< [Click to Display Table of Contents](currentvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Market Analyzer Column](market_analyzer_column.md) \> CurrentValue | [Previous page](currenttext.md) [Return to chapter overview](market_analyzer_column.md) [Next page](datatype.md) |
| --- | --- |
## Definition
The value to be displayed in the Market Analyzer Column
 
## Property Value
A double representing the value to be displayed in the column
 
## Syntax
CurrentValue
## 
## Example
| ns |
| --- |
| protected override void OnMarketData(Data.MarketDataEventArgs marketDataUpdate) {      CurrentValue \= marketDataUpdate.Price; } |

