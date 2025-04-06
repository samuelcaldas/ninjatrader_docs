



GetBarPaintWidth()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getbarpaintwidth.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Chart Style](chart_style-1.htm) >  GetBarPaintWidth() | [Previous page](downbrushdx-1.htm) [Return to chapter overview](chart_style-1.htm) [Next page](icon_chartstyle-1.htm) |

Definition
----------

Returns the painted width of the chart bar.  The GetBarPintWidth() method will return a minimum value of 1.

|  |
| --- |
| Note:  This is an [abstract](https://msdn.microsoft.com/en-us/library/sf985hc5.aspx) method which is required to compile a ChartStyle object.  If you do not plan on recalculating a barWidth, simply return the default barWidth parameter which is passed in this method.  Please see the Examples section of this page for more information. |

Method Return Value
-------------------

An int value

Syntax
------

You must over ride this method using the following syntax:

public override int GetBarPaintWidth(int barWidth)  
{  
   
}

 

Method Parameters
-----------------

|  |  |
| --- | --- |
| barWidth | An int value representing the current width of the bar to calculate |

Examples
--------

| ns Returning the default barWidth |
| --- |
| public override int GetBarPaintWidth(int barWidth)  {       return barWidth        } |

 

 

 

| ns Calculating and returning a new barWidth from the original barWidth |
| --- |
| public override int GetBarPaintWidth(int barWidth)  {    // calculate a new bar width      return 1 + 2 \* (barWidth - 1) + 2 \* (int) Math.Round(Stroke.Width);  } |