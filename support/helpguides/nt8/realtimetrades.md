﻿
NinjaScript > Language Reference > Strategy > SystemPerformance > RealTimeTrades

RealTimeTrades

| << [Click to Display Table of Contents](realtimetrades.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [SystemPerformance](systemperformance.md) > RealTimeTrades | [Previous page](longtrades.md) [Return to chapter overview](systemperformance.md) [Next page](shorttrades.md) |
| --- | --- |
## Definition
RealTimeTrades is a [TradeCollection](tradecollection.md) object of real-time trades generated by a strategy.
 
## Syntax
SystemPerformance.RealTimeTrades

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the number of real-time trades      Print("The strategy has taken " + SystemPerformance.RealTimeTrades.Count + " real-time trades."); } |
