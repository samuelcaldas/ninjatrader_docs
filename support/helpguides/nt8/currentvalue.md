



CurrentValue

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](currentvalue.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Market Analyzer Column](market_analyzer_column.htm) >  CurrentValue | [Previous page](currenttext.htm) [Return to chapter overview](market_analyzer_column.htm) [Next page](datatype.htm) |

Definition
----------

The value to be displayed in the Market Analyzer Column

Property Value
--------------

A double representing the value to be displayed in the column

Syntax
------

CurrentValue

Example
-------

| ns |
| --- |
| protected override void OnMarketData(Data.MarketDataEventArgs marketDataUpdate)  {      CurrentValue = marketDataUpdate.Price;  } |