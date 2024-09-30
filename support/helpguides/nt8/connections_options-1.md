
NinjaScript > Language Reference > Add On > Connection > Options

Options

| << [Click to Display Table of Contents](connections_options.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Connection](connection_class-1.md) > Options | [Previous page](disconnect-1.md) [Return to chapter overview](connection_class-1.md) [Next page](connections_pricestatus-1.md) |
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
| // Example of accessing information on all connected connections public class MyAddOnTab : NTTabPage {      public MyAddOnTab()      {          // Print information about all connected connections          lock (Connection.Connections)                Connection.Connections.ToList().ForEach(c => NinjaTrader.Code.Output.Process(string.Format("Connection: {0}                     Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1);      }        // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code. } |
