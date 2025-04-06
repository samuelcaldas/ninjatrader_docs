



OnMarketData()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](superdomcolumn_onmarketdata.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [SuperDOM Column](superdom_column.htm) >  OnMarketData() | [Previous page](superdomcolumn_marketdepth.htm) [Return to chapter overview](superdom_column.htm) [Next page](superdomcolumn_onorderupdate.htm) |

Definition
----------

Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The OnMarketData() method updates can include but is not limited to the bid, ask, last price and volume.

Method Return Value
-------------------

This method does not return a value.

Syntax
------

protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)  
{  
   
}

Parameters
----------

|  |  |
| --- | --- |
| marketDataUpdate | A [MarketDataEventArgs](marketdataeventargs.htm) representing the change in market data |

Examples
--------

| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)  {     if (marketDataUpdate.MarketDataType == Data.MarketDataType.Last)     {       // Do something     }  } |