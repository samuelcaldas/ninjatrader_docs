# Save()

Saves the window to workspaces.

## Examples

![Ns](../images/ns.png)

```csharp
// IWorkspacePersistence member. Required for saving window to workspaces
public void Save(XDocument document, XElement element)
{
    if (MainTabControl != null)
    MainTabControl.SaveToXElement(element);
}
```