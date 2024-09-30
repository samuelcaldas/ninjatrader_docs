
NinjaScript > Language Reference > Add On > Connection

Connection

| << [Click to Display Table of Contents](connection_class.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > Connection | [Previous page](barsrequest_mergepolicy.md) [Return to chapter overview](add_on.md) [Next page](connection_cancelallorders.md) |
| --- | --- |
## Definition
The Connection class can be used to monitor connection related events as well as accessing connection related information.
 
## Static Connection Class Events and Properties

| [CancelAllOrders()](connection_cancelallorders.md) | Cancels all orders |
| --- | --- |
| [Connect()](connect.md) | Connects to a connection |
| [ConnectionStatusUpdate](connectionstatusupdate.md) | Event handler for connection status updates |

## Events and Properties from Connection instances

| [Accounts](account_class.md) | List of accounts from the connection |
| --- | --- |
| [Disconnect()](disconnect.md) | Disconnects from the connection |
| [Options](connections_options.md) | The connection's configuration options |
| [PriceStatus](connections_pricestatus.md) | A ConnectionStatus representing the status of the price feed. Possible values are:   ConnectionStatus.Connected ConnectionStatus.Connecting  ConnectionStatus.ConnectionLost ConnectionStatus.Disconnecting ConnectionStatus.Disconnected |
| [Status](connections_status.md) | A ConnectionStatus representing the status of the order feed. Possible values are:   ConnectionStatus.Connected ConnectionStatus.Connecting  ConnectionStatus.ConnectionLost ConnectionStatus.Disconnecting ConnectionStatus.Disconnected |

## Example

| ns |
| --- |
| // Example of accessing information on all connected connections public class MyAddOnTab : NTTabPage {    public MyAddOnTab()    {      // Print information about all connected connections      lock (Connection.Connections)        foreach(Connection c in Connection.Connections)            NinjaTrader.Code.Output.Process(string.Format("Connection: {0} Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1);        // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.    } } |
