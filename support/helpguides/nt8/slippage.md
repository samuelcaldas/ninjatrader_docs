


NinjaScript \> Language Reference \> Strategy \> Slippage






















Slippage







| \<\< [Click to Display Table of Contents](slippage.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> Slippage | [Previous page](setorderquantity.md) [Return to chapter overview](strategy.md) [Next page](startbehavior.md) |
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









