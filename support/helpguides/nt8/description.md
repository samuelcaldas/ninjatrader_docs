
NinjaScript > Language Reference > Common > Description
Description
| << [Click to Display Table of Contents](description.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Description | [Previous page](clone.md) [Return to chapter overview](common.md) [Next page](indicator_displayname.md) |
| --- | --- |
## Definition
Text which is used on the UI's information box to be displayed to a user when configuration a NinjaScript object.
 
## Method Return Value
A string value representing text used to describe the object.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |
 
## Syntax
Description

## Examples
| ns |
| --- |
| protected override void OnStateChange() {          if (State == State.SetDefaults)    {      Name = "Examples Indicator";         Description = @"An indicator used to demonstrate various NinjaScript methods and properties";    } } |

