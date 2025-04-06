



DrawHorizontalGridLines

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\drawhorizontalgridlines.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Indicator](indicator-1.htm) >  DrawHorizontalGridLines | [Previous page](displayindatabox-1.htm) [Return to chapter overview](indicator-1.htm) [Next page](drawonpricepanel-1.htm) |

Definition
----------

Plots horizontal grid lines on the indicator panel.

|  |
| --- |
| Note:  The indicator panel's parent chart has a similar option 'Grid line - horizontal  which if Visible property set to false, will override the indicator's local setting if true. |

Property Value
--------------

This property returns true if horizontal grid lines are plotted on the indicator panel; otherwise, false. Default set to true.

|  |
| --- |
| Warning:  This property should ONLY be set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults or State.Configure |

Syntax
------

DrawHorizontalGridLines

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           DrawHorizontalGridLines = false; // Horizontal grid lines will not plot on the indicator panel               AddPlot(Brushes.Orange, "SMA");       }  } |