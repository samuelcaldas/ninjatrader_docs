
NinjaScript \> Language Reference \> Strategy \> IsFillLimitOnTouch

IsFillLimitOnTouch

| \<\< [Click to Display Table of Contents](isfilllimitontouch.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> IsFillLimitOnTouch | [Previous page](isexitonsessionclosestrategy.md) [Return to chapter overview](strategy.md) [Next page](isinstantiatedoneachoptimizationiteration.md) |
| --- | --- |
## Definition
Determines if the strategy will use a more liberal fill algorithm for back\-testing purposes only.  The default behavior of the strategy's fill algorithm is to fill a limit order once price has penetrated the limit price.  However this behavior can be changed by setting IsFillLimitOnTouch to true, in which case the strategy's fill algorithm will consider a limit order filled once price has reached the limit price, but does not necessarily need to trade through the limit price
 
## Property Value
This property returns true if the strategy will fill limit orders when touched; otherwise, false. Default is set to false.
 

| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |
## 
## Syntax
IsFillLimitOnTouch
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsFillLimitOnTouch \= true;      } } |
