# AreLinesConfigurable

## Definition

Determines if the [line](addline.md)(s) used in an indicator are configurable from within the indicator dialog window.

## Property Value

A bool which true if any indicator line(s) are configurable; otherwise, false. Default set to true.

## Syntax

AreLinesConfigurable

 

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        AddLine(Brushes.Gray, 30, "Lower");
        AreLinesConfigurable = false; // Indicator lines are not configurable
    }
}
```