# ToChartString()

## Definition

Returns the bars series as a formatted string, including the [Instrument.FullName](instrument_fullname.md), [BarsPeriod](barsperiod.md) Value, and BarsPeriodType name.

 

> **Note:** To obtain a return value which matches the user configured [ChartBars Label property](chartbars_properties.md), please see the [ChartBars.ToChartString()](chartbars_tochartstring.md).md) method

## Syntax

Bars.ToChartString()

## Return Value

A string value that represents the bars series

## Parameters

This method does not accept any parameters

## Examples

```csharp
protected override void OnBarUpdate()
{
    // print the chart string on start up
    if(CurrentBar == 0)
    Print(Bars.ToChartString()); // ES 09-15 (60 Minute)
}
```