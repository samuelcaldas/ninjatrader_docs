



ScaleJustification

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\scalejustification.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) >  ScaleJustification | [Previous page](isseparatezorder-1.htm) [Return to chapter overview](chart-1.htm) [Next page](stroke_class-1.htm) |

Definition
----------

Determines which scale an indicator will be plotted on.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults or State.Configure |

Property Value
--------------

This property returns a ScaleJustification value of either:

NinjaTrader.Gui.Charts.ScaleJustification.Left;  
NinjaTrader.Gui.Charts.ScaleJustification.Overlay;  
NinjaTrader.Gui.Charts.ScaleJustification.Right;

Syntax
------

ScaleJustification

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {           if (State == State.SetDefaults)     {       Name = "Examples Indicator";             // force "My Plot" to be plotted on the left scale       ScaleJustification = ScaleJustification.Left;       }     else if (State == State.Configure)     {                   AddPlot(Brushes.Orange, "My Plot");     }  } |