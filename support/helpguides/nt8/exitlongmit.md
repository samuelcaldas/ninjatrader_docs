


NinjaScript \> Language Reference \> Strategy \> Order Methods \> Managed Approach \> ExitLongMIT()






















ExitLongMIT()







| \<\< [Click to Display Table of Contents](exitlongmit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [Order Methods](order_methods.md) \> [Managed Approach](managed_approach.md) \> ExitLongMIT() | [Previous page](exitlonglimit.md) [Return to chapter overview](managed_approach.md) [Next page](exitlongstoplimit.md) |
| --- | --- |











## Definition


Generates a sell MIT order to exit a long position.


## 


## Method Return Value


An [Order](order.md) read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](advanced_order_handling.md) section.   

 


Syntax  

ExitLongMIT(double stopPrice)


ExitLongMIT(int quantity, double stopPrice)   

ExitLongMIT(double stopPrice, string fromEntrySignal)


ExitLongMIT(double stopPrice, string signalName, string fromEntrySignal)


ExitLongMIT(int quantity, double stopPrice, string signalName, string fromEntrySignal)


 


The following method variation is for experienced programmers who fully understand [Advanced Order Handling](advanced_order_handling.md) concepts:


 


ExitLongMIT(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName, string fromEntrySignal)


 


## Parameters




| signalName | User defined signal name identifying the order generated. Max 50 characters. |
| --- | --- |
| fromEntrySignal | The entry signal name. This ties the exit to the entry and exits the position quantity represented by the actual entry.    Note:  Using an empty string will attach the exit order to all entries. |
| stopPrice | The stop price of the order. |
| quantity | Entry order quantity. |
| isLiveUntilCancelled | The order will NOT expire at the end of a bar but instead remain live until the CancelOrder() method is called or its time in force is reached. |
| barsInProgressIndex | The index of the Bars object the order is to be submitted against. Used to determines what instrument the order is submitted for.      See the [BarsInProgress](barsinprogress.md) property. |



## 


## 


## Examples




| ns |
| --- |
| private double stopPrice \= 0;   protected override void OnBarUpdate() {      if (CurrentBar \< 20)          return;        // Only enter if at least 10 bars has passed since our last entry      if ((BarsSinceEntryExecution() \> 10 \|\| BarsSinceEntryExecution() \=\= \-1) \&\& CrossAbove(SMA(10), SMA(20), 1))      {          EnterLong("SMA Cross Entry");          stopPrice \= High\[0];      }        // Exits position      ExitLongMIT(stopPrice); } |



 


 




| Tips (also see [Overview](managed_approach.md)): •This method is ignored if a long position does not exist •It is helpful to provide a signal name if your strategy has multiple exit points to help identify your exits on a chart •You can tie an exit to an entry by providing the entry signal name in the parameter "fromEntrySignal" •If you do not specify a quantity the entire position is exited rendering your strategy flat •If you do not specify a "fromEntrySignal" parameter the entire position is exited rendering your strategy flat |
| --- |









