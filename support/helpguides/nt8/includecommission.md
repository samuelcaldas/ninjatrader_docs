


NinjaScript \> Language Reference \> Strategy \> IncludeCommission






















IncludeCommission







| \<\< [Click to Display Table of Contents](includecommission.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> IncludeCommission | [Previous page](exitonsessioncloseseconds.md) [Return to chapter overview](strategy.md) [Next page](includetradehistoryinbacktest.md) |
| --- | --- |











## Definition


Determines if the strategy performance results will include commission on a historical backtest. When true, the [Commission Template](understanding_commissions.md) applied to the account on which the strategy is running will be used.


 


## Property Value


A bool value which returns true if the strategy includes commission on a historical backtest; otherwise, false.  Default value is set to false.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IncludeCommission


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IncludeCommission \= true;      } } |









