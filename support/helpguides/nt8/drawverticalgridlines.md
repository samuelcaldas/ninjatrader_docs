


NinjaScript \> Language Reference \> Indicator \> DrawVerticalGridLines






















DrawVerticalGridLines







| \<\< [Click to Display Table of Contents](drawverticalgridlines.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> DrawVerticalGridLines | [Previous page](drawonpricepanel.md) [Return to chapter overview](indicator.md) [Next page](indicatorbaseconverter.md) |
| --- | --- |











## Definition


Plots vertical grid lines on the indicator panel.


## 




| Note:  The indicator panel's parent chart has a similar option 'Grid line \- vertical  which if Visible property set to false, will override the indicator's local setting if true. |
| --- |



 


 


## Property Value


This property returns true if vertical grid lines are plotted on the indicator panel; otherwise, false. Default set to true.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


DrawVerticalGridLines


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          DrawVerticalGridLines \= false; // Vertical grid lines will not plot on the indicator panel               AddPlot(Brushes.Orange, "SMA");      } } |









