


NinjaScript \> Language Reference \> Strategy \> IsTradingHoursBreakLineVisible






















IsTradingHoursBreakLineVisible







| \<\< [Click to Display Table of Contents](istradinghoursbreaklinevisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> IsTradingHoursBreakLineVisible | [Previous page](isinstrategyanalyer-1.md) [Return to chapter overview](strategy-1.md) [Next page](iswaituntilflat-1.md) |
| --- | --- |











## Definition


Plots trading hours break lines on the indicator panel.


## 




| Note:  The indicator panel's parent chart has a similar property 'Plot session break line' which if set to false, will override the indicator's local setting if true. |
| --- |



 


 


## Property Value


This property returns true if trading hours break lines are plotted on the indicator panel; otherwise, false. Default set to true.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IsTradingHoursBreakLineVisible


 


 


## Examples




| ns | |
| --- | --- |
|  | protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsTradingHoursBreakLineVisible \= true;               AddPlot(Brushes.Orange, "SMA");      } } |









