



FromIndex

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartbars_fromindex.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartBars](chartbars-1.htm) >  FromIndex | [Previous page](chartbars_count-1.htm) [Return to chapter overview](chartbars-1.htm) [Next page](chartbars_getbaridxbytime-1.htm) |

Definition
----------

An index value representing the first bar rendered on the chart.  See also [ToIndex](chartbars_toindex-1.htm).

|  |
| --- |
| Note:  This value is NOT the first value that exists on the [ChartBars](chartbars-1.htm), but rather the first bar index that is within the viewable range of the chart canvas area.  This value changes as the user interacts with the [ChartControl](chartcontrol-1.htm) time-scale (x-axis). |

Property Value
--------------

An int representing the first bar index painted on the chart

Syntax
------

ChartBars.FromIndex

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     if (ChartBars != null)     {       // loop through all of the viewable range of the chart       for (int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)       {           // print the High value for each index within the viewable range           Print(High.GetValueAt(barIndex));       }     }  } |