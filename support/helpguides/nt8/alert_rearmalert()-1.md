
NinjaScript > Language Reference > Add On > Alert and Debug Concepts > RearmAlert()

RearmAlert()

| << [Click to Display Table of Contents](alert_rearmalert().md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Alert and Debug Concepts](alert_and_debug_concepts-1.md) > RearmAlert() | [Previous page](alertcallback-1.md) [Return to chapter overview](alert_and_debug_concepts-1.md) [Next page](atmstrategy-1.md) |
| --- | --- |
## Definition
Rearms an existing alert event by the string "id" parameter created via the [AlertCallback()](alertcallback-1.md) method.  A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert()'s rearmSeconds parameter.
 

| Note:  The NinjaScriptBase has a non-static method implemented with the same name.  Please see the [RearmAlert()](rearmalert-1.md) method for Indicator or Strategies. |
| --- |

## Method Return Value
This method does not return a value.
 
## Syntax
NinjaTrader.NinjaScript.Alert.RearmAlert(string id)
 
## Parameters

| id | A unique string id representing an alert id to reset |
| --- | --- |
## 
 
## Examples

| ns |
| --- |
| if (resetCondition)  {    NinjaTrader.NinjaScript.Alert.ResetAlertRearmById("someId");    resetCondition = false; } |
