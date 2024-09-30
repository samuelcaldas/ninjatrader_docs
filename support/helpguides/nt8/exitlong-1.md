
NinjaScript \> Language Reference \> Strategy \> Order Methods \> Managed Approach \> ExitLong()
ExitLong()
| \<\< [Click to Display Table of Contents](exitlong.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Order Methods](order_methods-1.md) \> [Managed Approach](managed_approach-1.md) \> ExitLong() | [Previous page](entershortstopmarket-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](exitlonglimit-1.md) |
| --- | --- |
## Definition
Generates a sell market order to exit a long position.
 
## Method Return Value
An [Order](order-1.md) read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](advanced_order_handling-1.md) section.   

 
Syntax  

ExitLong()
ExitLong(int quantity)   

ExitLong(string fromEntrySignal)
ExitLong(string signalName, string fromEntrySignal)
ExitLong(int quantity, string signalName, string fromEntrySignal)
 
The following method variation is for experienced programmers who fully understand [Advanced Order Handling](advanced_order_handling-1.md) concepts:
 
ExitLong(int barsInProgressIndex, int quantity, string signalName, string fromEntrySignal)

## Parameters
| signalName | User defined signal name identifying the order generated. Max 50 characters. |
| --- | --- |
| fromEntrySignal | The entry signal name. This ties the exit to the entry and exits the position quantity represented by the actual entry.    Note:  Using an empty string will attach the exit order to all entries. |
| quantity | Entry order quantity. |
| barsInProgressIndex | The index of the Bars object the order is to be submitted against. Used to determines what instrument the order is submitted for.      See the [BarsInProgress](barsinprogress-1.md) property. |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      if (CurrentBar \< 20)          return;        // Only enter if at least 10 bars has passed since our last entry      if ((BarsSinceEntryExecution() \> 10 \|\| BarsSinceEntryExecution() \=\= \-1) \&\& CrossAbove(SMA(10), SMA(20), 1))          EnterLong("SMA Cross Entry");        // Exits position      if (CrossBelow(SMA(10), SMA(20), 1))          ExitLong(); } |
 
| Tips (also see [Overview](managed_approach-1.md)): - This method is ignored if a long position does not exist - It is helpful to provide a signal name if your strategy has multiple exit points to help identify your exits on a chart - You can tie an exit to an entry by providing the entry signal name in the parameter "fromEntrySignal" - If you do not specify a quantity the entire position is exited rendering your strategy flat - If you do not specify a "fromEntrySignal" parameter the entire position is exited rendering your strategy flat |
| --- |

