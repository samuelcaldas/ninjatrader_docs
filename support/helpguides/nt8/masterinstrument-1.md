



MasterInstrument

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\masterinstrument.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) >  MasterInstrument | [Previous page](getinstrument-1.htm) [Return to chapter overview](instrument-1.htm) [Next page](compare-1.htm) |

Definition
----------

An instrument's configuration settings.  These are settings and properties which are defined in the [Instrument](instruments-1.htm) window.

|  |
| --- |
| Warning:  The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange-1.htm) method before the State has reached State.DataLoaded. |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [Compare()](compare-1.htm) | Returns an int value compares two price values with respect to the Instrument tick size |
| [Currency](currency-1.htm) | The currency that the instrument traded in |
| [Description](masterinstrument_description-1.htm) | A  written representation of a given instrument |
| [Dividends](dividends-1.htm) | A collection of dividends for stock instruments |
| [Exchanges](exchanges-1.htm) | A collection of exchanges configured for an instrument |
| [FormatPrice()](formatprice-1.htm) | Returns a string representing the price formatted to the nearest tick size |
| [InstrumentType](instrumenttype-1.htm) | The type of instrument |
| [MergePolicy](mergepolicy-1.htm) | The Merge Policy that is configured for the current master instrument. |
| [Name](masterinstrument_name-1.htm) | The name of the instrument. |
| [GetNextExpiry()](getnextexpiry-1.htm) | Returns a DateTime structure representing the next futures expiry for a given date |
| [PointValue](pointvalue-1.htm) | Currency value of 1 full point of movement |
| [RolloverCollection](rollovercollection-1.htm) | A collection of expiration dates and offsets for futures instruments |
| [RoundToTickSize()](roundtoticksize-1.htm) | Rounds the value up to the nearest valid value |
| [RoundDownToTickSize()](rounddowntoticksize-1.htm) | Rounds the value down to the nearest valid value |
| [Splits](splits-1.htm) | A collection of splits for stock instruments |
| [TickSize](ticksize-1.htm) | The smallest movement in price configured |
| [Url](url-1.htm) | A web url where contract details have been collected |