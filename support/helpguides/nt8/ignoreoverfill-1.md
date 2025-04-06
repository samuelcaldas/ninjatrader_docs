



IgnoreOverfill

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ignoreoverfill.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [Order Methods](order_methods-1.htm) > [Unmanaged Approach](unmanaged_approach-1.htm) >  IgnoreOverfill | [Previous page](unmanaged_changeorder-1.htm) [Return to chapter overview](unmanaged_approach-1.htm) [Next page](isunmanaged-1.htm) |

Definition
----------

An [unmanaged order property](unmanaged_approach-1.htm) which defines the behavior of a strategy when an overfill is detected. An overfill is categorized as when an order returns a "Filled" or "PartFilled" state after the order was already marked for cancellation. The cancel request could have been induced by an explicit CancelOrder() call, from more implicit cancellations like those that occur when another order sharing the same OCO ID is filled, or from things like order expiration.

|  |
| --- |
| Critical:  •Setting this property value to true can have serious adverse affects on a running strategy unless you have programmed your own overfill handling  •User defined overfill handling is advanced and should ONLY be addressed by experienced programmers. Additional information can be found on overfills in the [Unmanaged approach](unmanaged_approach-1.htm) section |

Property Value
--------------

This property returns true if the strategy will ignore overfills; otherwise, false. Default is set to false.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults or State.Configure |

Syntax
------

IgnoreOverfill

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {         // Allows for custom overfill handling         IgnoreOverfill = true;     }  } |