
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument

MasterInstrument

| << [Click to Display Table of Contents](masterinstrument.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Instruments](instruments_ninjascript.md) > [Instrument](instrument.md) > MasterInstrument | [Previous page](getinstrument.md) [Return to chapter overview](instrument.md) [Next page](compare.md) |
| --- | --- |
## Definition
An instrument's configuration settings.  These are settings and properties which are defined in the [Instrument](instruments.md) window.
 

| Warning:  The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded. |
| --- |

## Methods and Properties

| [Compare()](compare.md) | Returns an int value compares two price values with respect to the Instrument tick size |
| --- | --- |
| [Currency](currency.md) | The currency that the instrument traded in |
| [Description](masterinstrument_description.md) | A  written representation of a given instrument |
| [Dividends](dividends.md) | A collection of dividends for stock instruments |
| [Exchanges](exchanges.md) | A collection of exchanges configured for an instrument |
| [FormatPrice()](formatprice.md) | Returns a string representing the price formatted to the nearest tick size |
| [InstrumentType](instrumenttype.md) | The type of instrument |
| [MergePolicy](mergepolicy.md) | The Merge Policy that is configured for the current master instrument. |
| [Name](masterinstrument_name.md) | The name of the instrument. |
| [GetNextExpiry()](getnextexpiry.md) | Returns a DateTime structure representing the next futures expiry for a given date |
| [PointValue](pointvalue.md) | Currency value of 1 full point of movement |
| [RolloverCollection](rollovercollection.md) | A collection of expiration dates and offsets for futures instruments |
| [RoundToTickSize()](roundtoticksize.md) | Rounds the value up to the nearest valid value |
| [RoundDownToTickSize()](rounddowntoticksize.md) | Rounds the value down to the nearest valid value |
| [Splits](splits.md) | A collection of splits for stock instruments |
| [TickSize](ticksize.md) | The smallest movement in price configured |
| [Url](url.md) | A web url where contract details have been collected |
