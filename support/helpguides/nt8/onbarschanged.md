
NinjaScript > Language Reference > Drawing Tool > OnBarsChanged()

OnBarsChanged()

| << [Click to Display Table of Contents](onbarschanged.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > OnBarsChanged() | [Previous page](isuserdrawn.md) [Return to chapter overview](drawing_tools.md) [Next page](onmousedown.md) |
| --- | --- |
## Definition
An event driven method which is called any time the underlying bar series have changed for the chart where the drawing tool resides.  For example if a user has changed the primary instrument or the time frame of the bars used on the chart.
 
## Method Return Value
This method does not return a value
## 
## Syntax
You must override this method using the following syntax:
## 
public override void OnBarsChanged()  

{  

     

}
## 
## Method Parameters
This method does not accept any parameters
## 
## Examples

| ns |
| --- |
| public override void OnBarsChanged() {     //bars have change, do something          } |
