


NinjaScript \> Language Reference \> Common \> Analytical \> IsFalling()






















IsFalling()







| \<\< [Click to Display Table of Contents](falling.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> IsFalling() | [Previous page](highestbar.md) [Return to chapter overview](market_data.md) [Next page](rising.md) |
| --- | --- |











## Definition


Evaluates a falling condition which is true when the current value is less than the value of 1 bar ago. 


## 


## Method Return Value


This method returns true if a falling condition is present; otherwise, false.


 


Syntax  

IsFalling(ISeries\<double\> series)


## 


## Parameters




| series | Any Series\<double\> type object such as an indicator, Close, High, Low, etc... |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // If the 20 period SMA is falling (in downtrend) go short    if (IsFalling(SMA(20)))        EnterShort();                } |









