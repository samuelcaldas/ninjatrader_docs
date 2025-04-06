



Indicators

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\chartcontrol_indicators.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartControl](chartcontrol-1.htm) >  Indicators | [Previous page](getxbytime-1.htm) [Return to chapter overview](chartcontrol-1.htm) [Next page](isscrollarrowvisible-1.htm) |

Definition
----------

Contains a collection of indicators currently configured on the chart.

Property Value
--------------

A ChartObjectCollection of NinjaTrader.Gui.NinjaScript.IndicatorRenderBase objects representing the indicators on the chart

Syntax
------

<ChartControl>.Indicators

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Instantiate a ChartObjectCollection to hold chartControl.Indicators     ChartObjectCollection<NinjaTrader.Gui.NinjaScript.IndicatorRenderBase> indicatorCollection = chartControl.Indicators;        // Print the Calculate setting for any configured indicators not using Calculate.OnBarClose     foreach (NinjaTrader.Gui.NinjaScript.IndicatorRenderBase indicator in indicatorCollection)     {         if(indicator.Calculate != Calculate.OnBarClose)             Print(String.Format("{0} is using Calculate.{1}", indicator.Name, indicator.Calculate.ToString()));     }  } |