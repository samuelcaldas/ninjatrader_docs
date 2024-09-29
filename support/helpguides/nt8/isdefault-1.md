


NinjaScript \> Language Reference \> Share Service \> IsDefault






















IsDefault







| \<\< [Click to Display Table of Contents](isdefault.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> IsDefault | [Previous page](isconfigured-1.md) [Return to chapter overview](share_service-1.md) [Next page](isimageattachmentsupported-1.md) |
| --- | --- |











## Definition


Sets the default Share Service used when the type of sharing service is selected. 


 


For example, if you are using two different email adapters, you may set one to be the default when the user selects the email sharing service.  Setting this property as the default would only apply to any email adapters and would not apply to any other types of sharing services which have their own respective default adapter.  


## 


## Property Value


A bool value that represents if the current adapter is default Share Service used for that type of sharing service.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |



 


 


## Syntax


Default


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {                         if (State \=\= State.SetDefaults) { Default        \= false; } } |









