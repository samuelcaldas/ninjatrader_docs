
NinjaScript \> Language Reference \> Market Analyzer Column \> CurrentText
CurrentText
| \<\< [Click to Display Table of Contents](currenttext.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Market Analyzer Column](market_analyzer_column-1.md) \> CurrentText | [Previous page](market_analyzer_column-1.md) [Return to chapter overview](market_analyzer_column-1.md) [Next page](currentvalue-1.md) |
| --- | --- |
## Definition
Sets text to be displayed in the Market Analyzer column.
## 
| Note: CurrentText will overrule any value set for [CurrentValue](currentvalue-1.md). If both CurrentValue and CurrentText have assigned values, the value of CurrentText will display in the column. |
| --- |
## 
## Property Value
A string representing text to display in the column
 
## Syntax
CurrentText
## 
## Example
| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    // Print "Ask" in the column if an Ask price update is received    if(marketDataUpdate.MarketDataType \=\= MarketDataType.Ask)        CurrentText \= "Ask"; } |

