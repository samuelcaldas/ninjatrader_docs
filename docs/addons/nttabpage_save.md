# Save()

Saves elements in our NTTabPage to the workspace (e.g. Selected accounts or instruments)

## Examples

![Ns](../images/ns.png)

```csharp
// NTTabPage member. Required for saving elements to workspaces
public void Save(XElement element)
{
    if (element == null)
    return;
    // Save any elements you may want persisted. e.g. selected accounts or instruments
}
```