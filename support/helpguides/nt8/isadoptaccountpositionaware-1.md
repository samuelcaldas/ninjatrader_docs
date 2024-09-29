


NinjaScript \> Language Reference \> Strategy \> IsAdoptAccountPositionAware






















IsAdoptAccountPositionAware







| \<\< [Click to Display Table of Contents](isadoptaccountpositionaware.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> IsAdoptAccountPositionAware | [Previous page](includetradehistoryinbacktest-1.md) [Return to chapter overview](strategy-1.md) [Next page](isexitonsessionclosestrategy-1.md) |
| --- | --- |











## Definition


Determines if the strategy is programmed in a manner capable of handling  real\-world account positions. Once set to true, your strategy's "[Start behavior](startbehavior-1.md)" options will include an additional parameter named "Adopt account position" which can bet set at run\-time.  Only set to true if you have specifically programmed your strategy to be able to adopt account positions. 


 


## Property Value


This property returns true if the strategy can adopt account positions; otherwise, false. Default is set to false.


 




| Note:  This property should ONLY be set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults. |
| --- |



## 


## Syntax


IsAdoptAccountPositionAware


 


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsAdoptAccountPositionAware \= true;      } } |









