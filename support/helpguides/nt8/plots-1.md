
NinjaScript > Language Reference > Indicator > AddPlot() > Plots

Plots

| << [Click to Display Table of Contents](plots.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Indicator](indicator-1.md) > [AddPlot()](addplot-1.md) > Plots | [Previous page](plotbrushes-1.md) [Return to chapter overview](addplot-1.md) [Next page](barsrequiredtoplot-1.md) |
| --- | --- |
## Definition
A collection holding all of the Plot objects that define their visualization characteristics.
 
## Property Value
A collection of Plot objects.
 
## Syntax
Plots[int index]
 

| Note: The example code below will change the color of an entire plot series. See [PlotBrushes](plotbrushes-1.md) for information on changing only specific segments of a plot instead. |
| --- |

## Example

| ns |
| --- |
| protected override void OnStateChange() {    if(State == State.SetDefaults)    {        Name = "Examples Indicator";        // Lines are added to the Lines collection in order        AddPlot(Brushes.Orange, "Plot1"); // Stored in Plots[0]        AddPlot(Brushes.Blue, "Plot2");   // Stored in Plots[1]      } }   // Dynamically change the primary plot's color based on the indicator value protected override void OnBarUpdate() {    if (Value[0] > 70)    {      Plots[0].Brush = Brushes.Blue;      Plots[0].Width = 2;    }    else    {      Plots[0].Brush = Brushes.Red;      Plots[0].Width = 2;    } } |
