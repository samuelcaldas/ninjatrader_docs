



Options

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](connections_options.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Connection](connection_class.htm) >  Options | [Previous page](disconnect.htm) [Return to chapter overview](connection_class.htm) [Next page](connections_pricestatus.htm) |

Definition
----------

The connection's configuration options

Properties
----------

|  |  |
| --- | --- |
| ConnectOnStartup | A bool representing if this connection auto connects on startup |
| Name | A string representing the connection's name |
| Provider | A Provider representing the connection's provider |

Example
-------

| ns |
| --- |
| // Example of accessing information on all connected connections  public class MyAddOnTab : NTTabPage  {       public MyAddOnTab()       {           // Print information about all connected connections           lock (Connection.Connections)                 Connection.Connections.ToList().ForEach(c => NinjaTrader.Code.Output.Process(string.Format("Connection: {0}                      Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1);       }          // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.  } |