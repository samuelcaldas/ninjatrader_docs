


NinjaScript \> Language Reference \> Strategy \> IncludeCommission






















IncludeCommission







| \<\< [Click to Display Table of Contents](includecommission.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> IncludeCommission | [Previous page](exitonsessioncloseseconds-1.md) [Return to chapter overview](strategy-1.md) [Next page](includetradehistoryinbacktest-1.md) |
| --- | --- |











## Definition


Determines if the strategy performance results will include commission on a historical backtest. When true, the [Commission Template](understanding_commissions-1.md) applied to the account on which the strategy is running will be used.


 


## Property Value


A bool value which returns true if the strategy includes commission on a historical backtest; otherwise, false.  Default value is set to false.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IncludeCommission


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IncludeCommission \= true;      } } |









