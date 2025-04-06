



DisconnectDelaySeconds

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](disconnectdelayseconds.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) >  DisconnectDelaySeconds | [Previous page](defaultquantity.htm) [Return to chapter overview](strategy.htm) [Next page](entriesperdirection.htm) |

Definition
----------

Determines the amount of time a disconnect would have to last before [connection loss handling](connectionlosshandling.htm) takes action.

Property Value
--------------

An int value represents the time required for a disconnect to last before connection loss handling actions will occur.  Default value is 10.

Syntax
------

DisconnectDelaySeconds

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           // Disconnect has to be at least 10 seconds           DisconnectDelaySeconds = 10;       }  } |