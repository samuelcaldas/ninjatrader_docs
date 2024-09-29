


NinjaScript \> Language Reference \> Add On \> NinjaTrader Controls \> InstrumentSelector






















InstrumentSelector







| \<\< [Click to Display Table of Contents](instrumentselector.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [NinjaTrader Controls](controls-1.md) \> InstrumentSelector | [Previous page](atmstrategyselector-1.md) [Return to chapter overview](controls-1.md) [Next page](intervalselector-1.md) |
| --- | --- |











## Definition


InstrumentSelector is a UI element users can interact with for selecting instruments. This can be used with instrument linking between windows.    


 


## Events and Properties




| Cleanup() | Disposes of the InstrumentSelector (Note: calling the [NTTabPage base.Cleanup()](nttabpage_cleanup-1.md) is sufficient to clean up this control) |
| --- | --- |
| Instrument | An Instrument representing the selected instrument |
| InstrumentChanged | Event handler for when the instrument changes on the instrument selector |



 


 


## Examples


This example demonstrates how to use the instrument selector and properly link its behavior to windows linking.


 




| C\# |
| --- |
| private InstrumentSelector instrumentSelector;   private DependencyObject LoadXAML() {      // Note: pageContent (not demonstrated in this example) is the page content of the XAML        // Find the Instrument selector      instrumentSelector \= LogicalTreeHelper.FindLogicalNode(pageContent, "instrumentSelector") as InstrumentSelector;      if (instrumentSelector !\= null)           instrumentSelector.InstrumentChanged \+\= OnInstrumentChanged; }   // This method is fired when our instrument selector changes instruments private void OnInstrumentChanged(object sender, EventArgs e) {      Instrument \= sender as Cbi.Instrument; }   // IInstrumentProvider member. Required if you want to use the instrument link mechanism in this Add On window public Cbi.Instrument Instrument {      get { return instrument }      set      {           instrument \= value;          if (instrumentSelector !\= null)                instrumentSelector.Instrument \= value;             // Send instrument to other windows linked to the same color           PropagateInstrumentChange(value);      } }   // NOTE: Don't forget to clean up resources and unsubscribe to events // Called by TabControl when tab is being removed or window is closed public override void Cleanup() {      // Clean up our resources      if (instrumentSelector !\= null)      {          instrumentSelector.InstrumentChanged \-\= OnInstrumentChanged;            }      base.Cleanup(); } |



 


 




| XAML |
| --- |
| \<Page        xmlns\="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  xmlns:x\="http://schemas.microsoft.com/winfx/2006/xaml"  xmlns:Tools\="clr\-namespace:NinjaTrader.Gui.Tools;assembly\=NinjaTrader.Gui"  xmlns:AccountPerformance\="clr\-namespace:NinjaTrader.Gui.AccountPerformance;assembly\=NinjaTrader.Gui"   xmlns:AccountData\="clr\-namespace:NinjaTrader.Gui.AccountData;assembly\=NinjaTrader.Gui"   xmlns:AtmStrategy\="clr\-namespace:NinjaTrader.Gui.NinjaScript.AtmStrategy;assembly\=NinjaTrader.Gui"\>   \<Grid\>      \<Grid.ColumnDefinitions\>           \<ColumnDefinition Width\="Auto"/\>           \<ColumnDefinition Width\="\*"/\>      \</Grid.ColumnDefinitions\>        \<Tools:InstrumentSelector x:Name\="instrumentSelector" Grid.Column\="0" LastUsedGroup\="MyAddOn"/\> \</Grid\> |









