



PlotBrushes

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](plotbrushes.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Indicator](indicator.htm) > [AddPlot()](addplot.htm) >  PlotBrushes | [Previous page](displacement.htm) [Return to chapter overview](addplot.htm) [Next page](plots.htm) |

Definition
----------

Holds an array of color series objects holding historical bar colors. A color series object is added to this array when calling the [AddPlot()](addplot.htm) method in a custom Indicator for plots. Its purpose is to provide access to the color property of all bars.

Property Value
--------------

An array of color series objects.

Syntax 
PlotBrushes[int PlotIndex][int barsAgo]
-----------------------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if(State == State.SetDefaults)     {       Name = "Example Indicator";              // Add two plots         AddPlot(Brushes.Blue, "Upper");         AddPlot(Brushes.Orange, "Lower");       }  }     protected override void OnBarUpdate()  {       // Sets values to our two plots       Upper[0] = SMA(High, 20)[0];       Lower[0] = SMA(Low, 20)[0];          // Color the Upper plot based on plot value conditions       if (IsRising(Upper))           PlotBrushes[0][0] = Brushes.Blue;       else if (IsFalling(Upper))           PlotBrushes[0][0] = Brushes.Red;       else           PlotBrushes[0][0] = Brushes.Yellow;          // Color the Lower plot based on plot value conditions       if (IsRising(Lower))           PlotBrushes[1][0] = Brushes.Blue;       else if (IsFalling(Lower))           PlotBrushes[1][0] = Brushes.Red;       else           PlotBrushes[1][0] = Brushes.Yellow;  }     public Series<double> Upper  {     get { return Values[0]; }  }       public Series<double> Lower  {     get { return Values[1]; }  } |