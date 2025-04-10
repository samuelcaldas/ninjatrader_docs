



AddKagi()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addkagi.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [AddDataSeries()](adddataseries-1.md) >  AddKagi() | [Previous page](addheikenashi-1.md) [Return to chapter overview](adddataseries-1.md) [Next page](addlinebreak-1.md) |

Definition
----------

Similar to the [AddDataSeries()](adddataseries-1.md) method for adding Bars objects, this method adds a Kagi Bars object for multi-series NinjaScript.

 

|  |
| --- |
| Notes:  Developing for Tick Replay for more information. |

Syntax
------

AddKagi(marketDataType)  
AddKagi(tradingHoursName)  
AddKagi(isResetOnNewTradingDay)

 

|  |
| --- |
| Warnings:  Unable to load bars series. Your NinjaScript may be trying to use an additional data series dynamically in an unsupported manner. |

Parameters
----------

|  |  |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| baseBarsPeriodType | The underlying BarsType used for the Kagi bars period   Possible values are:    •BarsPeriodType.Volume |
| baseBarsPeriodTypeValue | int determining the underlying period interval such as "3" for 3 minute bars |
| reversal | int determining the required price movement in the reversal direction before a reversal is identified on the chart |
| reversalType | An enum determining the mode reversal period is based.   Possible values are:    •ReversalType.Tick |
| marketDataType | The MarketDataType used for the bars object (last, bid, ask)   Possible values are:      here on using Bid/Ask series. |
| tradingHoursName | string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | Break at EOD   \*Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |

|  |
| --- |
| MarketDataType.Last) |

Examples
--------

|  |
| --- |
| OnStateChange()  {  State.SetDefaults)  {                }  State.Configure)  {  // Add a 1 minute Kagi Bars object for the ES 03-18 contract - BarsInProgress index = 1   MarketDataType.Last);  }  }         {   // Ignore the primary Bars object and only process the Kagi Bars object   )  {  // Do something;  }  } |