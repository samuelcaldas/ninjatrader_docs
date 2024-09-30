
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Value
Value

| \<\< [Click to Display Table of Contents](value.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> [PriceSeries\<double\>](priceseries.md) \> Value | [Previous page](typicals.md) [Return to chapter overview](priceseries.md) [Next page](values.md) |
| --- | --- |

## Definition
A collection of historical references to the first ISeries object Values\[0] in the indicator. This is the primary indicator value (synched to the primary series in case of a [MultiSeries](multi-time_frame__instruments.md) indicator)
  
## Property Value
An ISeries\<double\> object.
 
## Syntax
Value
 
## 
## Examples
| ns |
| --- |
| // OnBarUpdate method of a custom indicator protected override void OnBarUpdate() {      // Ensures we have enough bars loaded for our indicator      if (CurrentBar \< 1)          return;        // Evaluates the indicator primary value 1 bar ago and sets the value of the indicator      // for the current bar being evaluated      if (Value\[1] \< High\[0] \- Low\[0])          Value\[0] \= High\[0] \- Low\[0];      else          Value\[0] \= High\[0] \- Close\[0]; } |

