# GetTimeByBarIdx()

## Definition

Returns the [ChartBars](chartbars.md) time value calculated from a bar index parameter provided.

## Method Return Value

A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) struct representing a bar time value at a specific bar index value

## Syntax

`ChartBars.GetTimeByBarIdx(ChartControl chartControl, int barIndex)`

## Method Parameters

|  |  |
| --- | --- |
| chartControl | The [ChartControl](chartcontrol.md) object used to determine the chart's time axis |
| barIndex | An int value representing a bar index used to convert to a ChartBar index value |

## Examples

```csharp
protected override void OnBarUpdate()
{
    if (ChartBars != null)
    {
        Print(ChartBars.GetTimeByBarIdx(ChartControl, 50)); //8/11/2015 4:30:00 AM
    }
}
```
