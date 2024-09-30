
NinjaScript \> Language Reference \> Common \> Charts \> ScaleJustification

ScaleJustification

| \<\< [Click to Display Table of Contents](scalejustification.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> ScaleJustification | [Previous page](isseparatezorder.md) [Return to chapter overview](chart.md) [Next page](stroke_class.md) |
| --- | --- |
## Definition
Determines which scale an indicator will be plotted on.
## 

| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Property Value
This property returns a ScaleJustification value of either:
 
NinjaTrader.Gui.Charts.ScaleJustification.Left;  

NinjaTrader.Gui.Charts.ScaleJustification.Overlay;  

NinjaTrader.Gui.Charts.ScaleJustification.Right;

## Syntax
ScaleJustification
 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";           // force "My Plot" to be plotted on the left scale      ScaleJustification \= ScaleJustification.Left;      }    else if (State \=\= State.Configure)    {                  AddPlot(Brushes.Orange, "My Plot");    } } |
