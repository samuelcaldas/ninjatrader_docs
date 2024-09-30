
NinjaScript \> Language Reference \> Common \> Bars \> IsTickReplay

IsTickReplay

| \<\< [Click to Display Table of Contents](istickreplay.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> IsTickReplay | [Previous page](isresetonnewtradingday-1.md) [Return to chapter overview](bars-1.md) [Next page](percentcomplete-1.md) |
| --- | --- |
## Definition
Indicates if the bar series is using the [Tick Replay](developing_for__tick_replay-1.md) data series property.
 
## Property Value
This property returns true if the bar series is using tick replay; otherwise, false.  This property is read\-only.
 
## Syntax
Bars.IsTickReplay
## 

| Warning: A Tick Replay indicator or strategy CANNOT use a MarketDataType.Ask or MarketDataType.Bid series.  Please see [Developing for Tick Replay](developing_for__tick_replay-1.md) for more information. |
| --- |

## Examples

| ns |
| --- |
| private double askPrice; protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    if(Bars.IsTickReplay)    {      // if using tick replay, get the current ask price associated with the tick      askPrice \= marketDataUpdate.Ask;    }    else // otherwise, get the real\-time market data price during MarketDataType.Ask event      askPrice \= marketDataUpdate.MarketDataType \=\= MarketDataType.Ask ? marketDataUpdate.Price : double.MinValue;      // only print if a value is set    if(askPrice !\= double.MinValue)    {      Print("ask price: " \+ askPrice);    } } |
