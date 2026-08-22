# RolloverCollection

## Definition

Indicates the rollovers that have been configured for the [[[Master Instrument properties](editing_instruments.md) used in for futures.

## Property Value

A RolloversCollection configured for the current instrument.

Possible values are:

|  |  |
| --- | --- |
| ContractMonth | A DateTime structure representing the expiry month of a futures contract |
| Date | A DateTime structure representing the date of the rollover |
| Offset | A double value representing the number of points between contracts |

## Syntax

Bars.Instrument.MasterInstrument.RolloverCollection

## Examples

```csharp
foreach(var rollover in Bars.Instrument.MasterInstrument.RolloverCollection)
{
    Print(rollover.ContractMonth);
    Print(rollover.Date);
    Print(rollover.Offset);
}
```
