
NinjaScript > Language Reference > Add On > Account > Flatten()
Flatten()
| << [Click to Display Table of Contents](flatten.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [Account](account_class.md) > Flatten() | [Previous page](executionupdate.md) [Return to chapter overview](account_class.md) [Next page](get.md) |
| --- | --- |
## Definition
Flattens the account on an instrument.
 
## Syntax
Flatten(ICollection<Instrument> instruments)
 
## Parameters
| instruments | A collection of Instruments for orders to be cancelled and positions closed |
| --- | --- |
 
## 
## Examples
| ns |
| --- |
| Account.Flatten(new [] { Instrument.GetInstrument("ES 12-15") }); |
 
## 
| ns |
| --- |
| // Please note that your 'Using declarations' section needs to have  // // using System.Collections.ObjectModel; // // added in order for this example to compile correctly   // instantiate a list of instruments Collection<Cbi.Instrument> instrumentsToClose = new Collection<Instrument>();            // add instruments to the collection instrumentsToClose.Add(Instrument.GetInstrument("AAPL"));          instrumentsToClose.Add(Instrument.GetInstrument("MSFT"));   // pass the instrument collection to the Flatten() method to be flattened Account.Flatten(instrumentsToClose); |

