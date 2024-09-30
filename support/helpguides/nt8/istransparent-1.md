
NinjaScript > Language Reference > Chart Style > IsTransparent

IsTransparent

| << [Click to Display Table of Contents](istransparent.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Chart Style](chart_style-1.md) > IsTransparent | [Previous page](icon_chartstyle-1.md) [Return to chapter overview](chart_style-1.md) [Next page](chartstyle_onrender-1.md) |
| --- | --- |
## Definition
Indicates the bars in the ChartStyle are transparent.
 
## Property Value
A bool which, when true, indicates that the UpBrush, DownBrush, and Stroke.Brush are all set to transparent. Returns false if any of the three are not transparent.
 
## Syntax
IsTransparent

## Example

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.Configure)    {        //Print a message if the UpBrush, DownBrush, and Stroke.Brush are all transparent        if (IsTransparent)            Print("All bars are currently set to transparent");    } } |
