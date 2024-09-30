
NinjaScript \> Language Reference \> Indicator \> DrawHorizontalGridLines

DrawHorizontalGridLines
| \<\< [Click to Display Table of Contents](drawhorizontalgridlines.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> DrawHorizontalGridLines | [Previous page](displayindatabox-1.md) [Return to chapter overview](indicator-1.md) [Next page](drawonpricepanel-1.md) |
| --- | --- |
## Definition
Plots horizontal grid lines on the indicator panel.
## 
| Note:  The indicator panel's parent chart has a similar option 'Grid line \- horizontal  which if Visible property set to false, will override the indicator's local setting if true. |
| --- |

## Property Value
This property returns true if horizontal grid lines are plotted on the indicator panel; otherwise, false. Default set to true.
 
| Warning:  This property should ONLY be set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
DrawHorizontalGridLines
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          DrawHorizontalGridLines \= false; // Horizontal grid lines will not plot on the indicator panel              AddPlot(Brushes.Orange, "SMA");      } } |
