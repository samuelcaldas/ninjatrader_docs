# OnCopyTo()

## Definition

Called as the values of a trade metric are saved.

## Syntax

protected override void OnCopyTo(PerformanceMetricBase target)  
{  
     
}

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnCopyTo(PerformanceMetricBase target)
{
    // You need to cast, in order to access the right type
    SampleCumProfit targetMetrics = (target as SampleCumProfit);
    if (targetMetrics != null)
    Array.Copy(Values, targetMetrics.Values, Values.Length);
}
```