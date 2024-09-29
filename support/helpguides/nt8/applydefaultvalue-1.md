


NinjaScript \> Language Reference \> Bars Type \> ApplyDefaultValue






















ApplyDefaultValue







| \<\< [Click to Display Table of Contents](applydefaultvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Bars Type](bars_type-1.md) \> ApplyDefaultValue | [Previous page](applydefaultbaseperiodvalue-1.md) [Return to chapter overview](bars_type-1.md) [Next page](builtfrom-1.md) |
| --- | --- |











## Definition


Sets the default [BarsPeriod](barsperiod-1.md) values used for a custom Bar Type. 


 


## Method Return Value


This method does not return a value.


 


## Parameters




| period | The [BarsPeriod](barsperiod-1.md) chosen by the user when utilizing this Bars type |
| --- | --- |



## 


## 


## Syntax


You must override the method in your Bars Type with the following syntax:


 


public override void ApplyDefaultValue(BarsPeriod period)  

{  

   

}


 


## Examples




| ns |
| --- |
| public override void ApplyDefaultValue(BarsPeriod period) {  period.BarsPeriodTypeName \= "MyBarType";  period.Value \= 1; } |









