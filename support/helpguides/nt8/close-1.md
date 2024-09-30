
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Close
Close

| \<\< [Click to Display Table of Contents](close.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [PriceSeries\<double\>](priceseries-1.md) \> Close | [Previous page](priceseries-1.md) [Return to chapter overview](priceseries-1.md) [Next page](closes-1.md) |
| --- | --- |

## Definition
A collection of historical bar close prices.
 
## Property Value
A ISeries\<double\> type object. Accessing this property via an index value \[int barsAgo] returns a double value representing the price of the referenced bar.
 
| Note: When an indicator uses another indicator as input series, Close will represent the closing price of the input series' input series. For example, if MyCustomIndicator uses an ADX as input series, then referencing Close\[0] in MyCustomIndicator will provide the Close price for the ADX's input series. |
| --- |

 
## Syntax
Close  

Close\[int barsAgo]
## 
## 
## Examples
| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {      // Evaluates if the current close is greater than the prior bar close      if (Close\[0] \> Close\[1])          Print("We had an up day"); } |

