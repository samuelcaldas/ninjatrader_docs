


NinjaScript \> Language Reference \> Common \> Analytical \> TickSize






















TickSize







| \<\< [Click to Display Table of Contents](ticksize.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Analytical](market_data-1.md) \> TickSize | [Previous page](slope-1.md) [Return to chapter overview](market_data-1.md) [Next page](today-1.md) |
| --- | --- |











## Definition


The minimum fluctuation value which is always a value of 1\-tick for the corresponding master instrument.


 


 


## Property Value


A double value that represents the minimum fluctuation of an instrument.


 


## Syntax


TickSize


 


 




| Warning:  This property should NOT be accessed during State.SetDefaults from within the [OnStateChange()](onstatechange-1.md) method, all bars series would be guaranteed to have loaded in State.DataLoaded |
| --- |



 


 


## Examples




| ns |
| --- |
| // Prints the ticksize to the output window Print("The ticksize of this instrument is " \+ TickSize);   // Prints the value of the current bar low less one tick size double value \= Low\[0] \- TickSize; Print(value); |









