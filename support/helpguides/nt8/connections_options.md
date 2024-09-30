
NinjaScript \> Language Reference \> Add On \> Connection \> Options

Options

| \<\< [Click to Display Table of Contents](connections_options.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Connection](connection_class.md) \> Options | [Previous page](disconnect.md) [Return to chapter overview](connection_class.md) [Next page](connections_pricestatus.md) |
| --- | --- |
## Definition
The connection's configuration options
 
## Properties

| ConnectOnStartup | A bool representing if this connection auto connects on startup |
| --- | --- |
| Name | A string representing the connection's name |
| Provider | A Provider representing the connection's provider |

## Example

| ns |
| --- |
| // Example of accessing information on all connected connections public class MyAddOnTab : NTTabPage {      public MyAddOnTab()      {          // Print information about all connected connections          lock (Connection.Connections)                Connection.Connections.ToList().ForEach(c \=\> NinjaTrader.Code.Output.Process(string.Format("Connection: {0}                     Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1\);      }        // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code. } |
