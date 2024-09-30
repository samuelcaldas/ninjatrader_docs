
NinjaScript \> Language Reference \> Indicator \> AddLine() \> Lines

Lines

| \<\< [Click to Display Table of Contents](lines.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> [AddLine()](addline-1.md) \> Lines | [Previous page](line_class-1.md) [Return to chapter overview](addline-1.md) [Next page](addplot-1.md) |
| --- | --- |
## Definition
A collection holding all of the Line objects that define the visualization characteristics oscillator lines of the indicator.
 
## Property Value
A collection of Line objects.
 
## Syntax
Lines\[int index]

## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Lines are added to the Lines collection in order          AddLine(Brushes.Gray, 30, "Lower"); // Stored in Lines\[0]          AddLine(Brushes.Gray, 70, "Upper"); // Stored in Lines\[1]      } }   // Dynamically change the upper line's color and thickness based on the indicator value protected override void OnBarUpdate() {    if(Value\[0] \> 70)    {      Lines\[1].Brush \= Brushes.Blue;      Lines\[1].Width \= 3;    }    else     {       Lines\[1].Brush \= Brushes.Gray;       Lines\[1].Width \= 1;     } } |
