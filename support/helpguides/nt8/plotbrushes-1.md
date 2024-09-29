


NinjaScript \> Language Reference \> Indicator \> AddPlot() \> PlotBrushes






















PlotBrushes







| \<\< [Click to Display Table of Contents](plotbrushes.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> [AddPlot()](addplot-1.md) \> PlotBrushes | [Previous page](displacement-1.md) [Return to chapter overview](addplot-1.md) [Next page](plots-1.md) |
| --- | --- |











## Definition


Holds an array of color series objects holding historical bar colors. A color series object is added to this array when calling the [AddPlot()](addplot-1.md) method in a custom Indicator for plots. Its purpose is to provide access to the color property of all bars. 


 


## Property Value


An array of color series objects.


 


## Syntax
PlotBrushes\[int PlotIndex]\[int barsAgo]


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if(State \=\= State.SetDefaults)    {      Name \= "Example Indicator";             // Add two plots        AddPlot(Brushes.Blue, "Upper");        AddPlot(Brushes.Orange, "Lower");      } }   protected override void OnBarUpdate() {      // Sets values to our two plots      Upper\[0] \= SMA(High, 20)\[0];      Lower\[0] \= SMA(Low, 20)\[0];        // Color the Upper plot based on plot value conditions      if (IsRising(Upper))          PlotBrushes\[0]\[0] \= Brushes.Blue;      else if (IsFalling(Upper))          PlotBrushes\[0]\[0] \= Brushes.Red;      else          PlotBrushes\[0]\[0] \= Brushes.Yellow;        // Color the Lower plot based on plot value conditions      if (IsRising(Lower))          PlotBrushes\[1]\[0] \= Brushes.Blue;      else if (IsFalling(Lower))          PlotBrushes\[1]\[0] \= Brushes.Red;      else          PlotBrushes\[1]\[0] \= Brushes.Yellow; }   public Series\<double\> Upper {    get { return Values\[0]; } }     public Series\<double\> Lower {    get { return Values\[1]; } } |









