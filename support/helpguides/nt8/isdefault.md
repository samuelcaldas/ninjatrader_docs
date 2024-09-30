
NinjaScript \> Language Reference \> Share Service \> IsDefault
IsDefault
| \<\< [Click to Display Table of Contents](isdefault.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> IsDefault | [Previous page](isconfigured.md) [Return to chapter overview](share_service.md) [Next page](isimageattachmentsupported.md) |
| --- | --- |
## Definition
Sets the default Share Service used when the type of sharing service is selected. 
 
For example, if you are using two different email adapters, you may set one to be the default when the user selects the email sharing service.  Setting this property as the default would only apply to any email adapters and would not apply to any other types of sharing services which have their own respective default adapter.  
## 
## Property Value
A bool value that represents if the current adapter is default Share Service used for that type of sharing service.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |

## Syntax
Default
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {                         if (State \=\= State.SetDefaults) { Default        \= false; } } |
