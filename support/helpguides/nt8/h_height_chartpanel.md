



H (Height)

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](h_height_chartpanel.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartPanel](chartpanel.htm) >  H (Height) | [Previous page](chartobjects.htm) [Return to chapter overview](chartpanel.htm) [Next page](isyacisdisplayedleft_chartpanel.htm) |

Definition
----------

Indicates the height (in pixels) of the rendered area of the chart panel.

|  |
| --- |
| Note:  The paintable area does not extend all the way to the top edge of the panel itself, as seen in the image below. |

Property Value
--------------

A int representing the height of the panel in pixels

Syntax
------

ChartPanel.H

Example
-------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     base.OnRender(chartControl, chartScale);           // Print the height of the panel     Print(ChartPanel.H);  } |

 

 

Based on the image below, H reveals that the paintable area of the chart panel is 69 pixels high.

 

![ChartPanel_H](chartpanel_h.png)