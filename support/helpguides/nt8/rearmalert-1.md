
NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> RearmAlert()

RearmAlert()

| \<\< [Click to Display Table of Contents](rearmalert.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Alert, Debug, Share](alert__debugging_and_sharing-1.md) \> RearmAlert() | [Previous page](printto-1.md) [Return to chapter overview](alert__debugging_and_sharing-1.md) [Next page](sendmail-1.md) |
| --- | --- |
## Definition
Rearms an alert created via the [Alert()](alert-1.md) method.  
 

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
