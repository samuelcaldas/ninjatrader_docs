
NinjaScript > Language Reference > Common > Instruments > Instrument > Expiry

Expiry
| << [Click to Display Table of Contents](expiry.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Instruments](instruments_ninjascript-1.md) > [Instrument](instrument-1.md) > Expiry | [Previous page](exchange-1.md) [Return to chapter overview](instrument-1.md) [Next page](instrument_fullname-1.md) |
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
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument != null)
