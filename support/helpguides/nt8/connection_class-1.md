
NinjaScript \> Language Reference \> Add On \> Connection

Connection

| \<\< [Click to Display Table of Contents](connection_class.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> Connection | [Previous page](barsrequest_mergepolicy-1.md) [Return to chapter overview](add_on-1.md) [Next page](connection_cancelallorders-1.md) |
| --- | --- |
## Definition
The Connection class can be used to monitor connection related events as well as accessing connection related information.
 
## Static Connection Class Events and Properties

| [CancelAllOrders()](connection_cancelallorders-1.md) | Cancels all orders |
| --- | --- |
| [Connect()](connect-1.md) | Connects to a connection |
| [ConnectionStatusUpdate](connectionstatusupdate-1.md) | Event handler for connection status updates |

## Events and Properties from Connection instances

| [Accounts](account_class-1.md) | List of accounts from the connection |
| --- | --- |
| [Disconnect()](disconnect-1.md) | Disconnects from the connection |
| [Options](connections_options-1.md) | The connection's configuration options |
| [PriceStatus](connections_pricestatus-1.md) | A ConnectionStatus representing the status of the price feed. Possible values are:   ConnectionStatus.Connected ConnectionStatus.Connecting  ConnectionStatus.ConnectionLost ConnectionStatus.Disconnecting ConnectionStatus.Disconnected |
| [Status](connections_status-1.md) | A ConnectionStatus representing the status of the order feed. Possible values are:   ConnectionStatus.Connected ConnectionStatus.Connecting  ConnectionStatus.ConnectionLost ConnectionStatus.Disconnecting ConnectionStatus.Disconnected |

## Example

| ns |
| --- |
| // Example of accessing information on all connected connections public class MyAddOnTab : NTTabPage {    public MyAddOnTab()    {      // Print information about all connected connections      lock (Connection.Connections)        foreach(Connection c in Connection.Connections)            NinjaTrader.Code.Output.Process(string.Format("Connection: {0} Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1\);        // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.    } } |
