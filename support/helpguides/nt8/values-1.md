
NinjaScript > Language Reference > Common > ISeries<T> > PriceSeries<double> > Values
Values

| << [Click to Display Table of Contents](values.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [ISeries<T>](iseriest-1.md) > [PriceSeries<double>](priceseries-1.md) > Values | [Previous page](value-1.md) [Return to chapter overview](priceseries-1.md) [Next page](weighted-1.md) |
| --- | --- |

## Definition
Holds an array of ISeries<double> objects holding hold the indicator's underlying calculated values. ISeries<double> values are added to this array when calling the [AddPlot()](addplot-1.md) method. In case of a [MultiSeries](multi-time_frame__instruments-1.md) indicator synched to the primary series.
## 
## Property Value
A collection of ISeries<double> objects.
 
## Syntax
Values[int index]

## Examples
| ns |
| --- |
| // OnBarUpdate method of a custom indicator protected override void OnBarUpdate() {      // Ensures we have enough bars loaded for our indicator      if (CurrentBar < 1)          return;        // Evaluates the indicator's secondary value 1 bar ago and sets the value of the indicator      // for the current bar being evaluated      if (Values[1][1] < High[0] - Low[0])          Value[0] = High[0] - Low[0];      else          Value[0] = High[0] - Close[0]; } |

