
NinjaScript > Language Reference > Common > ISeries<T> > Count

Count

| << [Click to Display Table of Contents](iseries_count.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [ISeries<T>](iseriest-1.md) > Count | [Previous page](iseries_volumes-1.md) [Return to chapter overview](iseriest-1.md) [Next page](getvalueat-1.md) |
| --- | --- |
## Definition
Indicates the number total number of values in the ISeries<T> array.  This value should always be in sync with the [CurrentBars](currentbars-1.md) array for that series.
 
## Method Return Value
A int representing the total size of the series
 
## Syntax
Count
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    Print("Input count: " + Input.Count); } |
