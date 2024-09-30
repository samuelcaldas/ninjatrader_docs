
NinjaScript > Language Reference > Strategy > DefaultQuantity
DefaultQuantity
| << [Click to Display Table of Contents](defaultquantity.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > DefaultQuantity | [Previous page](daystoload.md) [Return to chapter overview](strategy.md) [Next page](disconnectdelayseconds.md) |
| --- | --- |
## Definition
An order size variable that can be set either programmatically or overriden via the Strategy that determines the quantity of an entry order.
 
## Property Value
An int value represents the number of contracts or shares to enter a position with.  Default value is 1.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |
## 
## 
## Syntax
DefaultQuantity

## Examples
| ns |
| --- |
| protected override void OnStateChange()  {      if (State == State.SetDefaults)      {          DefaultQuantity = 1;      } } |

