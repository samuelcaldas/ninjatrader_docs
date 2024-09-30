
NinjaScript > Language Reference > Common > Name

Name

| << [Click to Display Table of Contents](name.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > Name | [Previous page](isvisible-1.md) [Return to chapter overview](common-1.md) [Next page](triggercustomevent-1.md) |
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
