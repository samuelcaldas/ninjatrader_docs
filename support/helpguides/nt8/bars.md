
NinjaScript > Language Reference > Common > Bars
Bars
| << [Click to Display Table of Contents](bars.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Bars | [Previous page](xmlignoreattribute.md) [Return to chapter overview](common.md) [Next page](barssincenewtradingday.md) |
| --- | --- |
## Definition
Represents the data returned from the historical data repository. The Bars object contain several methods and properties for working with bar data.
## 
| Warning: The Bars object and its member should NOT be accessed within the [OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded |
| --- |

## Additional Access Information
Members within the Bars class can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be a Bar object which holds the method or property. Should you wish to access these members elsewhere, check for null reference first. e.g. if (Bars != null)
 
## Methods and Properties
| [BarsSinceNewTradingDay](barssincenewtradingday.md) | Number of bars that have elapsed since the start of the trading day |
| --- | --- |
| [GetAsk()](getask.md) | Returns the Ask price |
| [GetBar()](getbar.md) | Returns the bar index based on time |
| [GetBid()](getbid.md) | Returns the Bid price |
| [GetClose()](getclose.md) | Returns the closing price |
| [GetDayBar()](getdaybar.md) | Returns a Bar object that represents a trading day whose properties for open, high, low, close, time and volume can be accessed. |
| [GetHigh()](gethigh.md) | Returns the High price |
| [GetLow()](getlow.md) | Returns the Low price |
| [GetOpen()](getopen.md) | Returns the opening price |
| [GetTime()](gettime.md) | Returns the time |
| [GetVolume()](getvolume.md) | Returns the volume |
| [IsFirstBarOfSession](isfirstbarofsession.md) | Returns true if the bar is the first bar of a session |
| [IsFirstBarOfSessionByIndex()](isfirstbarofsessionbyindex.md) | Returns true if the bar is the first bar of a session |
| [IsLastBarOfSession](islastbarofsession.md) | Returns true if the bar is the last bar of a session |
| [IsResetOnNewTradingDay](isresetonnewtradingday.md) | Returns true if the chart bars should reset on a new trading day |
| [IsTickReplay](istickreplay.md) | Returns true if the bars are using tick replay |
| [PercentComplete](percentcomplete.md) | Value indicating the completion percent of a bar |
| [TickCount](tickcount.md) | Total number of ticks of the current bar |
| [ToChartString()](tochartstring.md) | Returns the bars series as a string formatted as the series would be displayed in the user interface |

