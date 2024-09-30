
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > MergePolicy

MergePolicy

| << [Click to Display Table of Contents](mergepolicy.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Instruments](instruments_ninjascript-1.md) > [Instrument](instrument-1.md) > [MasterInstrument](masterinstrument-1.md) > MergePolicy | [Previous page](instrumenttype-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](masterinstrument_name-1.md) |
| --- | --- |
## Definition
Indicates the Merge Policy configured for the [Master Instrument properties](editing_instruments-1.md).
## 
## Property Value
Represents the MergePolicy that is configured for the current master instrument.
 
Possible values are:
 

| DoNotMerge | No merge policy is applied |
| --- | --- |
| MergeBackAdjusted | Merge policy is applied between contracts along with rollover offsets |
| MergeNonBackAdjusted | Merge policy is applied between contracts without offsets |
| UseGlobalSettings | Uses the value configured from Tools -> Options -> Market Data |
 
## Syntax
Bars.Instrument.MasterInstrument.MergePolicy
 
## Examples

| ns |
| --- |
| //Prints a warning, indicating what merge policy is in use if not using global settings if (Bars.Instrument.MasterInstrument.MergePolicy != MergePolicy.UseGlobalSettings) {  Print("Warning: Instrument has merge policy of " + Bars.Instrument.MasterInstrument.MergePolicy); } |
