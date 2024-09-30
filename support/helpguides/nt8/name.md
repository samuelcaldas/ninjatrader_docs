
NinjaScript > Language Reference > Common > Name

Name

| << [Click to Display Table of Contents](name.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Name | [Previous page](isvisible.md) [Return to chapter overview](common.md) [Next page](triggercustomevent.md) |
| --- | --- |
## Definition
Determines the listed name of the NinjaScript object.
 
## Property Value
A string value.
 
## Syntax
Name
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {        if (State == State.SetDefaults)    {      Name                 = "Examples indicator";      Description           = @"An example of an indicator used for documentation purposes";          } } |
