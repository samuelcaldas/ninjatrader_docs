


NinjaScript \> Language Reference \> Share Service \> IsImageAttachmentSupported






















IsImageAttachmentSupported







| \<\< [Click to Display Table of Contents](isimageattachmentsupported.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> IsImageAttachmentSupported | [Previous page](isdefault-1.md) [Return to chapter overview](share_service-1.md) [Next page](onauthorizeaccount-1.md) |
| --- | --- |











## Definition


Determines if the Share Service will allow for images as attachments.


## 


## Property Value


A bool value when false, screenshots will be unable to be sent to the social network.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



  


## 


## Syntax


IsImageAttachmentSupported


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       IsImageAttachmentSupported   \= false;    } } |









