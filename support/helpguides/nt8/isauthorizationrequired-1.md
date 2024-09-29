


NinjaScript \> Language Reference \> Share Service \> UseOAuth






















# UseOAuth







| \<\< [Click to Display Table of Contents](isauthorizationrequired.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> UseOAuth | [Previous page](icon-1.md) [Return to chapter overview](share_service-1.md) [Next page](isconfigured-1.md) |
| --- | --- |











## Definition


If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount-1.md) when the user clicks it.


## 


## Property Value


A bool value determining if the OnAuthorizeAccount() method should be called in order to authorize the account to the social service.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |



 


## Syntax


UseOAuth


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       UseOAuth   \= true;    } } |









