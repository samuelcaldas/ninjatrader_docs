
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > InstrumentType

InstrumentType

| << [Click to Display Table of Contents](instrumenttype.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Instruments](instruments_ninjascript.md) > [Instrument](instrument.md) > [MasterInstrument](masterinstrument.md) > InstrumentType | [Previous page](formatprice.md) [Return to chapter overview](masterinstrument.md) [Next page](mergepolicy.md) |
| --- | --- |
## Definition
Returns the type of instrument.
## 
## Property Value
An InstrumentType representing the type of an instrument.
 
Possible values are:
 
InstrumentType.Future
InstrumentType.Stock
InstrumentType.Index
InstrumentType.Forex 
InstrumentType.Cfd
InstrumentType.Cryptocurrency
## 
## Syntax
Instrument.MasterInstrument.InstrumentType
 
## 
## Examples

| ns |
| --- |
| if (Instrument.MasterInstrument.InstrumentType == InstrumentType.Future) {  // Do something } else {  // Do something else } |
## 
 
## Additional Access Information
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument != null)
