



GetOpen()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getopen.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  GetOpen() | [Previous page](getlow-1.htm) [Return to chapter overview](bars-1.htm) [Next page](getsessionendtime-1.htm) |

Definition
----------

Returns the open price at the selected bar index value.

Method Return Value
-------------------

A double value that represents the open price at the desired bar index.

Syntax
------

Bars.GetOpen(int index)

Parameters
----------

|  |  |
| --- | --- |
| index | An int representing an absolute bar index value |

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     base.OnRender(chartControl, chartScale);     // loop through only the rendered bars on the chart     for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)     {       // get the open price at the selected bar index value       double openPrice = Bars.GetOpen(barIndex);       Print("Bar #" + barIndex + " open price is " + openPrice);     }  } |