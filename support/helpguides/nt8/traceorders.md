


NinjaScript \> Language Reference \> Strategy \> TraceOrders






















TraceOrders







| \<\< [Click to Display Table of Contents](traceorders.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> TraceOrders | [Previous page](timeinforce.md) [Return to chapter overview](strategy.md) [Next page](trade.md) |
| --- | --- |











## Definition


Determines if OnOrderTrace() would be called for a given strategy.  When enabled, traces are generated and displayed in the [NinjaScript Output](output.md) window for each call of an [order method](order_methods.md) providing confirmation that the method is entered and providing information if order methods are ignored and why. This is valuable for debugging if you are not seeing expected behavior when calling an order method. This property can be set programatically in the [OnStateChange()](onstatechange.md) method.


   

The output will reference a method "PlaceOrder()" which is an internal method that all Enter() and Exit() methods use.


## 


## Property Value


This property returns true if the strategy will output trace information; otherwise, false.  Default value is false.


 


## Syntax


TraceOrders


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          TraceOrders \= true;      } } |



 




| Tips 1\.See [this](traceorders2.md) article for more examples of how to utilize this property.2\.You can override the default output by using OnOrderTrace() in your strategy. |
| --- |









