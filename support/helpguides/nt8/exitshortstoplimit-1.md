﻿


NinjaScript \> Language Reference \> Strategy \> Order Methods \> Managed Approach \> ExitShortStopLimit()






















ExitShortStopLimit()







| \<\< [Click to Display Table of Contents](exitshortstoplimit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Order Methods](order_methods-1.md) \> [Managed Approach](managed_approach-1.md) \> ExitShortStopLimit() | [Previous page](exitshortmit-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](exitshortstopmarket-1.md) |
| --- | --- |











## Definition


Generates a buy to cover stop limit order to exit a short position.


 


## Method Return Value


An [Order](order-1.md) read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](advanced_order_handling-1.md) section.   

 


Syntax  

ExitShortStopLimit(double limitPrice, double stopPrice)


ExitShortStopLimit(int quantity, double limitPrice, double stopPrice)   

ExitShortStopLimit(double limitPrice, double stopPrice, string fromEntrySignal)


ExitShortStopLimit(double limitPrice, double stopPrice, string signalName, string fromEntrySignal)


ExitShortStopLimit(int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)


 


The following method variation is for experienced programmers who fully understand [Advanced Order Handling](advanced_order_handling-1.md) concepts:


 


ExitShortStopLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)


## 


## Parameters




| signalName | User defined signal name identifying the order generated. Max 50 characters. |
| --- | --- |
| fromEntrySignal | The entry signal name. This ties the exit to the entry and exits the position quantity represented by the actual entry.    Note:  Using an empty string will attach the exit order to all entries. |
| limitPrice | The limit price of the order |
| stopPrice | The stop price of the order. |
| quantity | Entry order quantity. |
| isLiveUntilCancelled | The order will NOT expire at the end of a bar but instead remain live until the CancelOrder() method is called or its time in force is reached. |
| barsInProgressIndex | The index of the Bars object the order is to be submitted against. Used to determines what instrument the order is submitted for.      See the [BarsInProgress](barsinprogress-1.md) property. |



## 


## 


## Examples




| ns |
| --- |
| private double stopPrice \= 0;   protected override void OnBarUpdate() {      if (CurrentBar \< 20)          return;        // Only enter if at least 10 bars has passed since our last entry      if ((BarsSinceEntryExecution() \> 10 \|\| BarsSinceEntryExecution() \=\= \-1) \&\& CrossBelow(SMA(10), SMA(20), 1))      {          EnterShort("SMA Cross Entry");          stopPrice \= Low\[0] \+ 5 \* TickSize;      }        // Exits position      ExitShortStopLimit(stopPrice \+ (10 \* TickSize), stopPrice); } |



 


## 




| Tips (also see [Overview](managed_approach-1.md)): •This method is ignored if a short position does not exist •It is helpful to provide a signal name if your strategy has multiple exit points to help identify your exits on a chart •You can tie an exit to an entry by providing the entry signal name in the parameter "fromEntrySignal" •If you do not specify a quantity the entire position is exited rendering your strategy flat •If you do not specify a "fromEntrySignal" parameter the entire position is exited rendering your strategy flat |
| --- |









