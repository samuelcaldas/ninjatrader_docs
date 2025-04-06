



GetAsk()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getask.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  GetAsk() | [Previous page](barssincenewtradingday-1.htm) [Return to chapter overview](bars-1.htm) [Next page](getbar-1.htm) |

Definition
----------

Returns the ask price value at a selected absolute bar index value.

|  |
| --- |
| Notes:    •This method does NOT return the current real-time asking price, but rather the historical / real-time asking price at the desired index.  For obtaining the current real-time asking price, please use [GetCurrentAsk](getcurrentask-1.htm)().  •This method returns expected values when 1 tick bid / ask stamped data is used and available from [your provider](data_by_provider-1.htm). |

Method Return Value
-------------------

A double value that represents the asking price at the desired bar index.

Syntax
------

Bars.GetAsk(int index)

Parameters
----------

|  |  |
| --- | --- |
| index | The absolute bar index value used |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // If the Highs of the two most recent bars are falling, place a long stop market order      // at the Ask price      if (High[0] < High[1] && High[1] < High[2])     {         EnterLongStopMarket(Bars.GetAsk(CurrentBar));     }  } |