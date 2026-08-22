# Flatten()

## Definition

Flattens the account on an instrument.

## Syntax

Flatten(ICollection<Instrument> instruments)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| instruments | A collection of Instruments for orders to be cancelled and positions closed |

## Examples

```csharp
Account.Flatten(new [] { Instrument.GetInstrument("ES 12-15") });
```

```csharp
// Please note that your 'Using declarations' section needs to have
//
// using System.Collections.ObjectModel;
//
// added in order for this example to compile correctly
// instantiate a list of instruments
Collection<Cbi.Instrument> instrumentsToClose = new Collection<Instrument>();
// add instruments to the collection
instrumentsToClose.Add(Instrument.GetInstrument("AAPL"));
instrumentsToClose.Add(Instrument.GetInstrument("MSFT"));
// pass the instrument collection to the Flatten() method to be flattened
Account.Flatten(instrumentsToClose);
```
