# CreateParentWindow()

This determines which [NTWindow](ntwindow.md) is created as the parent window for our Add On.

## Examples

![Ns](../images/ns.png)

```csharp
// INTTabFactory member. Creates the parent window that contains tabs
public NTWindow CreateParentWindow()
{
    return new MyWindow();
}
```