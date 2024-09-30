
NinjaScript \> Language Reference \> Share Service \> CharactersReservedPerMedia

CharactersReservedPerMedia
| \<\< [Click to Display Table of Contents](charactersreservedpermedia.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Share Service](share_service-1.md) \> CharactersReservedPerMedia | [Previous page](characterlimit-1.md) [Return to chapter overview](share_service-1.md) [Next page](icon-1.md) |
| --- | --- |
## Definition
Sets the number of characters allowed when attaching an image to ensure that character count is properly calculated.
 
| Note:  Social networks which limit the number of characters for each post, will have a defined number of characters that are reserved when an image or other media is attached. |
| --- |

## 
## 
## Property Value
A int value that represents the number of characters reserved when attaching an image or other media.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
CharactersReservedPerMedia
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {                         if (State \=\= State.SetDefaults) { CharactersReservedPerMedia        \= 40; } } |

## 
