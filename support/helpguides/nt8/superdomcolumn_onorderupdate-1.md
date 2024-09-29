


NinjaScript \> Language Reference \> SuperDOM Column \> OnOrderUpdate()






















OnOrderUpdate()







| \<\< [Click to Display Table of Contents](superdomcolumn_onorderupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [SuperDOM Column](superdom_column-1.md) \> OnOrderUpdate() | [Previous page](superdomcolumn_onmarketdata-1.md) [Return to chapter overview](superdom_column-1.md) [Next page](superdomcolumn_onpositionupdate-1.md) |
| --- | --- |











## Definition


Called every time an [order](order-1.md) changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs.


 




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









