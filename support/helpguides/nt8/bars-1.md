
NinjaScript \> Language Reference \> Common \> Bars
Bars
| \<\< [Click to Display Table of Contents](bars.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> Bars | [Previous page](xmlignoreattribute-1.md) [Return to chapter overview](common-1.md) [Next page](barssincenewtradingday-1.md) |
| --- | --- |
## Definition
Represents the data returned from the historical data repository. The Bars object contain several methods and properties for working with bar data.
## 
| Warning: The Bars object and its member should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |

## Additional Access Information
Members within the Bars class can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be a Bar object which holds the method or property. Should you wish to access these members elsewhere, check for null reference first. e.g. if (Bars !\= null)
 
## Methods and Properties
| [BarsSinceNewTradingDay](barssincenewtradingday-1.md) | Number of bars that have elapsed since the start of the trading day |
| --- | --- |
| [GetAsk()](getask-1.md) | Returns the Ask price |
| [GetBar()](getbar-1.md) | Returns the bar index based on time |
| [GetBid()](getbid-1.md) | Returns the Bid price |
| [GetClose()](getclose-1.md) | Returns the closing price |
| [GetDayBar()](getdaybar-1.md) | Returns a Bar object that represents a trading day whose properties for open, high, low, close, time and volume can be accessed. |
| [GetHigh()](gethigh-1.md) | Returns the High price |
| [GetLow()](getlow-1.md) | Returns the Low price |
| [GetOpen()](getopen-1.md) | Returns the opening price |
| [GetTime()](gettime-1.md) | Returns the time |
| [GetVolume()](getvolume-1.md) | Returns the volume |
| [IsFirstBarOfSession](isfirstbarofsession-1.md) | Returns true if the bar is the first bar of a session |
| [IsFirstBarOfSessionByIndex()](isfirstbarofsessionbyindex-1.md) | Returns true if the bar is the first bar of a session |
| [IsLastBarOfSession](islastbarofsession-1.md) | Returns true if the bar is the last bar of a session |
| [IsResetOnNewTradingDay](isresetonnewtradingday-1.md) | Returns true if the chart bars should reset on a new trading day |
| [IsTickReplay](istickreplay-1.md) | Returns true if the bars are using tick replay |
| [PercentComplete](percentcomplete-1.md) | Value indicating the completion percent of a bar |
| [TickCount](tickcount-1.md) | Total number of ticks of the current bar |
| [ToChartString()](tochartstring-1.md) | Returns the bars series as a string formatted as the series would be displayed in the user interface |

