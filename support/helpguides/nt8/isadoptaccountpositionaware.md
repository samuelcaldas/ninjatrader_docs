
NinjaScript > Language Reference > Strategy > IsAdoptAccountPositionAware
IsAdoptAccountPositionAware
| << [Click to Display Table of Contents](isadoptaccountpositionaware.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > IsAdoptAccountPositionAware | [Previous page](includetradehistoryinbacktest.md) [Return to chapter overview](strategy.md) [Next page](isexitonsessionclosestrategy.md) |
| --- | --- |
## Definition
Determines if the strategy is programmed in a manner capable of handling  real-world account positions. Once set to true, your strategy's "[Start behavior](startbehavior.md)" options will include an additional parameter named "Adopt account position" which can bet set at run-time.  Only set to true if you have specifically programmed your strategy to be able to adopt account positions. 
 
## Property Value
This property returns true if the strategy can adopt account positions; otherwise, false. Default is set to false.
 
| Note:  This property should ONLY be set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults. |
| --- |

## 
## Syntax
IsAdoptAccountPositionAware

## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          IsAdoptAccountPositionAware = true;      } } |
