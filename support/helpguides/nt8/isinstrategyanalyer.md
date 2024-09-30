
NinjaScript \> Language Reference \> Strategy \> IsInStrategyAnalyzer

IsInStrategyAnalyzer

| \<\< [Click to Display Table of Contents](isinstrategyanalyer.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> IsInStrategyAnalyzer | [Previous page](isinstantiatedoneachoptimizationiteration.md) [Return to chapter overview](strategy.md) [Next page](istradinghoursbreaklinevisible.md) |
| --- | --- |
## Definition
Determines if the current NinjaScript Strategy is run from a Strategy Analyzer chart.
 
## Property Value
A bool value when true the strategy is being run from the Strategy Analyzer chart; otherwise will return false.
 
## Syntax
IsInStrategyAnalyzer
 
## Examples
 

| ns | |
| --- | --- |
|  | protected override void OnBarUpdate() {     // Only draw the ArrowUp on our condition if we're not in the Strategy Analyzer chart    if (Close\[0] \> SMA(High, 14)\[0] \&\& !IsInStrategyAnalyzer)        Draw.ArrowUp(this, CurrentBar.ToString(), true, 0, High\[0] \+ TickSize, Brushes.Blue); } |
