
NinjaScript > Language Reference > Common > ISeries<T> > Count

Count

| << [Click to Display Table of Contents](iseries_count.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [ISeries<T>](iseriest.md) > Count | [Previous page](iseries_volumes.md) [Return to chapter overview](iseriest.md) [Next page](getvalueat.md) |
| --- | --- |
## Definition
Indicates the number total number of values in the ISeries<T> array.  This value should always be in sync with the [CurrentBars](currentbars.md) array for that series.
 
## Method Return Value
A int representing the total size of the series
 
## Syntax
Count
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    Print("Input count: " + Input.Count); } |
