
NinjaScript > Language Reference > SuperDOM Column > OnMarketData()
OnMarketData()

| << [Click to Display Table of Contents](superdomcolumn_onmarketdata.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [SuperDOM Column](superdom_column.md) > OnMarketData() | [Previous page](superdomcolumn_marketdepth.md) [Return to chapter overview](superdom_column.md) [Next page](superdomcolumn_onorderupdate.md) |
| --- | --- |

## Definition
Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The OnMarketData() method updates can include but is not limited to the bid, ask, last price and volume.
 
## Method Return Value
This method does not return a value.
 
## Syntax
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)  

{  

   

}
 
## Parameters
| marketDataUpdate | A [MarketDataEventArgs](marketdataeventargs.md) representing the change in market data |
| --- | --- |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    if (marketDataUpdate.MarketDataType == Data.MarketDataType.Last)    {      // Do something    } } |

