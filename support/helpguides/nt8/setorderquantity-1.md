
NinjaScript \> Language Reference \> Strategy \> SetOrderQuantity

SetOrderQuantity

| \<\< [Click to Display Table of Contents](setorderquantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> SetOrderQuantity | [Previous page](restartswithinminutes-1.md) [Return to chapter overview](strategy-1.md) [Next page](slippage-1.md) |
| --- | --- |
## Definition
Determines how order sizes are calculated for a given strategy.
 
## Property Value
An enum determining how order quantities are set.  Default value is set to SetOrderQuantity.Strategy. 
 
Possible values are:

| SetOrderQuantity.DefaultQuantity | User defined order size based on the [DefaultQuantity](defaultquantity-1.md) property |
| --- | --- |
| SetOrderQuantity.Strategy | Takes the order size specified programmatically within the strategy |
## 

| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |
## 
 
## Syntax
SetOrderQuantity
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          SetOrderQuantity \= SetOrderQuantity.DefaultQuantity; // calculate orders based off default size      } } |
