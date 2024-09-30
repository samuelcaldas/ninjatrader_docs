
NinjaScript \> Language Reference \> Add On \> Connection \> Disconnect()

Disconnect()
| \<\< [Click to Display Table of Contents](disconnect.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Connection](connection_class-1.md) \> Disconnect() | [Previous page](connectionstatusupdate-1.md) [Return to chapter overview](connection_class-1.md) [Next page](connections_options-1.md) |
| --- | --- |
## Definition
Disconnects from the data connection.
 
## Syntax
\<Connection\>.Disconnect()

## Example
| ns |
| --- |
| private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // If an execution triggers after 9pm, disconnect from the account's data source    if (e.Time \> new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))        myAccount.Connection.Disconnect(); } |
