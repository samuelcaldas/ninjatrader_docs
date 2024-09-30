
NinjaScript \> Language Reference \> Add On \> NinjaTrader Controls \> AtmStrategySelector
AtmStrategySelector
| \<\< [Click to Display Table of Contents](atmstrategyselector.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [NinjaTrader Controls](controls.md) \> AtmStrategySelector | [Previous page](accountselector.md) [Return to chapter overview](controls.md) [Next page](instrumentselector.md) |
| --- | --- |
## Definition
AtmStrategySelector is an UI element users can interact with for selecting ATM Strategies.
 
## Events and Properties
| Cleanup() | Disposes of the AtmStrategySelector  (Note: calling the [NTTabPage base.Cleanup()](nttabpage_cleanup.md) is sufficient to clean up this control) |
| --- | --- |
| CustomPropertiesChanged | Event handler for when properties have changed on the ATM strategy |
| Id | A string identifying the ATM Strategy selector |
| SelectedAtmStrategy | Returns an AtmStrategy representing the selected ATM strategy |
| SelectionChanged | Event handler for when the selected ATM strategy has changed |

## Examples
This example demonstrates how to use the ATM strategy selector and properly link its behavior with the quantity up/down and TIF selectors.
 
## Examples
| C\# |
| --- |
| private QuantityUpDown                  qudSelector; private TifSelector                     tifSelector; private AtmStrategy.AtmStrategySelector atmStrategySelector;   private DependencyObject LoadXAML() {      // Note: pageContent (not demonstrated in this example) is the page content of the XAML      // Find the Quantity Up\-Down selector      qudSelector \= LogicalTreeHelper.FindLogicalNode(pageContent, "qudSelector") as QuantityUpDown;        // Find the TIF selector      tifSelector \= LogicalTreeHelper.FindLogicalNode(pageContent, "tifSelector") as TifSelector;        // Be sure to bind our account selector to our TIF selector to ensure proper functionality      tifSelector.SetBinding(TifSelector.AccountProperty, new Binding { Source \= accountSelector,           Path \= new PropertyPath("SelectedAccount") });        // When our TIF selector's selection changes      tifSelector.SelectionChanged \+\= (o, args) \=\>      {           // Change the selected TIF in the ATM strategy too          if (atmStrategySelector.SelectedAtmStrategy !\= null)                atmStrategySelector.SelectedAtmStrategy.TimeInForce \= tifSelector.SelectedTif;      };        // Find ATM Strategy selector and attach event handler      atmStrategySelector \= LogicalTreeHelper.FindLogicalNode(pageContent, "atmStrategySelector") as AtmStrategy.AtmStrategySelector;      atmStrategySelector.Id \= Guid.NewGuid().ToString("N");      if (atmStrategySelector !\= null)           atmStrategySelector.CustomPropertiesChanged \+\= OnAtmCustomPropertiesChanged;        // Be sure to bind our account selector to our ATM strategy selector to ensure proper functionality      atmStrategySelector.SetBinding(AtmStrategy.AtmStrategySelector.AccountProperty,          new Binding { Source \= accountSelector, Path \= new PropertyPath("SelectedAccount") });        // When our ATM selector's selection changes      atmStrategySelector.SelectionChanged \+\= (o, args) \=\>      {          if (atmStrategySelector.SelectedItem \=\= null)                return;          if (args.AddedItems.Count \> 0\)           {                // Change the selected TIF in our TIF selector too                AtmStrategy selectedAtmStrategy \= args.AddedItems\[0] as AtmStrategy;                if (selectedAtmStrategy !\= null)                     tifSelector.SelectedTif \= selectedAtmStrategy.TimeInForce;          }  }; }   private void OnAtmCustomPropertiesChanged(object sender, NinjaScript.AtmStrategy.CustomPropertiesChangedEventArgs args) {      // Adjust our TIF and Quantity selectors to the new ATM strategy values      tifSelector.SelectedTif \= args.NewTif;      qudSelector.Value \= args.NewQuantity; }   // NOTE: Don't forget to clean up resources and unsubscribe to events // Called by TabControl when tab is being removed or window is closed public override void Cleanup() {     // Clean up our resources      base.Cleanup(); } |

| XAML |
| --- |
| \<AtmStrategy:AtmStrategySelector x:Name\="atmStrategySelector" LinkedQuantity\="{Binding ElementName\=qudSelector, Path\=Value, Mode\=OneWay}" Grid.Row\="12" Grid.Column\="2"\>      \<AtmStrategy:AtmStrategySelector.Margin\>              \<Thickness Left\="{StaticResource MarginButtonLeft}" Top\="{StaticResource MarginControl}" Right\="{StaticResource MarginBase}" Bottom\="0" /\>      \</AtmStrategy:AtmStrategySelector.Margin\> \</AtmStrategy:AtmStrategySelector\> |

