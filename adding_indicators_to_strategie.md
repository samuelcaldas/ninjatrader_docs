# Adding Indicators to Strategies

When backtesting strategies it can be useful to add the indicators you use for calculations onto the chart to make it easier to check your strategy for accuracy. Instead of doing this step manually every time you run the strategy you can program it to automatically load the indicators for you.

## Example

To add a volume indicator to your charts you need to add this code snippet into the [OnStateChange](onstatechange.md) section of your code for the State: `State.DataLoaded`:

```csharp
protected override void OnStateChange()
{
    if (State == State.DataLoaded)
    {
        AddChartIndicator(VOL());
    }
}
```

To choose which panel you want your indicator plotted on you can use this code snippet in `State.DataLoaded`:

```csharp
VOL().Panel = 1;
AddChartIndicator(VOL());
```

To customize plot colors:

```csharp
VOL().Plots[0].Brush = Brushes.Red;
```

To customize plot width:

```csharp
VOL().Plots[0].Width = 4;
```

To customize the plot dash style:

```csharp
VOL().Plots[0].DashStyleHelper = DashStyleHelper.Dash;
```

To customize the plot style:

```csharp
VOL().Plots[0].PlotStyle = PlotStyle.Bar;
VOL().Plots[0].IsOverlay = true;
```

To customize lines you can do it the same way as above:

```csharp
RSI(14, 3).Lines[0].Brush = Brushes.Green;
```

Remember, you need to use the [AddChartIndicator()](addchartindicator.md) method to add your indicator if you wish to use any of the plot / line indicator customization examples.
