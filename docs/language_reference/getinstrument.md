# GetInstrument()

## Definition

Returns an [[[Instrument](instruments.md) object by the master instrument name configured in the database.

> **Note:** This method does NOT add additional data for real-time or historical processing.  For adding an additional data to your script, please see the  [[[AddDataSeries()](adddataseries.md) method.

## Method Return Value

An [[[Instrument](instrument.md) object

## Syntax

Instrument.GetInstrument(string instrumentName)

## Parameters

|  |  |
| --- | --- |
| instrumentName | A string value representing a name of an instrument |

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.Historical)
    {
        Instrument myInstrument = Instrument.GetInstrument("AAPL");
        Print("AAPL's tick size is " + myInstrument.MasterInstrument.TickSize.ToString());
    }
}
```
