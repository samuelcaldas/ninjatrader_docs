



UseOAuth
========

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](isauthorizationrequired.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Share Service](share_service.htm) > UseOAuth | [Previous page](icon.htm) [Return to chapter overview](share_service.htm) [Next page](isconfigured.htm) |

Definition
----------

If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount.htm) when the user clicks it.

Property Value
--------------

A bool value determining if the OnAuthorizeAccount() method should be called in order to authorize the account to the social service.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.htm) method during State.SetDefaults |

Syntax
------

UseOAuth

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {              if (State == State.SetDefaults)     {        UseOAuth   = true;     }  } |