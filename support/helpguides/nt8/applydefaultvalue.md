
NinjaScript \> Language Reference \> Bars Type \> ApplyDefaultValue

ApplyDefaultValue

| \<\< [Click to Display Table of Contents](applydefaultvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Bars Type](bars_type.md) \> ApplyDefaultValue | [Previous page](applydefaultbaseperiodvalue.md) [Return to chapter overview](bars_type.md) [Next page](builtfrom.md) |
| --- | --- |
## Definition
Sets the default [BarsPeriod](barsperiod.md) values used for a custom Bar Type. 
 
## Method Return Value
This method does not return a value.
 
## Parameters

| period | The [BarsPeriod](barsperiod.md) chosen by the user when utilizing this Bars type |
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
