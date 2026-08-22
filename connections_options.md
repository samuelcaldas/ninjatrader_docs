# Options

## Definition

The connection's configuration options

## Properties

|  |  |
| --- | --- |
| ConnectOnStartup | A bool representing if this connection auto connects on startup |
| Name | A string representing the connection's name |
| Provider | A Provider representing the connection's provider |

## Example

```csharp
// Example of accessing information on all connected connections
public class MyAddOnTab : NTTabPage
{
    public MyAddOnTab()
    {
        // Print information about all connected connections
        lock (Connection.Connections)
        Connection.Connections.ToList().ForEach(c => NinjaTrader.Code.Output.Process(string.Format("Connection: {0}
        Provider: {1}", c.Options.Name, c.Options.Provider), PrintTo.OutputTab1);
    }
    // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.
}
```
