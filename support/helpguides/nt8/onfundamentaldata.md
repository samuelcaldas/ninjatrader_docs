



OnFundamentalData()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](onfundamentaldata.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) >  OnFundamentalData() | [Previous page](connectionstatuseventargs.htm) [Return to chapter overview](common.htm) [Next page](fundamentaldataeventargs.htm) |

Definition
----------

An event driven method which is called for every change in fundamental data for the underlying instrument.

|  |
| --- |
| Note:  This method is NOT called on historical data (backtest) |

Method Return Value
-------------------

This method does not return a value.

Syntax 
You must override the method in your strategy or indicator with the following syntax.
---------------------------------------------------------------------------------------------

protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)   
{  
   
}

 

|  |
| --- |
| Tip:  The NinjaScript code wizards can automatically generate the method syntax for you when creating a new script. |

 

 

Parameters
----------

|  |  |
| --- | --- |
| fundamentalDataUpdate | [FundamentalDataEventArgs](fundamentaldataeventargs.htm) representing the recent change in fundamental data |

Examples
--------

| ns | |
| --- | --- |
|  | protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)  {       // Print some data to the Output window       if (fundamentalDataUpdate.FundamentalDataType == FundamentalDataType.AverageDailyVolume)           Print("The current ADV is " + fundamentalDataUpdate.LongValue);  } |

|  |
| --- |
| Tips  1.With [multi-time frame and instrument strategies](multi-time_frame__instruments.htm), OnFundamentalData() will be called for all unique instruments in your strategy. Use the [BarsInProgress](barsinprogress.htm) to filter the OnFundamentalData() method for a specific instrument.  2.Do not leave an unused OnFundamentalData() method declared in your NinjaScript object. This will unnecessarily attach a data stream to your script which uses unnecessary CPU cycles. |