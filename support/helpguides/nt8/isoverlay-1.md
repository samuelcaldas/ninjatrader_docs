



IsOverlay

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isoverlay.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) >  IsOverlay | [Previous page](isautoscale-1.htm) [Return to chapter overview](chart-1.htm) [Next page](isseparatezorder-1.htm) |

Definition
----------

Determines if indicator plot(s) are drawn on the chart panel over top of price.  Setting this value to true will also allow an Indicator to be used as a [SuperDOM Indicator](working_with_indicators_superdom-1.htm).

Property Value
--------------

This property returns true if any indicator plot(s) are drawn on the chart panel; otherwise, false. Default set to false.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults |

Syntax
------

IsOverlay

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           IsOverlay = true; // Indicator plots are drawn on the chart panel on top of price               AddPlot(Brushes.Orange, "SMA");       }  } |