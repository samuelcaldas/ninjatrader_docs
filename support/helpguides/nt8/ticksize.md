
NinjaScript > Language Reference > Common > Analytical > TickSize
TickSize
| << [Click to Display Table of Contents](ticksize.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Analytical](market_data.md) > TickSize | [Previous page](slope.md) [Return to chapter overview](market_data.md) [Next page](today.md) |
| --- | --- |
## Definition
The minimum fluctuation value which is always a value of 1-tick for the corresponding master instrument.

## Property Value
A double value that represents the minimum fluctuation of an instrument.
 
## Syntax
TickSize

| Warning:  This property should NOT be accessed during State.SetDefaults from within the [OnStateChange()](onstatechange.md) method, all bars series would be guaranteed to have loaded in State.DataLoaded |
| --- |

## Examples
| ns |
| --- |
| // Prints the ticksize to the output window Print("The ticksize of this instrument is " + TickSize);   // Prints the value of the current bar low less one tick size double value = Low[0] - TickSize; Print(value); |
