



IsFirstBarOfSessionByIndex()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isfirstbarofsessionbyindex.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  IsFirstBarOfSessionByIndex() | [Previous page](isfirstbarofsession-1.htm) [Return to chapter overview](bars-1.htm) [Next page](islastbarofsession-1.htm) |

Definition
----------

Indicates if the selected bar index value is the first bar of a trading session.

 

Property Value
--------------

This property returns true if the bar is the first bar of a session; otherwise, false.  This property is read-only.

Syntax 
Bars.IsFirstBarOfSessionByIndex(int index)
--------------------------------------------------

|  |
| --- |
| Warning:   This property will always return false on non-intraday bar periods (e.g., Day, Month, etc) |

Parameters
----------

|  |  |
| --- | --- |
| index | An int representing an absolute bar index value |

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     base.OnRender(chartControl, chartScale);     //  loop through only the rendered bars on the chart      for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)     {       // check if the rendered bar is the first bar of the trading session       if (Bars.IsFirstBarOfSessionByIndex(barIndex))       {           DateTime slotTimeAtBarIndex = chartControl.GetTimeBySlotIndex(barIndex);           Print(string.Format("Bar index {0} was the first bar of the session at slot time {1}.", barIndex, slotTimeAtBarIndex));       }     }  } |