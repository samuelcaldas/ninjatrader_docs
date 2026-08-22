# PropagateIntervalChange()

﻿

    NinjaScript > Language Reference > Add On > PropagateIntervalChange()

PropagateIntervalChange()

## Definition

In an [NTWindow](../addons/ntwindow.md), PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured.

 

[](../addons/developing_add_ons.md)

> **Note:** Notes:
1.A public Instrument property must be defined in order to use PropagateInstrumentChange(), as in the example below2.For a complete, working example of this class in use, download framework example located on our Developing AddOns Overview

##  

## Example

##

|  |
| --- |
| // This custom method will be fired when an interval selector in a custom NTTabPage changes intervals<br>private void OnIntervalChanged(object sender, BarsPeriodEventArgs args)<br>{<br>    if (args.BarsPeriod == null)<br>        return;<br> <br>    PropagateIntervalChange(args.BarsPeriod);<br>} |