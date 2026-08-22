# AddChartIndicator()

## Definition

Adds an indicator to the strategy only for the purpose of displaying it on a chart.

> **Notes:** AddChartIndicator().

## Method Return Value

This method does not return a value.

## Syntax

`AddChartIndicator(IndicatorBaseindicator)`

> State.DataLoaded

## Parameters

| Name / Option | Description |
| --- | --- |
| indicator | An indicator object |

## Examples

![Ns](../images/ns.png)

![Ns](../images/ns.png)

```csharp
OnStateChange()
{
    State.DataLoaded)
    {
        // Charts a 20 period simple moving average to the chart
        ));
    }
}
```
 

 

> State.RealTime for performance optimizations.

 

 

```csharp
OnStateChange()
{
    State.DataLoaded)
    {
        // Charts a 20 period simple moving average to the chart
        ));
    }
}
OnBarUpdate()
{
    // call SMA() historically to ensure the indicator processes its historical states as well
    ];
}
```