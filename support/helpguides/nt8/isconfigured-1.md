


NinjaScript \> Language Reference \> Share Service \> IsConfigured






















IsConfigured







| \<\< [Click to Display Table of Contents](isconfigured.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> IsConfigured | [Previous page](isauthorizationrequired-1.md) [Return to chapter overview](share_service-1.md) [Next page](isdefault-1.md) |
| --- | --- |











## Definition


Sets when the Share Service is correctly configured.  Typically this would be set after the account is authorized, at which point the adapter will allow for the user to share content to the sharing service.     


 




| Note:  It is not required for a Share Service to authorize a user, therefore it is possible to set IsConfigured to true in State.SetDefaults which will bypass any sort of authorization or additional setup that may be needed for the share adapter. |
| --- |



 


## 


## Property Value


A bool value when true determines if the Share Adapter is properly configured. 


 


## Syntax


IsConfigured


 


## 


## Examples




| ns |
| --- |
| public override void OnAuthorizeAccount() {    //Authorization logic would be here, after success, set IsConfigured to true.      IsConfigured \= true; } |









