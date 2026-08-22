# MergePolicy

## Definition

Indicates the Merge Policy configured for the [[[Master Instrument properties](editing_instruments.md).

## Property Value

Represents the MergePolicy that is configured for the current master instrument.

Possible values are:

|  |  |
| --- | --- |
| DoNotMerge | No merge policy is applied |
| MergeBackAdjusted | Merge policy is applied between contracts along with rollover offsets |
| MergeNonBackAdjusted | Merge policy is applied between contracts without offsets |
| UseGlobalSettings | Uses the value configured from Tools -> Options -> Market Data |

## Syntax

Bars.Instrument.MasterInstrument.MergePolicy

## Examples

```csharp
//Prints a warning, indicating what merge policy is in use if not using global settings
if (Bars.Instrument.MasterInstrument.MergePolicy != MergePolicy.UseGlobalSettings)
{
    Print("Warning: Instrument has merge policy of " + Bars.Instrument.MasterInstrument.MergePolicy);
}
```
