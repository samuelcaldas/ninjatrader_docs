


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> Indicators






















Indicators







| \<\< [Click to Display Table of Contents](chartcontrol_indicators.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartControl](chartcontrol.md) \> Indicators | [Previous page](getxbytime.md) [Return to chapter overview](chartcontrol.md) [Next page](isscrollarrowvisible.md) |
| --- | --- |











## Definition


Contains a collection of indicators currently configured on the chart.


## 


## Property Value


A ChartObjectCollection of NinjaTrader.Gui.NinjaScript.IndicatorRenderBase objects representing the indicators on the chart


 


## Syntax


\<ChartControl\>.Indicators


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Instantiate a ChartObjectCollection to hold chartControl.Indicators    ChartObjectCollection\<NinjaTrader.Gui.NinjaScript.IndicatorRenderBase\> indicatorCollection \= chartControl.Indicators;      // Print the Calculate setting for any configured indicators not using Calculate.OnBarClose    foreach (NinjaTrader.Gui.NinjaScript.IndicatorRenderBase indicator in indicatorCollection)    {        if(indicator.Calculate !\= Calculate.OnBarClose)            Print(String.Format("{0} is using Calculate.{1}", indicator.Name, indicator.Calculate.ToString()));    } } |









