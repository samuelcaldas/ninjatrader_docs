


NinjaScript \> Language Reference \> Bars Type \> ApplyDefaultBasePeriodValue






















ApplyDefaultBasePeriodValue()







| \<\< [Click to Display Table of Contents](applydefaultbaseperiodvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Bars Type](bars_type.md) \> ApplyDefaultBasePeriodValue() | [Previous page](addbar.md) [Return to chapter overview](bars_type.md) [Next page](applydefaultvalue.md) |
| --- | --- |











## Definition


Sets the default base values used for the [BarsPeriod](barsperiod.md) selected by the user (e.g., the default PeriodValue, DaysToLoad, etc.) for your custom Bar Type.


 


## Method Return Value


This method does not return a value.


 


## Parameters




| period | The [BarsPeriod](barsperiod.md) chosen by the user when utilizing this Bars type |
| --- | --- |



## 


## Syntax


You must override the method in your Bars Type with the following syntax:


 


public override void ApplyDefaultBasePeriodValue(BarsPeriod period)


{


 


}


 


## 


## Examples




| ns |
| --- |
| public override void ApplyDefaultBasePeriodValue(BarsPeriod period) {    //sets the default Minute bars period value to 1, and days to load to 5 if (period.BaseBarsPeriodType \=\= BarsPeriodType.Minute) {    period.BaseBarsPeriodValue \= 1;    DaysToLoad \= 5; }    //sets the default Tick bars period value to 150, and days to load to 3 else if (period.BaseBarsPeriodType \=\= BarsPeriodType.Tick) {  period.BaseBarsPeriodValue \= 150;  DaysToLoad \= 3; }   } |









