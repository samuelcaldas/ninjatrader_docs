
NinjaScript > Language Reference > Common > OnBarUpdate() > CurrentBar
CurrentBar
| << [Click to Display Table of Contents](currentbar.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnBarUpdate()](onbarupdate-1.md) > CurrentBar | [Previous page](count-1.md) [Return to chapter overview](onbarupdate-1.md) [Next page](isdataseriesrequired-1.md) |
| --- | --- |
## Definition
A number representing the current bar in a Bars object that the OnBarUpdate() method in an indicator or strategy is currently processing. For example, if a chart has 100 bars of data, the very first bar of the chart (left most bar) will be number 0 (zero) and each subsequent bar from left to right is incremented by 1.
 
| Note:    In [multi series](multi-time_frame__instruments-1.md) processing, the [CurrentBars](currentbars-1.md) starting value will be -1 until all series have processed the first bar. |
| --- |
 
## 
## Property Value
An int value that represents the current bar.
 
## Syntax
CurrentBar
 
## 
## Examples
| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {      // Evaluates to make sure we have at least 20 or more bars      if (CurrentBar < 20)          return;        // Indicator logic calculation code... } |

