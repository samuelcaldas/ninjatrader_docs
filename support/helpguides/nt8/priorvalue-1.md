
NinjaScript \> Language Reference \> Market Analyzer Column \> PriorValue

PriorValue

| \<\< [Click to Display Table of Contents](priorvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Market Analyzer Column](market_analyzer_column-1.md) \> PriorValue | [Previous page](onrender2-1.md) [Return to chapter overview](market_analyzer_column-1.md) [Next page](optimization_fitness-1.md) |
| --- | --- |
## Definition
Contains the last value of [CurrentValue](currentvalue-1.md). PriorValue is assigned the value of CurrentValue immediately before CurrentValue is updated.
 
## Property Value
A double containing the last value contained in CurrentValue before its most recent update
 
## Syntax
PriorValue
 
## 
## Example

| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    if (marketDataUpdate.MarketDataType \=\= MarketDataType.Last)    {        CurrentValue \= marketDataUpdate.Price;          // Trigger an alert if the current Last price update is greater than the previous one        if(CurrentValue \> PriorValue)            Alert("MA Alert", Priority.High, "Check Market Analyzer", "", 30, Brushes.Black, Brushes.White);    } } |
