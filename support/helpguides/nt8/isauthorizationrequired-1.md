



UseOAuth
========

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isauthorizationrequired.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Share Service](share_service-1.htm) > UseOAuth | [Previous page](icon-1.htm) [Return to chapter overview](share_service-1.htm) [Next page](isconfigured-1.htm) |

Definition
----------

If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount-1.htm) when the user clicks it.

Property Value
--------------

A bool value determining if the OnAuthorizeAccount() method should be called in order to authorize the account to the social service.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults |

Syntax
------

UseOAuth

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {              if (State == State.SetDefaults)     {        UseOAuth   = true;     }  } |