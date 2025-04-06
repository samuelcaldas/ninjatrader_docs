



Disconnect()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](disconnect.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Connection](connection_class.htm) >  Disconnect() | [Previous page](connectionstatusupdate.htm) [Return to chapter overview](connection_class.htm) [Next page](connections_options.htm) |

Definition
----------

Disconnects from the data connection.

Syntax
------

<Connection>.Disconnect()

 

 

Example
-------

| ns |
| --- |
| private void OnExecutionUpdate(object sender, ExecutionEventArgs e)  {     // If an execution triggers after 9pm, disconnect from the account's data source     if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))         myAccount.Connection.Disconnect();  } |