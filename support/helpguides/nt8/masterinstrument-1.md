
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument

MasterInstrument

| \<\< [Click to Display Table of Contents](masterinstrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> MasterInstrument | [Previous page](getinstrument-1.md) [Return to chapter overview](instrument-1.md) [Next page](compare-1.md) |
| --- | --- |
## Definition
An instrument's configuration settings.  These are settings and properties which are defined in the [Instrument](instruments-1.md) window.
 

| Warning:  The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded. |
| --- |

## Methods and Properties

| [Compare()](compare-1.md) | Returns an int value compares two price values with respect to the Instrument tick size |
| --- | --- |
| [Currency](currency-1.md) | The currency that the instrument traded in |
| [Description](masterinstrument_description-1.md) | A  written representation of a given instrument |
| [Dividends](dividends-1.md) | A collection of dividends for stock instruments |
| [Exchanges](exchanges-1.md) | A collection of exchanges configured for an instrument |
| [FormatPrice()](formatprice-1.md) | Returns a string representing the price formatted to the nearest tick size |
| [InstrumentType](instrumenttype-1.md) | The type of instrument |
| [MergePolicy](mergepolicy-1.md) | The Merge Policy that is configured for the current master instrument. |
| [Name](masterinstrument_name-1.md) | The name of the instrument. |
| [GetNextExpiry()](getnextexpiry-1.md) | Returns a DateTime structure representing the next futures expiry for a given date |
| [PointValue](pointvalue-1.md) | Currency value of 1 full point of movement |
| [RolloverCollection](rollovercollection-1.md) | A collection of expiration dates and offsets for futures instruments |
| [RoundToTickSize()](roundtoticksize-1.md) | Rounds the value up to the nearest valid value |
| [RoundDownToTickSize()](rounddowntoticksize-1.md) | Rounds the value down to the nearest valid value |
| [Splits](splits-1.md) | A collection of splits for stock instruments |
| [TickSize](ticksize-1.md) | The smallest movement in price configured |
| [Url](url-1.md) | A web url where contract details have been collected |
