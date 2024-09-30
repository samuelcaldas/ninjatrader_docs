
NinjaScript \> Language Reference \> Share Service \> Signature

Signature

| \<\< [Click to Display Table of Contents](signature.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> Signature | [Previous page](onshare.md) [Return to chapter overview](share_service.md) [Next page](strategy.md) |
| --- | --- |
## Definition
Sets the text appended to the end of the user's message. It is uneditable by the user, and contributes to the character count of the overall message.
 
You can set it to an empty string if it does not apply to your adapter. In that case, the Signature label will not appear in the Share window.
## 
## Property Value
A string value which is appended to the end of the user's message.
 
## Syntax
Signature
 
## Examples

| ns |
| --- |
| //example \#1, adds text "This message was sent from NinjaTrader" at the end of the message". protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       Signature   \= "This message was sent from NinjaTrader";    } }   //example \#2, uses an empty string which does not add any additional text to the message protected override void OnStateChange() {             if (State \=\= State.SetDefaults)    {       Signature   \= string.Empty;    } } |
 
