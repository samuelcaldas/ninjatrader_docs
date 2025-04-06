



IsWaitUntilFlat

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\iswaituntilflat.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  IsWaitUntilFlat | [Previous page](istradinghoursbreaklinevisible-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](numberrestartattempts-1.htm) |

Definition
----------

Indicates the strategy is currently waiting until a flat position is detected before submitting live orders.

 

|  |
| --- |
| Note: This property would only apply if the strategy [StartBehavior](startbehavior-1.htm) was set to StartBehavior.WaitUntilFlat or StartBehavior.WaitUntilFlatSynchronizeAccount. |

Property Value
--------------

This property returns true if the strategy has detected it is either in a long or short position during [State.Transition](onstatechange-1.htm); otherwise false.  Default value is set to false.

Syntax
------

IsWaitUntilFlat

Examples
--------

|  |
| --- |
| ns |
| // If a strategy is waiting for a flat position, return and print a message  if (!IsWaitUntilFlat)  {      Print("This strategy is currently waiting for a flat account position to begin placing trades");     return;  } |