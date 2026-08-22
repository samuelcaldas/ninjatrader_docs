# GetHeaderPart()

## Definition

Indicates the tab header name.

## Examples

![Ns](../images/ns.png)

```csharp
// NTTabPage member. Required for determining the tab header name
protected override string GetHeaderPart(string variable)
{
    // Determine the text for the tab header name
    switch (variable)
    {
        case "@INSTRUMENT": return Instrument == null ? Resource.GuiNewTab : Instrument.MasterInstrument.Name;
        case "@INSTRUMENT\_FULL": return Instrument == null ? Resource.GuiNewTab : Instrument.FullName;
    }
    return variable;
}
```