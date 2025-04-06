



CrosshairType

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\crosshairtype.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartControl](chartcontrol-1.htm) >  CrosshairType | [Previous page](chartpanels-1.htm) [Return to chapter overview](chartcontrol-1.htm) [Next page](firsttimepainted-1.htm) |

Definition
----------

Indicates the [Cross Hair](cross_hair-1.htm) type currently enabled on the chart.

Property Value
--------------

An enum specifying the type of Cross Hair currently enabled on the chart. Possible values are listed below:

|  |  |
| --- | --- |
| Local | The local (single-chart) Cross Hair is enabled |
| Global | Global Cross Hair |
| GlobalNoTimeScroll | Global Cross Hair (No Time Scroll) is enabled |

Syntax
------

<ChartControl>.CrosshairType

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Print a message if the user enables the Global Cross Hair without time scrolling     if (chartControl.CrosshairType == CrosshairType.GlobalNoTimeScroll)         Print("It is recommended to enable Global Cross Hair time scrolling with this indicator");  } |

 

 

In the image below, CrosshairType reveals that Global Cross Hair (No Time Scroll) is enabled on the chart.

 

![ChartControl_CrosshairType](chartcontrol_crosshairtype.png)