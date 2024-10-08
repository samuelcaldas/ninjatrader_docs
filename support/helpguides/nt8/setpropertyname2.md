﻿
NinjaScript > Language Reference > Bars Type > SetPropertyName

SetPropertyName()

| << [Click to Display Table of Contents](setpropertyname2.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Bars Type](bars_type.md) > SetPropertyName() | [Previous page](removelastbar.md) [Return to chapter overview](bars_type.md) [Next page](barstype_sessioniterator.md) |
| --- | --- |
## Definition
Sets a default property name to a custom string to be displayed on the UI. 
 
## Method Return Value
This method does not return a value.
 
## Syntax
SetPropertyName(string propertyName, string displayName)
## 
## 
## Method Parameters

| propertyName | A string representing the property to be renamed. Possible values include: - UpBrush- DownBrush- BarWidth- Stroke- Stroke2- Value- Value2- BaseBarsPeriodType- BaseBarsPeriodValue- PointAndFigurePriceType- ReversalType |
| --- | --- |
| displayName | A string representing the desired property name |
 
## 
## Example

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.Configure)    {        Properties.Remove(Properties.Find("Stroke", true));        Properties.Remove(Properties.Find("Stroke2", true));          SetPropertyName("UpBrush", "AdvanceBar");        SetPropertyName("DownBrush", "DeclineBar");    } } |
## 
## 

| Note: If you do not wish to use specific properties accessible via SetPropertyName(), you will need to remove them from the list via Properties.Remove, as shown in the example above. |
| --- |
