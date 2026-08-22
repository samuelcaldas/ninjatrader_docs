# LastTimePainted

## Definition

Indicates the time of the most recently painted bar on the primary [Bars](bars.md) object configured on the chart.

## Property Value

A [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx) object corresponding to the slot index of the most recently painted bar

## Syntax

<ChartControl>.LastTimePainted

## Example

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    DateTime lastSlotTime = chartControl.LastTimePainted;
    // Print the index of the last slot painted on the chart
    Print(lastSlotTime);
}
```

 

 

In the image below, LastTimePainted reveals that the last index painted on the chart corresponds to 8/12/17 at 2:10:00 PM.

 

![ChartControl_LastTimePainted](chartcontrol_lasttimepainted.png)
