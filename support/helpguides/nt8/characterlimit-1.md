
NinjaScript \> Language Reference \> Share Service \> CharacterLimit

CharacterLimit
| \<\< [Click to Display Table of Contents](characterlimit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> CharacterLimit | [Previous page](share_service-1.md) [Return to chapter overview](share_service-1.md) [Next page](charactersreservedpermedia-1.md) |
| --- | --- |
## Definition
Determines the maximum number of characters the social network allows. Signature, text, and links all contribute to this character count displayed on the share window.
 
A value of int.MaxValue determines no practical limit and will make the character count not appear on the Share window.
## 
## Property Value
A int value that represents the maximum number of characters the social network allows.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
CharacterLimit
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {                         if (State \=\= State.SetDefaults) { CharacterLimit        \= 280; } } |
