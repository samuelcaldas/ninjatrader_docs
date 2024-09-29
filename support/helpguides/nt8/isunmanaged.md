


NinjaScript \> Language Reference \> Strategy \> Order Methods \> Unmanaged Approach \> IsUnmanaged






















IsUnmanaged







| \<\< [Click to Display Table of Contents](isunmanaged.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [Order Methods](order_methods.md) \> [Unmanaged Approach](unmanaged_approach.md) \> IsUnmanaged | [Previous page](ignoreoverfill.md) [Return to chapter overview](unmanaged_approach.md) [Next page](submitorderunmanaged.md) |
| --- | --- |











## Definition


Determines if the strategy will be using Unmanaged order methods. 


 




| Note: Unmanaged order methods and [Managed order methods](managed_approach.md) CANNOT be used interchangeably.  When IsUnmanaged is set to true, calling managed order methods such as EnterLong(), SetStopLoss(), etc, will generate an error which will be displayed on the [Log tab](log_tab2.md) of the Control Center. |
| --- |



 


 


## Property Value


This property returns true if the strategy will use Unmanaged order methods; otherwise, false. Default is set to false. 


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IsUnmanaged


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Use Unmanaged order methods          IsUnmanaged \= true;      } } |









