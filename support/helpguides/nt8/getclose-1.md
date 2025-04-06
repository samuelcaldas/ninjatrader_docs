



GetClose()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getclose.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  GetClose() | [Previous page](getbid-1.htm) [Return to chapter overview](bars-1.htm) [Next page](getdaybar-1.htm) |

Definition
----------

Returns the closing price at the current bar index value.

Method Return Value
-------------------

A double value that represents the close price at the desired bar index.

Syntax
------

Bars.GetClose(int index)

Parameters
----------

|  |  |
| --- | --- |
| index | An int representing an absolute bar index value |

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     base.OnRender(chartControl, chartScale);     // loop through only the rendered bars on the chart     for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)     {       // get the close price at the selected bar index value       double closePrice = Bars.GetClose(barIndex);       Print("Bar #" + barIndex + " closing price is " + closePrice);     }  } |