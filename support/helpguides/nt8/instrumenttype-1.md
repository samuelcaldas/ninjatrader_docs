
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > InstrumentType

InstrumentType

| << [Click to Display Table of Contents](instrumenttype.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Instruments](instruments_ninjascript-1.md) > [Instrument](instrument-1.md) > [MasterInstrument](masterinstrument-1.md) > InstrumentType | [Previous page](formatprice-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](mergepolicy-1.md) |
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
