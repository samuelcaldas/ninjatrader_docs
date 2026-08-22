# Restore()

Restores the window from workspaces.

## Examples

```csharp
// IWorkspacePersistence member. Required for restoring window from workspaces
public void Restore(XDocument document, XElement)
{
    if (MainTabControl != null)
    MainTabControl.RestoreFromXElement(element);
}
```
