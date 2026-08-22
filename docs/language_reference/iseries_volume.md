# Volume

## Definition

A collection of historical bar volume values.

 

> **Note:** For working with [Cryptocurrency instruments](instrumenttype.md) which report volume fractional, please use the [VOL()](../indicators/volume.md) indicator series, or store the volume for your script in a custom variable and convert alongside our [VOL()](../indicators/volume.md) indicator (Instrument.MasterInstrument.InstrumentType == InstrumentType.CryptoCurrency ? Core.Globals.ToCryptocurrencyVolume((long)Volume[0]) : Volume[0]).

## Property Value

An `ISeries<double>` object. Accessing this property via an index [int barsAgo] returns a double value representing the volume of the referenced bar.

## Syntax

Volume  
Volume[int barsAgo]

## Examples

```csharp
// OnBarUpdate method
protected override void OnBarUpdate()
{
    // Is current volume greater than twice the prior bar's volume
    if (Volume[0] > Volume[1] \* 2)
    Print("We have increased volume");
    // Is the current volume greater than the 20 period moving average of volume
    if (Volume[0] > SMA(Volume, 20)[0])
    Print("Increasing volume");
}
```