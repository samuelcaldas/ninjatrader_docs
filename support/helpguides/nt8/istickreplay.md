



IsTickReplay

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](istickreplay.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Bars](bars.htm) >  IsTickReplay | [Previous page](isresetonnewtradingday.htm) [Return to chapter overview](bars.htm) [Next page](percentcomplete.htm) |

Definition
----------

Indicates if the bar series is using the [Tick Replay](developing_for__tick_replay.htm) data series property.

Property Value
--------------

This property returns true if the bar series is using tick replay; otherwise, false.  This property is read-only.

Syntax 
Bars.IsTickReplay
-------------------------

|  |
| --- |
| Warning: A Tick Replay indicator or strategy CANNOT use a MarketDataType.Ask or MarketDataType.Bid series.  Please see [Developing for Tick Replay](developing_for__tick_replay.htm) for more information. |

Examples
--------

| ns |
| --- |
| private double askPrice;  protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)  {     if(Bars.IsTickReplay)     {       // if using tick replay, get the current ask price associated with the tick       askPrice = marketDataUpdate.Ask;     }     else // otherwise, get the real-time market data price during MarketDataType.Ask event       askPrice = marketDataUpdate.MarketDataType == MarketDataType.Ask ? marketDataUpdate.Price : double.MinValue;        // only print if a value is set     if(askPrice != double.MinValue)     {       Print("ask price: " + askPrice);     }  } |