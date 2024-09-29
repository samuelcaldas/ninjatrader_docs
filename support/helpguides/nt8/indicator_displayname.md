


NinjaScript \> Language Reference \> Common \> DisplayName






















DisplayName







| \<\< [Click to Display Table of Contents](indicator_displayname.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> DisplayName | [Previous page](description.md) [Return to chapter overview](common.md) [Next page](isvisible.md) |
| --- | --- |











## Definition


## Determines the text display on the chart panel.  This is also listed in the UI as the "Label" which can be manually changed (if not overridden).  The default behavior of this property will include the NinjaScript type Name along with its input and data series parameters.  However this behavior can be overridden if desired.


## 




| Note:  For modifying the string which is used in the list of available indicators, please see the [Name](name.md) property. |
| --- |



 


## Property Value


A virtual string.  This property is read\-only.


 


## Syntax


DisplayName


 


You may choose to override this property using the following syntax:


 


public override string DisplayName  

{  

   get { }  

}


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Example Indicator";                        }       }     protected override void OnBarUpdate() {    Print(DisplayName);   //Output:  Example Indicator(ES 03\-15 (1 Minute)) } |



 


 




| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Example Indicator";                        }       }   public override string DisplayName {    get { return "My Custom Display " \+ Name; } }   protected override void OnBarUpdate() {    Print(DisplayName);   //Output:  My Custom Display Example Indicator } |









