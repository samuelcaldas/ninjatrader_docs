
NinjaScript > Language Reference > Common > ISeries<T> > PriceSeries<double> > Close

Close
| << [Click to Display Table of Contents](close.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [ISeries<T>](iseriest.md) > [PriceSeries<double>](priceseries.md) > Close | [Previous page](priceseries.md) [Return to chapter overview](priceseries.md) [Next page](closes.md) |
| --- | --- |
## Definition
A collection of historical bar close prices.
 
## Property Value
A ISeries<double> type object. Accessing this property via an index value [int barsAgo] returns a double value representing the price of the referenced bar.
 
| Note: When an indicator uses another indicator as input series, Close will represent the closing price of the input series' input series. For example, if MyCustomIndicator uses an ADX as input series, then referencing Close[0] in MyCustomIndicator will provide the Close price for the ADX's input series. |
| --- |

 
## Syntax
Close  

Close[int barsAgo]
## 
## 
## Examples
| ns |
| --- |
| // OnBarUpdate method protected override void OnBarUpdate() {      // Evaluates if the current close is greater than the prior bar close      if (Close[0] > Close[1])          Print("We had an up day"); } |
