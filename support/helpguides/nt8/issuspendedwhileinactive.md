


NinjaScript \> Language Reference \> Indicator \> IsSuspendedWhileInactive






















IsSuspendedWhileInactive







| \<\< [Click to Display Table of Contents](issuspendedwhileinactive.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> IsSuspendedWhileInactive | [Previous page](ischartonly.md) [Return to chapter overview](indicator.md) [Next page](paintpricemarkers.md) |
| --- | --- |











## Definition


Prevents OnBarUpdate from being raised while the indicators display is not in use.  Enabling this property in your indicator helps save CPU cycles while the indicator is suspended and not in use by a user.  Once the indicator is in a state that would no longer be considered suspended, the historical OnBarUpdate() events will be triggered allowing the indicator to catch up to current real\-time values.  


 


Suspension occurs in the following scenarios:


 


•Minimized Chart

•Minimized Market Analyzer

•Minimized Hot List Analyzer

•Minimized SuperDOM

•Background tabs of above features are considered "minimized"

•Inactive workspaces in the background

 




| Note:  Since events in OnBarUpdate() will not be processed while the indicator is suspended, internal NinjaScript functions such as [Alert()](alert.md), [PlaySound()](playsound.md), [Share()](share.md), [Print()](print.md), etc \- or any other method that would be used to notify a user of activity will NOT be processed until the indicator is un\-suspended. |
| --- |



 


 


## Scenarios where suspension will not occur


## The IsSuspendedWhileInactive property will be ignored and real\-time events will be processed as normal under the following cases:


 


•Indicators running in [Automated NinjaScript Strategies](running_a_ninjascript_strategy.md)

•Indicators which have [manually configured alerts](alerts_dialog.md)

•Indicators which have been [manually attached to orders](attachingorderstoindicators.md)

 


## Property Value


This property returns true if indicator can take advantage of suspension optimization; otherwise, false. Default set to false.


 




| Note:  This property is overridden to "true" automatically by the [NinjaScript Code Wizard](ns_wizard.md).  You will need to remove the property to return to the default value or manually set it to false to disable this behavior |
| --- |



 


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IsSuspendedWhileInactive


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsSuspendedWhileInactive \= true;      } } |









