


NinjaScript \> Language Reference \> Share Service \> UseOAuth






















# UseOAuth







| \<\< [Click to Display Table of Contents](isauthorizationrequired.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> UseOAuth | [Previous page](icon.md) [Return to chapter overview](share_service.md) [Next page](isconfigured.md) |
| --- | --- |











## Definition


If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount.md) when the user clicks it.


## 


## Property Value


A bool value determining if the OnAuthorizeAccount() method should be called in order to authorize the account to the social service.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |



 


## Syntax


UseOAuth


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       UseOAuth   \= true;    } } |









