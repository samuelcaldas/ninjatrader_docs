



IsChartOnly

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ischartonly.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Indicator](indicator-1.htm) >  IsChartOnly | [Previous page](indicatorbaseconverter-1.htm) [Return to chapter overview](indicator-1.htm) [Next page](issuspendedwhileinactive-1.htm) |

Definition
----------

If true, any indicator will be only available for charting usage - indicators with this property enabled would for example not be expected to show if called in a SuperDOM or MarketAnalyzer window.

Property Value
--------------

This property returns true if the indicator can only be used on a chart; otherwise, false. Default set to false.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults or State.Configure |

Syntax
------

IsChartOnly

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           IsChartOnly = true; // Allow the indicator to work in charting environment only             }  } |