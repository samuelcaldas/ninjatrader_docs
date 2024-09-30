
NinjaScript \> Language Reference \> Add On \> PropagateIntervalChange()

PropagateIntervalChange()

| \<\< [Click to Display Table of Contents](propagateintervalchange().md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> PropagateIntervalChange() | [Previous page](propagateinstrumentchange()-1.md) [Return to chapter overview](add_on-1.md) [Next page](tabcontrol-1.md) |
| --- | --- |
## Definition
In an [NTWindow](ntwindow-1.md), PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured. 
 

| Notes:  1\.A public Instrument property must be defined in order to use PropagateInstrumentChange(), as in the example below2\.For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.md) |
| --- |
## 
## Example

| ns |
| --- |
| // This custom method will be fired when an interval selector in a custom NTTabPage changes intervals private void OnIntervalChanged(object sender, BarsPeriodEventArgs args) {    if (args.BarsPeriod \=\= null)        return;      PropagateIntervalChange(args.BarsPeriod); } |
