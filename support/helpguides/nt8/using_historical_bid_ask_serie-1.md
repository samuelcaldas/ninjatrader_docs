
NinjaScript > Educational Resources > Using Historical Bid/Ask Series
Using Historical Bid/Ask Series

| << [Click to Display Table of Contents](using_historical_bid_ask_serie.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > Using Historical Bid/Ask Series | [Previous page](using_bitmapimage_objects_with_buttons-1.md) [Return to chapter overview](educational_resources-1.md) [Next page](using_images_and_geometry_with_custom_icons-1.md) |
| --- | --- |

## Historical Bid/Ask Series Overview
NinjaTrader has the ability to use historical bid and ask price series in your NinjaScript instead of only being able to use a last price series. The following outlines the intricacies of this capability:
 
| Notes:  - You can have multiple bid/ask/last series in your NinjaScript indicator/strategy. Please use the [AddDataSeries()](adddataseries-1.md) method to add these series to your script.- The historical bid/ask series holds all bid/ask events sent out by the exchange. This would not be equivalent to the bid/ask at a specific time a trade went off.- When processing your NinjaScript, the historical bid/ask series would have the historical portion triggered in the [OnBarUpdate()](onbarupdate-1.md) method only. [OnMarketData()](onmarketdata-1.md) method events for the historical bid/ask series would only be triggered in real-time. |
| --- |

 
| Tips:   - For using OnMarketData() events historically, please see the educational topic on [Developing for Tick Replay](developing_for__tick_replay-1.md)- Changing the price type used for the primary Bars object to which a script is applied can be done in the [Data Series](working_with_price_data-1.md) window from any open chart. |
| --- |

## 
## Accessing Bid/Ask Series
When calling AddDataSeries() to add an additional [Bars](bars-1.md) object to your script, a constructor overload will be available which takes a MarketDataType enumeration as an argument. This will allow you to specify the price series which will be used in that particular object. If you were to pass in MarketDataType.Ask or MarketDataType.Bid, as in the example below, that particular data series will use that price type for all of its [PriceSeries](priceseries-1.md) collections, such as [Close](close-1.md), [Open](open-1.md), [High](high-1.md), and [Low](low-1.md).
 
| Warning: A Tick Replay indicator or strategy CANNOT use a MarketDataType.Ask or MarketDataType.Bid series.  Please see [Developing for Tick Replay](developing_for__tick_replay-1.md) for more information. |
| --- |

## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.Configure)    {        // Add an AAPL data series using the Ask series        AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Ask);          //Add another AAPL data series using the Bid series, with other settings identical        AddDataSeries("AAPL", BarsPeriodType.Minute, 30, MarketDataType.Bid);    } } |

