
NinjaScript \> Language Reference \> Add On \> NinjaTrader Controls \> IntervalSelector
IntervalSelector
| \<\< [Click to Display Table of Contents](intervalselector.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [NinjaTrader Controls](controls-1.md) \> IntervalSelector | [Previous page](instrumentselector-1.md) [Return to chapter overview](controls-1.md) [Next page](tifselector-1.md) |
| --- | --- |
## Definition
IntervalSelector is as a UI element users can interact with for selecting intervals. This can be used with interval linking between windows.     
 
## Events and Properties
| Cleanup() | Disposes of the IntervalSelector (Note: calling the [NTTabPage base.Cleanup()](nttabpage_cleanup-1.md) is sufficient to clean up this control) |
| --- | --- |
| Interval | A BarsPeriod representing the interval currently selected |
| IntervalChanged | Event handler for when the interval changed |

## Examples
This example demonstrates how to use the interval selector and properly link its behavior to windows linking.
 
| C\# |
| --- |
| private IntervalSelector   intervalSelector;           private DependencyObject LoadXAML() {      // Note: pageContent (not demonstrated in this example) is the page content of the XAML        // Find the Interval selector      intervalSelector \= LogicalTreeHelper.FindLogicalNode(pageContent, "intervalSelector") as IntervalSelector;      if (intervalSelector !\= null)           intervalSelector.IntervalChanged \+\= OnIntervalChanged;       }   // This method is fired when our interval selector changes intervals private void OnIntervalChanged(object sender, BarsPeriodEventArgs e) {      if (e.BarsPeriod \=\= null)          return; }   /\* IIntervalProvider member. Required if you want to use the interval linker mechanism on this window. No functionality has been linked to the interval linker in this sample. \*/ public BarsPeriod BarsPeriod { get; set; }   // NOTE: Don't forget to clean up resources and unsubscribe to events // Called by TabControl when tab is being removed or window is closed public override void Cleanup() {      // Clean up our resources      if (intervalSelector !\= null)           intervalSelector.IntervalChanged \-\= OnIntervalChanged;        base.Cleanup(); } |

| XAML |
| --- |
| \<Page        xmlns\="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  xmlns:x\="http://schemas.microsoft.com/winfx/2006/xaml"  xmlns:Tools\="clr\-namespace:NinjaTrader.Gui.Tools;assembly\=NinjaTrader.Gui"  xmlns:AccountPerformance\="clr\-namespace:NinjaTrader.Gui.AccountPerformance;assembly\=NinjaTrader.Gui"   xmlns:AccountData\="clr\-namespace:NinjaTrader.Gui.AccountData;assembly\=NinjaTrader.Gui"   xmlns:AtmStrategy\="clr\-namespace:NinjaTrader.Gui.NinjaScript.AtmStrategy;assembly\=NinjaTrader.Gui"\>   \<Grid\>      \<Grid.ColumnDefinitions\>           \<ColumnDefinition Width\="Auto"/\>           \<ColumnDefinition Width\="\*"/\>      \</Grid.ColumnDefinitions\>        \<Tools:IntervalSelector x:Name\="intervalSelector" Grid.Column\="0" HorizontalAlignment\="Left"/\> \</Grid\> |
