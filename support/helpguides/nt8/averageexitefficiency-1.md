
NinjaScript \> Language Reference \> Strategy \> TradeCollection \> TradesPerformance \> AverageExitEfficiency
AverageExitEfficiency
| \<\< [Click to Display Table of Contents](averageexitefficiency.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [TradeCollection](tradecollection-1.md) \> [TradesPerformance](tradesperformance-1.md) \> AverageExitEfficiency | [Previous page](averageentryefficiency-1.md) [Return to chapter overview](tradesperformance-1.md) [Next page](averagetimeinmarket-1.md) |
| --- | --- |
## Definition
Returns the average exit efficiency.  

 
## Property Value
A double value that represents the average exit efficiency.
 
## Syntax
\<TradeCollection\>.TradesPerformance.AverageExitEfficiency

## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average exit efficiency      Print("Average exit efficiency is: " \+ SystemPerformance.AllTrades.TradesPerformance.AverageExitEfficiency); } |

