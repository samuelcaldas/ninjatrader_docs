



DefaultQuantity

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\defaultquantity.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  DefaultQuantity | [Previous page](daystoload-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](disconnectdelayseconds-1.htm) |

Definition
----------

An order size variable that can be set either programmatically or overriden via the Strategy that determines the quantity of an entry order.

Property Value
--------------

An int value represents the number of contracts or shares to enter a position with.  Default value is 1.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults or State.Configure |

Syntax
------

DefaultQuantity

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()   {       if (State == State.SetDefaults)       {           DefaultQuantity = 1;       }  } |