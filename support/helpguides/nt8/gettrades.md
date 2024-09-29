


NinjaScript \> Language Reference \> Strategy \> TradeCollection \> GetTrades()






















GetTrades()







| \<\< [Click to Display Table of Contents](gettrades.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [TradeCollection](tradecollection.md) \> GetTrades() | [Previous page](eventrades.md) [Return to chapter overview](tradecollection.md) [Next page](losingtrades.md) |
| --- | --- |











## Definition


Returns a TradeCollection object representing all trades that make up the specified position. 


 


## Method Return Value


A TradeCollection object.


 


## Syntax
\<TradeCollection\>.GetTrades(string instrument, string entrySignalName, int instance)


 


## Parameters




| instrument | An instrument name such as "MSFT" |
| --- | --- |
| entrySignalName | The name of your entry signal |
| instance | The occurrence to check for (1 is the most recent, 2 is the 2nd most recent position, etc...) |



 


   

Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      TradeCollection myTrades \= SystemPerformance.AllTrades.GetTrades("MSFT", "myEntrySignal", 1);      Print("The last position was comprised of " \+ myTrades.Count \+ " trades."); } |



 








