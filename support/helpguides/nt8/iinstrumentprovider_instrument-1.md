
NinjaScript \> Language Reference \> Add On \> IInstrumentProvider Interface \> Instrument

Instrument
| \<\< [Click to Display Table of Contents](iinstrumentprovider_instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [IInstrumentProvider Interface](iinstrumentprovider_interface-1.md) \> Instrument | [Previous page](iinstrumentprovider_interface-1.md) [Return to chapter overview](iinstrumentprovider_interface-1.md) [Next page](iintervalprovider_interface-1.md) |
| --- | --- |
In order for instrument linking to work properly in your Add On, Instrument must be created.
 
## 
## Examples
| ns |
| --- |
| // IInstrumentProvider member public Instrument Instrument {      get { return instrument; }      set      {          if (instrument !\= null)           {                // Unsubscribe to subscriptions to previously selected instrument           }                          if (value !\= null)           {                // Create subscriptions for the newly selected instrument           }             instrument \= value;            // Send instrument to other windows linked to the same color           PropagateInstrumentChange(value);            // Update the tab header name           RefreshHeader();      } } |
