
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> GetInstrument()
GetInstrument()
| \<\< [Click to Display Table of Contents](getinstrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> GetInstrument() | [Previous page](instrument_fullname-1.md) [Return to chapter overview](instrument-1.md) [Next page](masterinstrument-1.md) |
| --- | --- |
## Definition
Returns an [Instrument](instruments-1.md) object by the master instrument name configured in the database.  
 
| Note:  This method does NOT add additional data for real\-time or historical processing.  For adding an additional data to your script, please see the  [AddDataSeries()](adddataseries-1.md) method. |
| --- |
## 
## 
## Method Return Value
An [Instrument](instrument-1.md) object
 
## Syntax
Instrument.GetInstrument(string instrumentName)
 
## Parameters
| instrumentName | A string value representing a name of an instrument |
| --- | --- |
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.Historical)    {      Instrument myInstrument \= Instrument.GetInstrument("AAPL");        Print("AAPL's tick size is " \+ myInstrument.MasterInstrument.TickSize.ToString());    } } |

