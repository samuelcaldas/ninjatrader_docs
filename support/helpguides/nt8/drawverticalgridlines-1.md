


NinjaScript \> Language Reference \> Indicator \> DrawVerticalGridLines






















DrawVerticalGridLines







| \<\< [Click to Display Table of Contents](drawverticalgridlines.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> DrawVerticalGridLines | [Previous page](drawonpricepanel-1.md) [Return to chapter overview](indicator-1.md) [Next page](indicatorbaseconverter-1.md) |
| --- | --- |











## Definition


Plots vertical grid lines on the indicator panel.


## 




| Note:  The indicator panel's parent chart has a similar option 'Grid line \- vertical  which if Visible property set to false, will override the indicator's local setting if true. |
| --- |



 


 


## Property Value


This property returns true if vertical grid lines are plotted on the indicator panel; otherwise, false. Default set to true.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


DrawVerticalGridLines


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          DrawVerticalGridLines \= false; // Vertical grid lines will not plot on the indicator panel               AddPlot(Brushes.Orange, "SMA");      } } |









