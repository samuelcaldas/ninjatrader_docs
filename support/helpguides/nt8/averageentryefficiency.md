
NinjaScript > Language Reference > Strategy > TradeCollection > TradesPerformance > AverageEntryEfficiency
AverageEntryEfficiency
| << [Click to Display Table of Contents](averageentryefficiency.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [TradeCollection](tradecollection.md) > [TradesPerformance](tradesperformance.md) > AverageEntryEfficiency | [Previous page](averagebarsintrade.md) [Return to chapter overview](tradesperformance.md) [Next page](averageexitefficiency.md) |
| --- | --- |
## Definition
Returns the average entry efficiency.  

 
## Property Value
A double value that represents the average entry efficiency.
 
## Syntax
<TradeCollection>.TradesPerformance.AverageEntryEfficiency

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry efficiency      Print("Average entry efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageEntryEfficiency); } |

