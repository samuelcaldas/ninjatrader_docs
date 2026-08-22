# IsDataSeriesRequired

## Definition

Determines if a Data Series is required for calculating this NinjaScript object.  When set to false, data series related properties will not be displayed on the UI when configuring.

> **Note:** When set to false, methods and properties which are dependent on Bars will NOT be used.  This means you will not receive any calls to OnBarUpdate() or be able to access historical bar prices.

## Property Value

This property returns true if the NinjaScript requires a Data Series; otherwise, false.  Default value is true.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IsDataSeriesRequired

 

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsDataSeriesRequired = false;
    }
}
```
