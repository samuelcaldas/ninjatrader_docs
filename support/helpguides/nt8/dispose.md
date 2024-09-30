
NinjaScript > Language Reference > Drawing Tool > Dispose()

Dispose()

| << [Click to Display Table of Contents](dispose.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > Dispose() | [Previous page](displayonchartsmenus.md) [Return to chapter overview](drawing_tools.md) [Next page](drawingstate.md) |
| --- | --- |
## Definition
Releases any device resources used for the drawing tool.
 
## Method Return Value
This method does not return a value
## 
## Syntax
Dispose()
## 
## Method Parameters
This method does not accept any parameters
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {      Name                 = @"My Drawing Tool";          }      else if (State == State.Terminated)      Dispose(); } |
