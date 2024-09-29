


NinjaScript \> Language Reference \> Share Service \> IsImageAttachmentSupported






















IsImageAttachmentSupported







| \<\< [Click to Display Table of Contents](isimageattachmentsupported.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> IsImageAttachmentSupported | [Previous page](isdefault.md) [Return to chapter overview](share_service.md) [Next page](onauthorizeaccount.md) |
| --- | --- |











## Definition


Determines if the Share Service will allow for images as attachments.


## 


## Property Value


A bool value when false, screenshots will be unable to be sent to the social network.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



  


## 


## Syntax


IsImageAttachmentSupported


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       IsImageAttachmentSupported   \= false;    } } |









