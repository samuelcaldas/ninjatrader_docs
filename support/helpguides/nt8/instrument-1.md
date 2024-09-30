
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument
Instrument
| \<\< [Click to Display Table of Contents](instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> Instrument | [Previous page](instruments_ninjascript-1.md) [Return to chapter overview](instruments_ninjascript-1.md) [Next page](exchange-1.md) |
| --- | --- |
## Definition
A tradable symbol.  Represents an instance of a [Master Instrument](masterinstrument-1.md)
 
| Warning: The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |

## Methods and Properties
| [Exchange](exchange-1.md) | Exchange of the current instrument |
| --- | --- |
| [Expiry](expiry-1.md) | Expiration date of the futures contract |
| [FullName](instrument_fullname-1.md) | Full name of the instrument |
| [GetInstrument()](getinstrument-1.md) | Returns an Instrument object by the master instrument name configured in the database. |
| [MasterInstrument](masterinstrument-1.md) | An instrument's configuration settings.  These are settings and properties which are defined in the [Instrument](instruments-1.md) window. |
| FundmentalData | Instrument thread specific [FundamentalData](fundamentaldata-1.md) events |
| MarketData | Instrument thread specific [MarketData](marketdata-1.md) events |
| MarketDepth | Instrument thread specific [MarketDepth](marketdepth-1.md) events |
| Dispatcher | A Dispatcher used for subscribing to Instrument related events See [Multi\-Threading Considerations](multi-threading-1.md) |

