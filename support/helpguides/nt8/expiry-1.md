



Expiry

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\expiry.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) >  Expiry | [Previous page](exchange-1.htm) [Return to chapter overview](instrument-1.htm) [Next page](instrument_fullname-1.htm) |

Definition
----------

Indicates the expiration month of a futures contract.

Property Value
--------------

A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure representing the expiration month of a futures contract.

Syntax
------

Instrument.Expiry

 

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // Print the expiry of the currently configured futures instrument     Print(String.Format("You are viewing the {0} contract", Instrument.Expiry));  } |

Additional Access Information 
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument != null)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------