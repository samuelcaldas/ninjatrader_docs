﻿
NinjaScript > Language Reference > Common > OnMarketData() > MarketDataEventArgs

MarketDataEventArgs

| << [Click to Display Table of Contents](marketdataeventargs.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnMarketData()](onmarketdata-1.md) > MarketDataEventArgs | [Previous page](onmarketdata-1.md) [Return to chapter overview](onmarketdata-1.md) [Next page](onmarketdepth-1.md) |
| --- | --- |
## Definition
Represents a change in level one market data and is passed as a parameter in the [OnMarketData()](onmarketdata-1.md) method.   

 
## Methods and Parameters

| Ask | A double value representing the ask price |
| --- | --- |
| Bid | A double value representing the bid price |
| Instrument | A Instrument object representing the instrument of the market data |
| IsReset | A bool value representing if a UI reset is needed after a manual disconnect.   Note: This is only relevant for columns. Whenever this property is true, the UI needs to be reset. |
| MarketDataType | Possible values are: MarketDataType.Ask MarketDataType.Bid MarketDataType.DailyHigh MarketDataType.DailyLow MarketDataType.DailyVolume MarketDataType.Last MarketDataType.LastClose (prior session close) MarketDataType.Opening MarketDataType.OpenInterest (supported by IQFeed, Kinetick) MarketDataType.Settlement |
| Price | A double value representing the price |
| Time | A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure representing the time |
| ToString() | A string representation of the MarketDataEventArgs object |
| Volume | A long value representing volume |

| Critical: If used with [TickReplay](tick_replay-1.md), please keep in mind Tick Replay ONLY replays the Last market data event, and only stores the best inside bid/ask price at the time of the last trade event.  You can think of this as the equivalent of the bid/ask price at the time a trade was reported. Please also see [Developing for Tick Replay](developing_for__tick_replay-1.md). |
| --- |

| Tips - Not all connectivity providers support all MarketDataTypes.- For an example of how to use IsReset please see \\MarketAnalyzerColumns\\AskPrice.cs |
| --- |

## Examples

| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {      // Print some data to the Output window      if (marketDataUpdate.MarketDataType == MarketDataType.Last)          Print("Last = " + marketDataUpdate.Price + " " + marketDataUpdate.Volume);      else if (marketDataUpdate.MarketDataType == MarketDataType.Ask)          Print("Ask = " + marketDataUpdate.Price + " " + marketDataUpdate.Volume);      else if (marketDataUpdate.MarketDataType == MarketDataType.Bid)          Print("Bid = " + marketDataUpdate.Price + " " + marketDataUpdate.Volume); } |
