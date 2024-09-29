


NinjaScript \> Language Reference \> Strategy \> Order Methods \> Managed Approach \> ChangeOrder()






















ChangeOrder()







| \<\< [Click to Display Table of Contents](managed_changeorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Order Methods](order_methods-1.md) \> [Managed Approach](managed_approach-1.md) \> ChangeOrder() | [Previous page](managed_cancelorder-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](enterlong-1.md) |
| --- | --- |











## Definition


Amends a specified [Order](order-1.md).


 




| Note: This method is only relevant for Managed orders with IsLiveUntilCancelled set to true and Unmanaged orders. |
| --- |



 


 


## Syntax


ChangeOrder(Order order, int quantity, double limitPrice, double stopPrice)


 




| Warning:  If you have existing historical [order](order-1.md) references which have transitioned to real\-time, you MUST update the order object reference to the newly submitted real\-time order; otherwise errors may occur as you attempt to change the order.  You may use the [GetRealtimeOrder()](getrealtimeorder-1.md) helper method to assist in this transition. |
| --- |



 


 


## Parameters




| order | [Order object](order-1.md) of the order you wish to amend |
| --- | --- |
| quantity | Order quantity |
| limitPrice | Order limit price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |
| stopPrice | Order stop price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |



 


## 


## Examples




| ns |
| --- |
| private Order stopOrder \= null;   protected override void OnBarUpdate() {      // Raise stop loss to breakeven when you are at least 4 ticks in profit      if (stopOrder !\= null \&\& stopOrder.StopPrice \< Position.AveragePrice \&\& Close\[0] \>\= Position.AveragePrice \+ 4 \* TickSize)          ChangeOrder(stopOrder, stopOrder.Quantity, 0, Position.AveragePrice); } |









