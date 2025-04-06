



OnBarsChanged()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\onbarschanged.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  OnBarsChanged() | [Previous page](isuserdrawn-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](onmousedown-1.htm) |

Definition
----------

An event driven method which is called any time the underlying bar series have changed for the chart where the drawing tool resides.  For example if a user has changed the primary instrument or the time frame of the bars used on the chart.

Method Return Value
-------------------

This method does not return a value

Syntax
------

You must override this method using the following syntax:

public override void OnBarsChanged()  
{  
     
}

Method Parameters
-----------------

This method does not accept any parameters

Examples
--------

| ns |
| --- |
| public override void OnBarsChanged()  {      //bars have change, do something           } |