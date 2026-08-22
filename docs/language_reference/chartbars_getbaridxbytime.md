# GetBarIdxByTime()

## Definition

Returns the [ChartBars](chartbars.md) index value calculated from the time parameter provided.

## Method Return Value

An int representing the bar index value at a specific time

## Syntax

`ChartBars.GetBarIdxByTime(ChartControl chartControl, DateTime time)`

## Method Parameters

| Name / Option | Description |
| --- | --- |
| chartControl | The [ChartControl](chartcontrol.md) object used to determine the chart's time axis |
| time | The [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) value used to convert to a ChartBar index value |

## Examples

```csharp
protected override void OnBarUpdate()
{
    if (ChartBars != null)
    {
        Print(ChartBars.GetBarIdxByTime(ChartControl, Time[0]));
    }
}
```