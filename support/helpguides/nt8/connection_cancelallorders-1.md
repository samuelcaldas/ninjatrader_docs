



CancelAllOrders()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\connection_cancelallorders.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Connection](connection_class-1.htm) >  CancelAllOrders() | [Previous page](connection_class-1.htm) [Return to chapter overview](connection_class-1.htm) [Next page](connect-1.htm) |

Definition
----------

Cancels all orders for the specified instrument on the connection.

Syntax
------

<Connection>.CancelAllOrders(Instrument instrument)

|  |  |
| --- | --- |
| instrument | An Instrument object used to identify the instrument for which to cancel orders |

Example
-------

| ns |
| --- |
| private Account myAccount;     protected override void OnStateChange()  {     if (State == State.SetDefaults)     {         // Initialize myAccount     }  }     private void OnExecutionUpdate(object sender, ExecutionEventArgs e)  {     // Cancel all orders if an execution is triggered after 9pm     if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))         myAccount.CancelAllOrders(e.Execution.Instrument);  } |