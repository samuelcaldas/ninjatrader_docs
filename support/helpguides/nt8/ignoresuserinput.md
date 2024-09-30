
NinjaScript \> Language Reference \> Drawing Tool \> IgnoresUserInput

IgnoresUserInput
| \<\< [Click to Display Table of Contents](ignoresuserinput.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> IgnoresUserInput | [Previous page](ignoressnapping.md) [Return to chapter overview](drawing_tools.md) [Next page](isattachedtoninjascript.md) |
| --- | --- |
Definition  

Determines if the drawing tool can be clicked on by the user.
 
## Property Value
A bool value which wen true if the drawing tool cannot not be interacted with by a user; otherwise false.  Default is set to false.
 
## Syntax
IgnoresUserInput
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {               IgnoresUserInput \= true; // Set this to true to make the drawing object non\-interactive      }      else if (State \=\= State.Configure)      {        } } |
