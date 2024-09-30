
NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> RearmAlert()

RearmAlert()

| \<\< [Click to Display Table of Contents](rearmalert.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Alert, Debug, Share](alert__debugging_and_sharing.md) \> RearmAlert() | [Previous page](printto.md) [Return to chapter overview](alert__debugging_and_sharing.md) [Next page](sendmail.md) |
| --- | --- |
## Definition
Rearms an alert created via the [Alert()](alert.md) method.  
 

| Note:  A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert() methods rearmSeconds parameter. |
| --- |

## Method Return Value
This method does not return a value.
## 
## Syntax
RearmAlert(string id)
 
## Parameters

| id | A unique string id representing an alert id to rearm |
| --- | --- |

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    //rearms "myAlert" on each new trading session    if(Bars.IsFirstBarOfSession)      RearmAlert("myAlert"); } |
