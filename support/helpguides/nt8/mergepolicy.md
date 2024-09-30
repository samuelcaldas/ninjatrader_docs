
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > MergePolicy

MergePolicy

| << [Click to Display Table of Contents](mergepolicy.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Instruments](instruments_ninjascript.md) > [Instrument](instrument.md) > [MasterInstrument](masterinstrument.md) > MergePolicy | [Previous page](instrumenttype.md) [Return to chapter overview](masterinstrument.md) [Next page](masterinstrument_name.md) |
| --- | --- |
## Definition
Indicates the Merge Policy configured for the [Master Instrument properties](editing_instruments.md).
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
