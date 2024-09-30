
NinjaScript \> Language Reference \> Add On \> PropagateIntervalChange()

PropagateIntervalChange()

| \<\< [Click to Display Table of Contents](propagateintervalchange().md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> PropagateIntervalChange() | [Previous page](propagateinstrumentchange().md) [Return to chapter overview](add_on.md) [Next page](tabcontrol.md) |
| --- | --- |
## Definition
In an [NTWindow](ntwindow.md), PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured. 
 

| Notes:  1\.A public Instrument property must be defined in order to use PropagateInstrumentChange(), as in the example below2\.For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons.md) |
| --- |
## 
## Example

| ns |
| --- |
| // This custom method will be fired when an interval selector in a custom NTTabPage changes intervals private void OnIntervalChanged(object sender, BarsPeriodEventArgs args) {    if (args.BarsPeriod \=\= null)        return;      PropagateIntervalChange(args.BarsPeriod); } |
