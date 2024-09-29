


NinjaScript \> Language Reference \> Share Service \> OnShare()






















OnShare()







| \<\< [Click to Display Table of Contents](onshare.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> OnShare() | [Previous page](onauthorizeaccount.md) [Return to chapter overview](share_service.md) [Next page](signature.md) |
| --- | --- |











## Definition


This method is called when the user clicks OK on the Share window in NinjaTrader. This method can also be called by Alerts and general NinjaScript objects.


## 


## Method Return Value


This method does not return a value


 


## Parameters




| text | The message being sent to the social network or other Share provider. This is what appears in the textbox of the Share window |
| --- | --- |
| imageFilePath | Optional path to screenshot or other image to be sent to the social network or other Share provider |



## 


## Syntax




| You must override the method in your Share Service with the following syntax.   public override void OnShare(string text, string imageFilePath) {   } |
| --- |



 


## Examples




| ns |
| --- |
| public override void OnShare(string text, string imgFilePath) {  // place your share service logic here } |



 








