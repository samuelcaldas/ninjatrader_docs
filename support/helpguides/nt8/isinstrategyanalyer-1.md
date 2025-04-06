



IsInStrategyAnalyzer

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isinstrategyanalyer.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  IsInStrategyAnalyzer | [Previous page](isinstantiatedoneachoptimizationiteration-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](istradinghoursbreaklinevisible-1.htm) |

Definition
----------

Determines if the current NinjaScript Strategy is run from a Strategy Analyzer chart.

Property Value
--------------

A bool value when true the strategy is being run from the Strategy Analyzer chart; otherwise will return false.

Syntax
------

IsInStrategyAnalyzer

Examples
--------

 

| ns | |
| --- | --- |
|  | protected override void OnBarUpdate()  {      // Only draw the ArrowUp on our condition if we're not in the Strategy Analyzer chart     if (Close[0] > SMA(High, 14)[0] && !IsInStrategyAnalyzer)         Draw.ArrowUp(this, CurrentBar.ToString(), true, 0, High[0] + TickSize, Brushes.Blue);  } |