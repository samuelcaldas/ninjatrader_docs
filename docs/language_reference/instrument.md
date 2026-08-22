# Instrument

## Definition

A tradable symbol.  Represents an instance of a [[[Master Instrument](masterinstrument.md)

> **Warning:** The properties in this class should NOT be accessed within the [[[OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded

## Methods and Properties

|  |  |
| --- | --- |
| [[[Exchange](exchange.md) | Exchange of the current instrument |
| [[[Expiry](expiry.md) | Expiration date of the futures contract |
| [[[FullName](instrument_fullname.md) | Full name of the instrument |
| [[[GetInstrument()](getinstrument.md) | Returns an Instrument object by the master instrument name configured in the database. |
| [[[MasterInstrument](masterinstrument.md) | An instrument's configuration settings.  These are settings and properties which are defined in the [[[Instrument](instruments.md) window. |
| FundmentalData | Instrument thread specific [[[FundamentalData](../addons/fundamentaldata.md) events |
| MarketData | Instrument thread specific [[[MarketData](../addons/marketdata.md) events |
| MarketDepth | Instrument thread specific [[[MarketDepth](../addons/marketdepth.md) events |
| Dispatcher | A Dispatcher used for subscribing to Instrument related events See [[[Multi-Threading Considerations](../ninjascript/multi-threading.md) |
