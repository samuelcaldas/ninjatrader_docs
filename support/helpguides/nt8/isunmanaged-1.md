
NinjaScript > Language Reference > Strategy > Order Methods > Unmanaged Approach > IsUnmanaged

IsUnmanaged

| << [Click to Display Table of Contents](isunmanaged.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [Order Methods](order_methods-1.md) > [Unmanaged Approach](unmanaged_approach-1.md) > IsUnmanaged | [Previous page](ignoreoverfill-1.md) [Return to chapter overview](unmanaged_approach-1.md) [Next page](submitorderunmanaged-1.md) |
| --- | --- |
## Definition
Determines if the strategy will be using Unmanaged order methods. 
 

| Note: Unmanaged order methods and [Managed order methods](managed_approach-1.md) CANNOT be used interchangeably.  When IsUnmanaged is set to true, calling managed order methods such as EnterLong(), SetStopLoss(), etc, will generate an error which will be displayed on the [Log tab](log_tab2-1.md) of the Control Center. |
| --- |

## Property Value
This property returns true if the strategy will use Unmanaged order methods; otherwise, false. Default is set to false. 
 

| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
IsUnmanaged
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          // Use Unmanaged order methods          IsUnmanaged = true;      } } |
