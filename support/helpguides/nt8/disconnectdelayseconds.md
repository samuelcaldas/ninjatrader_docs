


NinjaScript \> Language Reference \> Strategy \> DisconnectDelaySeconds






















DisconnectDelaySeconds







| \<\< [Click to Display Table of Contents](disconnectdelayseconds.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> DisconnectDelaySeconds | [Previous page](defaultquantity.md) [Return to chapter overview](strategy.md) [Next page](entriesperdirection.md) |
| --- | --- |











## Definition


Determines the amount of time a disconnect would have to last before [connection loss handling](connectionlosshandling.md) takes action. 


 


## Property Value


An int value represents the time required for a disconnect to last before connection loss handling actions will occur.  Default value is 10\.


 


## Syntax


DisconnectDelaySeconds


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Disconnect has to be at least 10 seconds          DisconnectDelaySeconds \= 10;      } } |









