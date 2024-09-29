


NinjaScript \> Language Reference \> Strategy \> AddChartIndicator()






















AddChartIndicator()







| \<\< [Click to Display Table of Contents](addchartindicator.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> AddChartIndicator() | [Previous page](strategy_account-1.md) [Return to chapter overview](strategy-1.md) [Next page](addperformancemetric-1.md) |
| --- | --- |











## Definition


Adds an indicator to the strategy only for the purpose of displaying it on a chart.


 




| Notes:  •Only the Plot properties of an indicator added by AddChartIndicator() will be accessible in the Indicators dialogue on charts. Other properties must be set in code.•To add Bars objects to your strategy for calculation purposes see the [AddDataSeries()](adddataseries-1.md) method.•An indicator being added via AddChartIndicator() cannot use any additional data series hosted by the calling strategy, but can only use the strategy's primary data series. If you wish to use a different data series for the indicator's input, you can add the series in the indicator itself and explicitly reference it in the indicator code (please make sure though the hosting strategy has the same [AddDataSeries()](adddataseries-1.md) call included as well)o If a secondary or null Bars series is specified by the calling strategy (not the indicator itself), the strategy's primary series will be substituted instead.•Dynamically using [DrawOnPricePanel](drawonpricepanel-1.md) in an indicator outside of State.SetDefaults may show issues when working with that indicator through a hosting strategy via [AddChartIndicator()](addchartindicator-1.md). |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax
AddChartIndicator(IndicatorBase indicator)


 




| Warning:  This method should ONLY be called from the [OnStateChange()](onstatechange-1.md) method during State.DataLoaded |
| --- |



 


 


## Parameters




| indicator | An indicator object |
| --- | --- |



## 


## 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.DataLoaded)      {          // Charts a 20 period simple moving average to the chart          AddChartIndicator(SMA(20));      } } |



 


 




| Tip:  If you are adding an indicator which is dependent on the correct [State](state-1.md) of the indicator, you will need to ensure that you are also calling the indicator from the strategy in [OnBarUpdate()](onbarupdate-1.md), otherwise your indicator will only process in State.RealTime for performance optimizations. |
| --- |



 


 




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.DataLoaded)    {      // Charts a 20 period simple moving average to the chart      AddChartIndicator(SMA(20));    } }   protected override void OnBarUpdate() {       // call SMA() historically to ensure the indicator processes its historical states as well    double sma \= SMA(20)\[0]; } |









