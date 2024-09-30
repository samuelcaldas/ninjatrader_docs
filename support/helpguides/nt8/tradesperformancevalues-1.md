
NinjaScript \> Language Reference \> Strategy \> TradesPerformanceValues
TradesPerformanceValues
| \<\< [Click to Display Table of Contents](tradesperformancevalues.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> TradesPerformanceValues | [Previous page](winningtrades-1.md) [Return to chapter overview](strategy-1.md) [Next page](averageetd-1.md) |
| --- | --- |
## Definition
Performance values of a [collection](tradecollection-1.md) of [Trade](trade-1.md) objects.
 
- Currency and Point based calculations are per trade 

- Percent based calculations are per traded unit 

 
## Methods and Properties
| [AverageEtd](averageetd-1.md) | A double value representing avg end trade draw down |
| --- | --- |
| [AverageMae](averagemae-1.md) | A double value representing avg maximum adverse excursion |
| [AverageMfe](averagemfe-1.md) | A double value representing avg maximum favorable excursion |
| [AverageProfit](averageprofit-1.md) | A double value representing avg profit |
| [CumProfit](cumprofit-1.md) | A double value representing cumulative profit (percent is compounded) |
| [Drawdown](drawdown-1.md) | A double value representing draw down |
| [LargestLoser](largestloser-1.md) | A double value representing largest loss |
| [LargestWinner](largestwinner-1.md) | A double value representing largest gain |
| [ProfitPerMonth](profitpermonth-1.md) | A double value representing profit per month always as a percent |
| [StdDev](stddev-1.md) | A double value representing standard deviation on a per unit basis |
| [Turnaround](turnaround-1.md) | A double value representing the turnaround |
| [Ulcer](ulcer-1.md) | A double value representing the Ulcer value |

## Examples
## 
| ns |
| --- |
| protected override void OnBarUpdate() {      // If the profit on real\-time trades is \> $1000 stop trading      if (SystemPerformance.RealTimeTrades.TradesPerformance.Currency.CumProfit \> 1000\)           return; } |
