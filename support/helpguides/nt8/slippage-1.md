
NinjaScript \> Language Reference \> Strategy \> Slippage

Slippage

| \<\< [Click to Display Table of Contents](slippage.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> Slippage | [Previous page](setorderquantity-1.md) [Return to chapter overview](strategy-1.md) [Next page](startbehavior-1.md) |
| --- | --- |
## Definition
Sets the amount of slippage in ticks per execution used in performance calculations during backtests.
 
## Property Value
An int value representing the number ticks.  Default value is set to 0\.
 
## Syntax
Slippage

## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          Slippage \= 2;       } } |
