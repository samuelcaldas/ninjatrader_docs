
NinjaScript > Language Reference > Common > Instruments

Instruments

| << [Click to Display Table of Contents](instruments_ninjascript.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Instruments | [Previous page](removedrawobjects.md) [Return to chapter overview](common.md) [Next page](instrument.md) |
| --- | --- |
## Definition
A collection of [Instrument](instrument.md) objects currently used by a script.
 
## Property Value
An array of Instrument objects
 
## Syntax
Instruments[]
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.DataLoaded)    {        // Print all instruments which have been loaded        foreach (Instrument i in Instruments)        {            Print(i.FullName);        }    } } |
