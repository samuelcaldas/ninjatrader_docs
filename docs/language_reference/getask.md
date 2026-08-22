# GetAsk()

## Definition

Returns the ask price value at a selected absolute bar index value.

> **Notes:**
- This method does NOT return the current real-time asking price, but rather the historical / real-time asking price at the desired index.  For obtaining the current real-time asking price, please use [GetCurrentAsk](getcurrentask.md)().
- This method returns expected values when 1 tick bid / ask stamped data is used and available from [your provider](../operations/data_by_provider.md).

## Method Return Value

A double value that represents the asking price at the desired bar index.

## Syntax

Bars.GetAsk(int index)

## Parameters

| Name / Option | Description |
| --- | --- |
| index | The absolute bar index value used |

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // If the Highs of the two most recent bars are falling, place a long stop market order
    // at the Ask price
    if (High[0] < High[1] && High[1] < High[2])
    {
        EnterLongStopMarket(Bars.GetAsk(CurrentBar));
    }
}
```