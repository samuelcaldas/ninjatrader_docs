


NinjaScript \> Language Reference \> Strategy \> ExitOnSessionCloseSeconds






















ExitOnSessionCloseSeconds







| \<\< [Click to Display Table of Contents](exitonsessioncloseseconds.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> ExitOnSessionCloseSeconds | [Previous page](execution.md) [Return to chapter overview](strategy.md) [Next page](includecommission.md) |
| --- | --- |











## Definition


The number of seconds before the actual session end time that the "[IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy.md)" function will trigger. 


The time from which this property will be calculated is taken from the [Trading Hours](trading_hours.md) EOD property set in the strategy's Trading Hours template. The ExitOnSessionCloseSeconds property can either be set programatically in the [OnStateChange()](onstatechange.md) method or be driven by the UI at run time.


 




| Note: This is a real\-time only property, it will not have any effect on your ExitOnSessionClose time in backtesting processing historical data. |
| --- |



## 


## Property Value


An int representing the number of seconds.  Default value is 30\.


 




| Warning: This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



## 


## 


## Syntax


ExitOnSessionCloseSeconds


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Triggers the exit on close function 30 seconds prior to trading day end           IsExitOnSessionCloseStrategy \= true;          ExitOnSessionCloseSeconds \= 30;      } } |









