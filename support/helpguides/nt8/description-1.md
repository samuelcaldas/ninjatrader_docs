


NinjaScript \> Language Reference \> Common \> Description






















Description







| \<\< [Click to Display Table of Contents](description.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> Description | [Previous page](clone-1.md) [Return to chapter overview](common-1.md) [Next page](indicator_displayname-1.md) |
| --- | --- |











## Definition


Text which is used on the UI's information box to be displayed to a user when configuration a NinjaScript object.


 


## Method Return Value


A string value representing text used to describe the object.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


## Syntax


Description


 


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";         Description \= @"An indicator used to demonstrate various NinjaScript methods and properties";    } } |









