
NinjaScript > Language Reference > Common > Bars > GetVolume()
GetVolume()
| << [Click to Display Table of Contents](getvolume.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Bars](bars.md) > GetVolume() | [Previous page](gettime.md) [Return to chapter overview](bars.md) [Next page](isfirstbarofsession.md) |
| --- | --- |
## Definition
Returns the volume at the selected bar index value.
 
## Method Return Value
A long value represents the volume at the desired bar index.
## 
## Syntax
Bars.GetVolume(int index)
 
## Parameters
| index | An int representing an absolute bar index value |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through all the rendered bars on the chart    for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)    {      // get the volume value at the selected bar index value      long volumeValue = Bars.GetVolume(barIndex);      Print("Bar #" + barIndex + " volume value is " + volumeValue);    } } |
