
NinjaScript > Language Reference > Common > Charts > Rendering > IsInHitTest

IsInHitTest

| << [Click to Display Table of Contents](isinhittest.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [Rendering](rendering-1.md) > IsInHitTest | [Previous page](forcerefresh-1.md) [Return to chapter overview](rendering-1.md) [Next page](isselected-1.md) |
| --- | --- |
## Definition
Indicates a user is currently clicking in the chart panel in which the calling script resides. 
## 

| Note: In addition to the example below, IsInHitTest can also be tested directly on chart objects (for example, myHorizontalLine.IsInHitTest). In this case, the IsInHitTest property of a specific object will refer to the panel in which the calling script resides, even if the calling script resides in a different panel than the object itself. |
| --- |
## 
## Property Value
This property returns true to indicate that the chart panel in which the script resides is being clicked on; otherwise, false. Default set to false.
 
## Syntax
IsInHitTest
## 
## Examples

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {                if(IsInHitTest)    {        Print("user clicked on object");                  // do something    } } |
