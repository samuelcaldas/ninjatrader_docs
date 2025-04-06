



IsRising()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](rising.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Analytical](market_data.htm) >  IsRising() | [Previous page](falling.htm) [Return to chapter overview](market_data.htm) [Next page](least_recent_occurence_lro.htm) |

Definition
----------

Evaluates a rising condition which is true when the current value is greater than the value of 1 bar ago.

Method Return Value
-------------------

This method returns true if a rising condition is present; otherwise, false.

Syntax 
IsRising(ISeries<double> series)
----------------------------------------

Parameters
----------

|  |  |
| --- | --- |
| series | Any Series<double> type object such as an indicator, Close, High, Low, etc... |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // If the 20 period SMA is rising (in uptrend) go long     if (IsRising(SMA(20)))         EnterLong();  } |