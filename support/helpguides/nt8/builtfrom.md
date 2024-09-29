


NinjaScript \> Language Reference \> Bars Type \> BuiltFrom






















BuiltFrom







| \<\< [Click to Display Table of Contents](builtfrom.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Bars Type](bars_type.md) \> BuiltFrom | [Previous page](applydefaultvalue.md) [Return to chapter overview](bars_type.md) [Next page](defaultchartstyle.md) |
| --- | --- |











## Definition


Determines the base dataset used to build the BarsType (i.e., Tick, Minute, Day).   The BuiltFrom property will control the frequency in which [OnDataPoint()](ondatapoint.md) processes historical data.


 


## Property Value


A [BarsPeriodType](barsperiod.md) enum.  Values that will be recognized include:


 


•BarsPeriodType.Tick

•BarsPeriodType.Minute

•BarsPeriodType.Day

 




| Warning:  Using other bars period types (e.g., Range, Volume, or other custom bars types) is NOT supported.  The BarsPeriodType values mentioned above represent all of the fundamental data points needed to build a bar. |
| --- |



 


 


## Syntax


BuiltFrom


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name     \= "MyCustomBarsType";      BarsPeriod   \= new BarsPeriod { BarsPeriodType \= (BarsPeriodType) 15, BarsPeriodTypeName \= "MyCustomBarsType(15\)", Value \= 1 };      BuiltFrom   \= BarsPeriodType.Minute; // update OnDataPoint() every minute on historical data      DaysToLoad   \= 5;    }      else if (State \=\= State.Configure)    {    } } |









