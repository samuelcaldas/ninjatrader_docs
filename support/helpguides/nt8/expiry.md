
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> Expiry

Expiry
| \<\< [Click to Display Table of Contents](expiry.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> Expiry | [Previous page](exchange.md) [Return to chapter overview](instrument.md) [Next page](instrument_fullname.md) |
| --- | --- |
## Definition
Indicates the expiration month of a futures contract.
 
## Property Value
A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure representing the expiration month of a futures contract.
 
## Syntax
Instrument.Expiry
 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    // Print the expiry of the currently configured futures instrument    Print(String.Format("You are viewing the {0} contract", Instrument.Expiry)); } |

## 
 
## Additional Access Information
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument !\= null)
