
NinjaScript > Language Reference > Common > AddDataSeries() > AddKagi()
AddKagi()
| << [Click to Display Table of Contents](addkagi.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [AddDataSeries()](adddataseries-1.md) > AddKagi() | [Previous page](addheikenashi-1.md) [Return to chapter overview](adddataseries-1.md) [Next page](addlinebreak-1.md) |
| --- | --- |
## Definition
Similar to the [AddDataSeries()](adddataseries-1.md) method for adding Bars objects, this method adds a Kagi Bars object for multi-series NinjaScript.
 
| Notes:   1.When running NinjaScript, you will be able to choose the first instrument and bar interval to run on. This first Bars object will carry a [BarsInProgress](barsinprogress-1.md) index of 0.2. In a multi-time frame and multi-instrument NinjaScript, supplementary Bars objects are added via this method in State.Configure state of the [OnStateChange()](onstatechange-1.md) method and given an incremented BarsInProgress index value. See additional information on running [multi-bars scripts](multi-time_frame__instruments-1.md).3.The [BarsInProgress](barsinprogress-1.md) property can be used to filter updates between different bars series4.If using [OnMarketData()](onmarketdata-1.md), a subscription will be created on all bars series added in your indicator or strategy strategy (even if the instrument is the same).  The market data subscription behavior occurs both in real-time and during [TickReplay](developing_for__tick_replay-1.md) historical5.For adding regular Bars types please use [AddDataSeries()](adddataseries-1.md)6.A Tick Replay indicator or strategy CANNOT use a MarketDataType.Ask or MarketDataType.Bid series.  Please see [Developing for Tick Replay](developing_for__tick_replay-1.md) for more information. |
| --- |

## Syntax
AddKagi(string instrumentName, Data.BarsPeriodType baseBarsPeriodType, int baseBarsPeriodTypeValue, int reversal, Data.ReversalType reversalType, Data.MarketDataType marketDataType)  

AddKagi(string instrumentName, Data.BarsPeriodType baseBarsPeriodType, int baseBarsPeriodTypeValue, int reversal, Data.ReversalType reversalType, Data.MarketDataType marketDataType, string tradingHoursName)  

AddKagi(string instrumentName, Data.BarsPeriodType baseBarsPeriodType, int baseBarsPeriodTypeValue, int reversal, Data.ReversalType reversalType, Data.MarketDataType marketDataType, string tradingHoursName, bool? isResetOnNewTradingDay)
 
| Warnings:  - This method should ONLY be called from the [OnStateChange()](onstatechange-1.md) method during State.Configure- Should your script be the host for other scripts that are creating indicators and series dependent resources in State.DataLoaded, please make sure that the host is doing the same AddKagi() calls as those hosted scripts would. For further reference, please also review the 'Adding additional Bars Objects to NinjaScript' section in [Multi-Time Frame & Instruments](multi-time_frame__instruments-1.md)- Arguments supplied to AddKagi() should be hardcoded and NOT dependent on run-time variables which cannot be reliably obtained during [State.Configure](state-1.md) (e.g., [Instrument](instrument-1.md), [Bars](bars-1.md), or user input).  Attempting to add a data series dynamically is NOT guaranteed and therefore should be avoided.  Trying to load bars dynamically may result in an error similar to: Unable to load bars series. Your NinjaScript may be trying to use an additional data series dynamically in an unsupported manner. |
| --- |

## Parameters
| instrumentName | A string determining instrument name such as "MSFT" |
| --- | --- |
| baseBarsPeriodType | The underlying BarsType used for the Kagi bars period   Possible values are:   - BarsPeriodType.Day- BarsPeriodType.Minute- BarsPeriodType.Second- BarsPeriodType.Tick- BarsPeriodType.Volume |
| baseBarsPeriodTypeValue | An int determining the underlying period interval such as "3" for 3 minute bars |
| reversal | An int determining the required price movement in the reversal direction before a reversal is identified on the chart |
| reversalType | An enum determining the mode reversal period is based.   Possible values are:   - ReversalType.Percent- ReversalType.Tick |
| marketDataType | The MarketDataType used for the bars object (last, bid, ask)   Possible values are:   - MarketDataType.Ask- MarketDataType.Bid- MarketDataType.Last  Note: Please see the article [here](using_historical_bid_ask_serie-1.md) on using Bid/Ask series. |
| tradingHoursName | A string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | A nullable bool* determining if the Bars object should [Break at EOD](break_at_eod-1.md)   *Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |
## 
 
| Tip: You can optionally add the exchange name as a suffix to the symbol name. This is only advised if the instrument has multiple possible exchanges that it can trade on and it is configured within the Instruments window. For example: AddKagi("MSFT Arca", PeriodType.Minute, 1, 2, ReversalType.Tick, MarketDataType.Last) |
| --- |
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {        Name = "Examples Indicator";                }    else if (State == State.Configure)    {        // Add a 1 minute Kagi Bars object for the ES 03-18 contract - BarsInProgress index = 1         AddKagi("ES 03-18", BPeriodType.Minute, 1, 2, ReversalType.Tick, MarketDataType.Last);    } }    protected override void OnBarUpdate()  {       // Ignore the primary Bars object and only process the Kagi Bars object       if (BarsInProgress == 1)      {          // Do something;      } } |

