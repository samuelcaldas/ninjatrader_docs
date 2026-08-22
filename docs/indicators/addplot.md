# AddPlot()

## Definition

Adds plot objects that define how an indicator or strategy data series render on a chart. When this method is called to add a plot, an associated [`Series<double>`](../language_reference/seriest.md) object is created held in the [Values](../language_reference/value.md) collection.

```csharp
State.Configure.
Calling AddPlot() in this manner should be reserved for special cases.
Please see the examples below.
```
## Methods and Properties

| Name / Option | Description |
| --- | --- |
| ArePlotsConfigurable | Determines if the plot(s) used in an indicator are configurable within the indicator dialog window. |
| Displacement | An offset value that shifts the visually displayed value of an indicator. |
| PlotBrushes | Holds an array of color series objects holding historical bar colors. |
| Plots | A collection holding all of the Plot objects that define their visualization characteristics. |

## Syntax

AddPlot(Brushname)  
AddPlot(Strokename)

 

> State.Configure

## Parameters

| Name / Option | Description |
| --- | --- |
| brush | Brush object used to construct the plot |
| name | string representing the name of the plot |
| plotStyle | A PlotStyle object used to construct the style of the plot   Possible values:     PlotStyle.Bar  PlotStyle.Block  PlotStyle.Cross  PlotStyle.Dot  PlotStyle.Hash  PlotStyle.HLine  PlotStyle.Line  PlotStyle.PriceBox  PlotStyle.Square  PlotStyle.TriangleDown  PlotStyle.TriangleLeft  PlotStyle.TriangleRight  PlotStyle.TriangleUp |
| stroke | Stroke object used to construct the plot |

> **Tips:** BarsRequiredToPlot value has been satisfied. By default, the value is 20.

## Examples

```csharp
// Indicator using various AddPlot() signatures
OnStateChange()
{
    State.SetDefaults)
    {
        ;
        // Adds a blue line style plot
        );
        // Adds a blue historgram style plot
        );
        // Ensures that the width of the PlotStyle.Bar plot matches the width of the data series
        Plots[1].AutoWidth = true;
        // Adds a blue Dash-Line style plot with 5pixel width and 50% opacity
        );
    }
}
csharp
// Indicator using a public Series<double> to expose a plot with a friendly name. This is required for making plots accessible in the Strategy BuilderFor an example on exposing other variables publicly, see [Exposing Indicator values that are not plots](exposing_indicator_values_that.md)
OnStateChange()
{
    State.SetDefaults)
    {
        ;
        // Adds a blue line style plot
        );
        // Adds a blue historgram style plot
        );
    }
}
OnBarUpdate()
{
    MyPlot[​;
    MyPlot[​;
}
[Browsable()]
[XmlIgnore]
MyPlot
{
    get}
}
[Browsable()]
[XmlIgnore]
MyPlot2
{
    get}
}
csharp
// Indicator which adds three value series
OnStateChange()
{
    State.SetDefaults)
    {
        ;
        // Add three plots and associated Series<double> objects
        // Defines the plot for Values[0]
        // Defines the plot for Values[1]
        // Defines the plot for Values[2]
    }
}
OnBarUpdate()
{
    // Blue "Plot A"
    // Red "Plot B"
    // Green "Plot C"
}
csharp
// Indicator which dynamically adds a plot in State.Configure
OnStateChange()
{
    State.SetDefaults)
    {
        ;
        // logical property which user can set
        ;
        // Default brush selection pushed to the UI
        Brushes.Red;
    }
    State.Configure)
    {
        // if user enables logical property
        (UseSpecialMode)
        {
            // add plot using default selected brush and special plot name
            );
        }
        else
        {
            // otherwise use default selected brush and regular plot name
            );
        }
    }
}
OnBarUpdate()
{
    (UseSpecialMode)
    ;
    ;
}
[XmlIgnore]
}
}
```