



AddHeikenAshi()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addheikenashi.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [AddDataSeries()](adddataseries-1.htm) >  AddHeikenAshi() | [Previous page](adddataseries-1.htm) [Return to chapter overview](adddataseries-1.htm) [Next page](addkagi-1.htm) |

Definition
----------

Similar to the [AddDataSeries()](adddataseries-1.htm) method for adding Bars objects, this method adds a Heiken Ashi Bars object for multi-series NinjaScript.

|  |
| --- |
| Notes:  Developing for Tick Replay for more information. |

Syntax
------

AddHeikenAshi(marketDataType)  
AddHeikenAshi(tradingHoursName)  
AddHeikenAshi(isResetOnNewTradingDay)

 

|  |
| --- |
| Warnings:    Unable to load bars series. Your NinjaScript may be trying to use an additional data series dynamically in an unsupported manner. |

Parameters
----------

|  |  |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| baseBarsPeriodType | The underlying BarsType used for the Heiken Ashi bars period.   Possible values are:    •BarsPeriodType.Year |
| baseBarsPeriodTypeValue | int determining the underlying period interval such as "3" for 3 minute bars |
| marketDataType | The MarketDataType used for the bars object (last, bid, ask)   Possible values are:      here on using Bid/Ask series. |
| tradingHoursName | string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | Break at EOD   \*Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |

|  |
| --- |
| MarketDataType.Last); |

Examples
--------

|  |
| --- |
| OnStateChange()  {  State.SetDefaults)  {                }  State.Configure)  {  // Add a 1 minute Heiken Ashi Bars object for the ES 03-18 contract - BarsInProgress index = 1   MarketDataType.Last);  }  }         {   // Ignore the primary Bars object and only process the Heiken Ashi object   )  {  // Do something;  }  } |