



Connection

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](connection_class.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) >  Connection | [Previous page](barsrequest_mergepolicy.md) [Return to chapter overview](add_on.md) [Next page](connection_cancelallorders.md) |

Definition
----------

The Connection class can be used to monitor connection related events as well as accessing connection related information.

Static Connection Class Events and Properties
---------------------------------------------

|  |  |
| --- | --- |
| CancelAllOrders() | Cancels all orders |
| Connect() | Connects to a connection |
| ConnectionStatusUpdate | Event handler for connection status updates |

Events and Properties from Connection instances
-----------------------------------------------

|  |  |
| --- | --- |
| Accounts | List of accounts from the connection |
| Disconnect() | Disconnects from the connection |
| Options | The connection's configuration options |
| PriceStatus | A ConnectionStatus representing the status of the price feed. Possible values are:   ConnectionStatus.Connected  ConnectionStatus.Connecting   ConnectionStatus.ConnectionLost  ConnectionStatus.Disconnecting  ConnectionStatus.Disconnected |
| Status | A ConnectionStatus representing the status of the order feed. Possible values are:   ConnectionStatus.Connected  ConnectionStatus.Connecting   ConnectionStatus.ConnectionLost  ConnectionStatus.Disconnecting  ConnectionStatus.Disconnected |

Example
-------

|  |
| --- |
| // Example of accessing information on all connected connections  NTTabPage  {  MyAddOnTab()  {  // Print information about all connected connections  (Connection.Connections)  Connection.Connections)  PrintTo.OutputTab1);     // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.  }  } |