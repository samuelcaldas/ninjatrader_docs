# UpdateBar()

## Definition

Updates a data point in our Bars Type.

## Syntax

UpdateBar(Bars bars, double high, double low, double close, DateTime time, long volumeAdded)

## Parameters

| Name / Option | Description |
| --- | --- |
| bars | The Bars object of your bars type |
| high | A double value representing the high price |
| low | A double value representing the low price |
| close | A double value representing the close price |
| time | A DateTime value representing the time |
| volume | A long value representing the volume |

## Examples

![Ns](../images/ns.png)

```csharp
UpdateBar(bars, high, low, close, time, volume);
```