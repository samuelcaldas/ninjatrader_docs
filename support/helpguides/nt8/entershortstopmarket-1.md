
NinjaScript > Language Reference > Strategy > Order Methods > Managed Approach > EnterShortStopMarket()
EnterShortStopMarket()
| << [Click to Display Table of Contents](entershortstopmarket.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [Order Methods](order_methods-1.md) > [Managed Approach](managed_approach-1.md) > EnterShortStopMarket() | [Previous page](entershortstoplimit-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](exitlong-1.md) |
| --- | --- |
## Definition
Generates a sell short stop order to enter a short position.
 
## Method Return Value
An [Order](order-1.md) read-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Advanced Order Handling](advanced_order_handling-1.md) section.   

 
Syntax  

EnterShortStopMarket(double stopPrice)   

EnterShortStopMarket(double stopPrice, string signalName)
EnterShortStopMarket(int quantity, double stopPrice)
EnterShortStopMarket(int quantity, double stopPrice, string signalName)
 
The following method variation is for experienced programmers who fully understand [Advanced Order Handling](advanced_order_handling-1.md) concepts:
 
EnterShortStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName) 

| Note: If using a method signature that does not have the parameter quantity, the order quantity will be taken from the quantity value set in the strategy dialog window when running or backtesting a strategy |
| --- |
## 
## 
## Parameters
| signalName | User defined signal name identifying the order generated. Max 50 characters. |
| --- | --- |
| stopPrice | The stop price of the order. |
| quantity | Entry order quantity (if 0 is passed in, will be set to 1, except for stocks 100). |
| isLiveUntilCancelled | The order will NOT expire at the end of a bar, but instead remain live until the [CancelOrder()](managed_cancelorder-1.md) method is called or its time in force is reached. |
| barsInProgressIndex | The index of the Bars object the order is to be submitted against. Used to determines what instrument the order is submitted for.      See the [BarsInProgress](barsinprogress-1.md) property. |
 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      if (CurrentBar < 20)          return;        // Only enter if at least 10 bars has passed since our last entry      if ((BarsSinceEntryExecution() > 10 || BarsSinceEntryExecution() == -1) && CrossAbove(SMA(10), SMA(20), 1))          EnterShortStopMarket(GetCurrentBid() - TickSize, "SMA Cross Entry"); } |
 

