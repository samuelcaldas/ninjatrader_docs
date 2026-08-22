# TradesPerformanceValues

## Definition

Performance values of a [collection](tradecollection.md) of [Trade](trade.md) objects.

- Currency and Point based calculations are per trade

- Percent based calculations are per traded unit

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| [AverageEtd](averageetd.md) | A double value representing avg end trade draw down |
| [AverageMae](averagemae.md) | A double value representing avg maximum adverse excursion |
| [AverageMfe](averagemfe.md) | A double value representing avg maximum favorable excursion |
| [AverageProfit](averageprofit.md) | A double value representing avg profit |
| [CumProfit](cumprofit.md) | A double value representing cumulative profit (percent is compounded) |
| [Drawdown](drawdown.md) | A double value representing draw down |
| [LargestLoser](largestloser.md) | A double value representing largest loss |
| [LargestWinner](largestwinner.md) | A double value representing largest gain |
| [ProfitPerMonth](profitpermonth.md) | A double value representing profit per month always as a percent |
| [StdDev](stddev.md) | A double value representing standard deviation on a per unit basis |
| [Turnaround](turnaround.md) | A double value representing the turnaround |
| [Ulcer](ulcer.md) | A double value representing the Ulcer value |

## Examples

```csharp
protected override void OnBarUpdate()
{
    // If the profit on real-time trades is > $1000 stop trading
    if (SystemPerformance.RealTimeTrades.TradesPerformance.Currency.CumProfit > 1000)
    return;
}
```