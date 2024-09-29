


NinjaScript \> Language Reference \> SuperDOM Column \> OnPositionUpdate()






















OnPositionUpdate()







| \<\< [Click to Display Table of Contents](superdomcolumn_onpositionupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [SuperDOM Column](superdom_column-1.md) \> OnPositionUpdate() | [Previous page](superdomcolumn_onorderupdate-1.md) [Return to chapter overview](superdom_column-1.md) [Next page](onpropertychanged-1.md) |
| --- | --- |











## Definition


Called every time a [position](position-1.md) changes state.


 




| Note:  The OnPositionUpdate() method is called on ALL position updates (e.g., any account and instrument combination) and NOT just the specific items which are selected in the SuperDOM. |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax


protected override void OnPositionUpdate(PositionEventArgs positionUpdate)  

{


   

}


 


## Method Parameters




| positionUpdate | A PositionEventArgs representing the change in position |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnPositionUpdate(PositionEventArgs positionUpdate) {    // Do not take action if the position update does not come from the selected SuperDOM instrument/account    if (positionUpdate.Position.Instrument !\= SuperDom.Instrument       \|\| positionUpdate.Position.Account !\= SuperDom.Account)      return;      // Do something          } |









