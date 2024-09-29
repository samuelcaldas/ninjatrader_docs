


NinjaScript \> Language Reference \> SuperDOM Column \> OnOrderUpdate()






















OnOrderUpdate()







| \<\< [Click to Display Table of Contents](superdomcolumn_onorderupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [SuperDOM Column](superdom_column.md) \> OnOrderUpdate() | [Previous page](superdomcolumn_onmarketdata.md) [Return to chapter overview](superdom_column.md) [Next page](superdomcolumn_onpositionupdate.md) |
| --- | --- |











## Definition


Called every time an [order](order.md) changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs.


 




| Note:  The OnOrderUpdate() method is called on ALL order updates (e.g., any account and instrument combination) and NOT just the specific items which are selected in the SuperDOM. |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax


protected override void OnOrderUpdate(OrderEventArgs orderUpdate)  

{  

   

}


 


## Method Parameters




| orderUpdate | An OrderEventArgs representing the change in order state |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnOrderUpdate(OrderEventArgs orderUpdate) {    // Do not take action if the order update does not come from the selected SuperDOM instrument/account    if (orderUpdate.Order.Instrument !\= SuperDom.Instrument \|\| orderUpdate.Order.Account !\= SuperDom.Account)      return;      // Do something } |









