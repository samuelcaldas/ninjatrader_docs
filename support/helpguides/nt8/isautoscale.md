
NinjaScript > Language Reference > Common > Charts > IsAutoScale
IsAutoScale
| << [Click to Display Table of Contents](isautoscale.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > IsAutoScale | [Previous page](formatpricemarker.md) [Return to chapter overview](chart.md) [Next page](isoverlay.md) |
| --- | --- |
## Definition
If true, the object will call [CalculateMinMax()](oncalculateminmax.md) in order to determine the object's [MinValue](minvalue.md) and [MaxValue](maxvalue.md) value used to scale the Y-axis of the chart.
## 
## Property Value
This property returns true if the object's are included in the y-scale; otherwise, false. Default set to false for [DrawingTools](drawing_tools.md), but set to true for [Indicators](indicator.md).
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## 
## Syntax
IsAutoScale
## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {               Name                 = "Example Indicator";               // set this to true to call CalculateMinMix() to ensure drawing tool is fully rendered in chart scale      IsAutoScale = true;      }    else if (State == State.Configure)    {    } } |
