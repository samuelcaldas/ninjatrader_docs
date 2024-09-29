


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> FullName






















FullName







| \<\< [Click to Display Table of Contents](instrument_fullname.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> FullName | [Previous page](expiry.md) [Return to chapter overview](instrument.md) [Next page](getinstrument.md) |
| --- | --- |











## Definition


Indicates the full NinjaTrader name of an instrument. For futures, this would include the expiration date. The September S\&P 500 Emini contract full name is "ES 09\-16".


 


## Property Value


A string representing the full name of the instrument.


 


## Syntax


Instrument.FullName


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // Print the full name (including contract month) of the configured instrument    Print(String.Format("{0} is being used as the input series", Instrument.FullName)); } |



## 


 


## Additional Access Information
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument !\= null)








