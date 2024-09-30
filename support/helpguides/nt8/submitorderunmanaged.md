
NinjaScript \> Language Reference \> Strategy \> Order Methods \> Unmanaged Approach \> SubmitOrderUnmanaged()
SubmitOrderUnmanaged()

| \<\< [Click to Display Table of Contents](submitorderunmanaged.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [Order Methods](order_methods.md) \> [Unmanaged Approach](unmanaged_approach.md) \> SubmitOrderUnmanaged() | [Previous page](isunmanaged.md) [Return to chapter overview](unmanaged_approach.md) [Next page](orderfillresolution.md) |
| --- | --- |

## Definition
Generates an [Unmanaged](isunmanaged.md) order.
 
## Method Return Value
An [Order](order.md) read\-only object that represents the order. Reserved for experienced programmers, additional information can be found within the [Unmanaged Approach](unmanaged_approach.md) section.
## 
## Syntax
SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity)  

SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice)  

SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice)  

SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice, string oco)  

SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice, string oco, string signalName)

## Parameters
| selectedBarsInProgress | The index of the Bars object the order is to be submitted against. This determines what instrument the order is submitted for.   Note:  See the [BarsInProgress](barsinprogress.md) property. |
| --- | --- |
| orderAction | Determines if the order is a buy or sell order   Possible values:   OrderAction.Buy OrderAction.BuyToCover OrderAction.Sell OrderAction.SellShort |
| orderType | Determines the type of order submitted    Possible values:   OrderType.Limit OrderType.Market OrderType.MIT OrderType.StopMarket OrderType.StopLimit |
| quantity | Sets the number of contracts to submit with the order |
| limitPrice | Order limit price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |
| stopPrice | Order stop price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |
| oco | A string representing the OCO ID used to link OCO orders together    Note:  OCO strings should not be reused.  Use unique strings for each OCO group, and reset after orders in that group are filled/canceled |
| signalName | A string representing the name of the order. Max 50 characters. |

## Examples
| ns |
| --- |
| private Order entryOrder \= null;   protected override void OnBarUpdate() {      // Entry condition      if (Close\[0] \> SMA(20)\[0] \&\& entryOrder \=\= null)          SubmitOrderUnmanaged(0, OrderAction.Buy, OrderType.Market, 1, 0, 0, "", "Enter Long"); }   protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError) {    // Assign entryOrder in OnOrderUpdate() to ensure the assignment occurs when expected.    // This is more reliable than assigning Order objects in OnBarUpdate, as the assignment is not gauranteed to be complete if it is referenced immediately after submitting    if (order.Name \=\= "Enter Long" \&\& orderState \=\= OrderState.Filled)        entryOrder \= order; } |

