


NinjaScript \> Language Reference \> Strategy \> IsTradingHoursBreakLineVisible






















IsTradingHoursBreakLineVisible







| \<\< [Click to Display Table of Contents](istradinghoursbreaklinevisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> IsTradingHoursBreakLineVisible | [Previous page](isinstrategyanalyer.md) [Return to chapter overview](strategy.md) [Next page](iswaituntilflat.md) |
| --- | --- |











## Definition


Plots trading hours break lines on the indicator panel.


## 




| Note:  The indicator panel's parent chart has a similar property 'Plot session break line' which if set to false, will override the indicator's local setting if true. |
| --- |



 


 


## Property Value


This property returns true if trading hours break lines are plotted on the indicator panel; otherwise, false. Default set to true.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IsTradingHoursBreakLineVisible


 


 


## Examples




| ns | |
| --- | --- |
|  | protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsTradingHoursBreakLineVisible \= true;               AddPlot(Brushes.Orange, "SMA");      } } |









