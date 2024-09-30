
NinjaScript > Language Reference > Common > Instruments

Instruments

| << [Click to Display Table of Contents](instruments_ninjascript.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > Instruments | [Previous page](removedrawobjects-1.md) [Return to chapter overview](common-1.md) [Next page](instrument-1.md) |
| --- | --- |
## Definition
A collection of [Instrument](instrument-1.md) objects currently used by a script.
 
## Property Value
An array of Instrument objects
 
## Syntax
Instruments[]
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.DataLoaded)    {        // Print all instruments which have been loaded        foreach (Instrument i in Instruments)        {            Print(i.FullName);        }    } } |
