
NinjaScript > Language Reference > Common > Bars > GetVolume()
GetVolume()
| << [Click to Display Table of Contents](getvolume.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Bars](bars-1.md) > GetVolume() | [Previous page](gettime-1.md) [Return to chapter overview](bars-1.md) [Next page](isfirstbarofsession-1.md) |
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
