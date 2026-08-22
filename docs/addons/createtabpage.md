# CreateTabPage()

This determines which [NTTabPage](nttabpage_class.md) is created whenever a new tab is needed in our parent window for our Add On.

## Examples

```csharp
// INTTabFactory member. Creates new tab pages whenever the user presses the + button
public NTTabPage CreateTabPage(string typeName, bool isNewWindow = false)
{
    return new MyWindowTabPage();
}
```