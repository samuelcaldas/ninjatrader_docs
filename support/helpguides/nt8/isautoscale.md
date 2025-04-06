



IsAutoScale

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](isautoscale.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) >  IsAutoScale | [Previous page](formatpricemarker.htm) [Return to chapter overview](chart.htm) [Next page](isoverlay.htm) |

Definition
----------

If true, the object will call [CalculateMinMax()](oncalculateminmax.htm) in order to determine the object's [MinValue](minvalue.htm) and [MaxValue](maxvalue.htm) value used to scale the Y-axis of the chart.

Property Value
--------------

This property returns true if the object's are included in the y-scale; otherwise, false. Default set to false for [DrawingTools](drawing_tools.htm), but set to true for [Indicators](indicator.htm).

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.htm) method during State.SetDefaults or State.Configure |

Syntax
------

IsAutoScale

Example
-------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {                Name                 = "Example Indicator";                // set this to true to call CalculateMinMix() to ensure drawing tool is fully rendered in chart scale       IsAutoScale = true;       }     else if (State == State.Configure)     {     }  } |