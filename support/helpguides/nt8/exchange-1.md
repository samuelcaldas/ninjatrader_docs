



Exchange

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\exchange.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) >  Exchange | [Previous page](instrument-1.htm) [Return to chapter overview](instrument-1.htm) [Next page](expiry-1.htm) |

Definition
----------

Indicates the current exchange of an instrument

Property Value
--------------

Represents the exchange which is selected for the current instrument.

Syntax
------

Instrument.Exchange

 

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // Print the exchange of the currently configured instrument     Print(String.Format("Configured instrument is on the {0} exchange", Instrument.Exchange));  } |

Additional Access Information 
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument != null)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------