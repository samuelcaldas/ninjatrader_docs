


NinjaScript \> Language Reference \> Add On \> Account \> Flatten()






















Flatten()







| \<\< [Click to Display Table of Contents](flatten.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Flatten() | [Previous page](executionupdate-1.md) [Return to chapter overview](account_class-1.md) [Next page](get-1.md) |
| --- | --- |











## Definition


Flattens the account on an instrument.


 


## Syntax


Flatten(ICollection\<Instrument\> instruments)


 


## Parameters




| instruments | A collection of Instruments for orders to be cancelled and positions closed |
| --- | --- |



 


## 


## Examples




| ns Flatten a single instrument |
| --- |
| Account.Flatten(new \[] { Instrument.GetInstrument("ES 12\-15") }); |



 


## 




| ns Flatten a list of instruments |
| --- |
| // Please note that your 'Using declarations' section needs to have  // // using System.Collections.ObjectModel; // // added in order for this example to compile correctly   // instantiate a list of instruments Collection\<Cbi.Instrument\> instrumentsToClose \= new Collection\<Instrument\>();            // add instruments to the collection instrumentsToClose.Add(Instrument.GetInstrument("AAPL"));          instrumentsToClose.Add(Instrument.GetInstrument("MSFT"));   // pass the instrument collection to the Flatten() method to be flattened Account.Flatten(instrumentsToClose); |









