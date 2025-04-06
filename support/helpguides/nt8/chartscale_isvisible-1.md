



IsVisible

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartscale_isvisible.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartScale](chartscale-1.htm) >  IsVisible | [Previous page](height-1.htm) [Return to chapter overview](chartscale-1.htm) [Next page](maxminusmin-1.htm) |

Definition
----------

Indicates if the chart scale is viewable on the UI.  If the bar series, indicator, or strategy which uses the chart scale is not in view, the chart scale IsVisible property will return false.

Property Value
--------------

A bool value, which when true the series used to build the scale is viewable; otherwise false.  This property is read-only.

Syntax
------

<chartScale>.IsVisible

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {              // do not process render info chart scale is not visible     if(!chartScale.IsVisible)       return;  } |