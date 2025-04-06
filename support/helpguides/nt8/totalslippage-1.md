



TotalSlippage

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\totalslippage.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [TradeCollection](tradecollection-1.htm) > [TradesPerformance](tradesperformance-1.htm) >  TotalSlippage | [Previous page](totalquantity-1.htm) [Return to chapter overview](tradesperformance-1.htm) [Next page](tradescount-1.htm) |

Definition
----------

Returns the total slippage.

Property Value
--------------

A double value that represents the total slippage. This is presented in points, I.E. 0.25 for 1 execution on E-mini S&P 500 Futures.

Syntax 
<TradeCollection>.TradesPerformance.TotalSlippage
---------------------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the total slippage of all trades       Print("Total slippage is: " + SystemPerformance.AllTrades.TradesPerformance.TotalSlippage);  } |