
NinjaScript \> Language Reference \> Common \> Charts \> IsAutoScale
IsAutoScale
| \<\< [Click to Display Table of Contents](isautoscale.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> IsAutoScale | [Previous page](formatpricemarker-1.md) [Return to chapter overview](chart-1.md) [Next page](isoverlay-1.md) |
| --- | --- |
## Definition
If true, the object will call [CalculateMinMax()](oncalculateminmax-1.md) in order to determine the object's [MinValue](minvalue-1.md) and [MaxValue](maxvalue-1.md) value used to scale the Y\-axis of the chart.
## 
## Property Value
This property returns true if the object's are included in the y\-scale; otherwise, false. Default set to false for [DrawingTools](drawing_tools-1.md), but set to true for [Indicators](indicator-1.md).
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## 
## Syntax
IsAutoScale
## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {               Name                 \= "Example Indicator";               // set this to true to call CalculateMinMix() to ensure drawing tool is fully rendered in chart scale      IsAutoScale \= true;      }    else if (State \=\= State.Configure)    {    } } |
