# PropagateInstrumentChange()

﻿

    NinjaScript > Language Reference > Add On > PropagateInstrumentChange()

PropagateInstrumentChange()

## Definition

In an [NTWindow](../addons/ntwindow.md), PropagateInstrumentChange() sends an Instrument to other windows with the same Instrument Linking color configured.

 

[](../addons/developing_add_ons.md)

> **Note:** Notes:
•A public Instrument property must be defined in order to use PropagateInstrumentChange(), as in the example below•For a complete, working example of this class in use, download framework example located on our Developing AddOns Overview

##  

## Example

##

|  |
| --- |
| // IInstrumentProvider member. Required if you want to use the instrument link mechanism on an NTWindow.<br>public Cbi.Instrument Instrument<br>{<br>    get { return instrument; }<br>    set<br>    {<br>        // Process logic related to switching instruments, such as:<br>        // Unsubscribe to subscriptions to old instruments...<br>        // Subscribe for the new instrument...<br>        // Change the value displayed in an Instrument Selector in the NTWindow...<br>        // Update the tab header name on AddOnFramework to be the same name as the new instrument...<br>        // etc...<br> <br>        // Send instrument to other windows linked to the same color<br>        PropagateInstrumentChange(value);<br>    }<br>} |