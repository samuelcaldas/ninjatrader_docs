


NinjaScript \> Language Reference \> Market Analyzer Column \> FormatDecimals






















FormatDecimals







| \<\< [Click to Display Table of Contents](formatdecimals.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Market Analyzer Column](market_analyzer_column.md) \> FormatDecimals | [Previous page](datatype.md) [Return to chapter overview](market_analyzer_column.md) [Next page](iseditable.md) |
| --- | --- |











## Definition


Rounds the value contained in [CurrentValue](currentvalue.md) to a specified number of decimal places before displaying it in the Market Analyzer column.


 


## Property Value


An int representing a number of decimal places to which to round CurrentValue


 


## Syntax


FormatDecimals


 


## Example




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Round CurrentValue to one decimal place        FormatDecimals \= 1;    } }   protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    CurrentValue \= marketDataUpdate.Price; } |









