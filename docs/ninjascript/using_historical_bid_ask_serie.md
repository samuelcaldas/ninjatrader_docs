# Using Historical Bid/Ask Series

## Historical Bid/Ask Series Overview

NinjaTrader has the ability to use historical bid and ask price series in your NinjaScript instead of only being able to use a last price series. The following outlines the intricacies of this capability:

> **Notes:**
- You can have multiple bid/ask/last series in your NinjaScript indicator/strategy. Please use the [AddDataSeries()](../language_reference/adddataseries.md) method to add these series to your script.
- The historical bid/ask series holds all bid/ask events sent out by the exchange. This would not be equivalent to the bid/ask at a specific time a trade went off.
- When processing your NinjaScript, the historical bid/ask series would have the historical portion triggered in the [OnBarUpdate()](../language_reference/onbarupdate.md) method only. [OnMarketData()](../language_reference/onmarketdata.md) method events for the historical bid/ask series would only be triggered in real-time.

> **Tips:**
- For using OnMarketData() events historically, please see the educational topic on [Developing for Tick Replay](developing_for__tick_replay.md)
- Changing the price type used for the primary Bars object to which a script is applied can be done in the [Data Series](../operations/working_with_price_data.md) window from any open chart.

## Accessing Bid/Ask Series

When calling AddDataSeries() to add an additional [Bars](../language_reference/bars.md) object to your script, a constructor overload will be available which takes a MarketDataType enumeration as an argument. This will allow you to specify the price series which will be used in that particular object. If you were to pass in MarketDataType.Ask or MarketDataType.Bid, as in the example below, that particular data series will use that price type for all of its [PriceSeries](../language_reference/priceseries.md) collections, such as [Close](../language_reference/close.md), [Open](../language_reference/open.md), [High](../language_reference/high.md), and [Low](../language_reference/low.md).

> **Warning:** A Tick Replay indicator or strategy CANNOT use a MarketDataType.Ask or MarketDataType.Bid series.  Please see [Developing for Tick Replay](developing_for__tick_replay.md) for more information.

## Example

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        // Add an AAPL data series using the Ask series
        AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Ask);
        //Add another AAPL data series using the Bid series, with other settings identical
        AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Bid);
    }
}
```