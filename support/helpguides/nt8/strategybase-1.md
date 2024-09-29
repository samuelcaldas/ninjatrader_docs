


NinjaScript \> Language Reference \> Add On \> StrategyBase






















StrategyBase







| \<\< [Click to Display Table of Contents](strategybase.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> StrategyBase | [Previous page](startatmstrategy-1.md) [Return to chapter overview](add_on-1.md) [Next page](propagateinstrumentchange()-1.md) |
| --- | --- |











StrategyBase contains properties and methods for managing a [Strategy](strategy-1.md) object, and is the base class from which [AtmStrategy](atmstrategy-1.md) derives. 


 




| Note:  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.md) |
| --- |



 


## 


## Example




| ns |
| --- |
| // A button called acctStratButton in an NTTabPage displays all ATM and NinjaScript strategies configured on a selected Account when clicked private void OnButtonClick(object sender, RoutedEventArgs e) {    Button button \= sender as Button;         if (button !\= null \&\& ReferenceEquals(button, acctStratButton))    {        // When the button is pressed, iterate through all ATM and NinjaScript strategies        // This comprises all which are active, recovered upon last connect, or deactived since last connect        // First, lock the Strategies collection to avoid in\-flight changes to the collection affecting our output        lock (accountSelector.SelectedAccount.Strategies)            // Iterate through the Strategies collection in the selected Account            foreach (StrategyBase strategy in accountSelector.SelectedAccount.Strategies)                outputBox.AppendText(string.Format("{0}Name: {1}{0}ATM Template Name: {2}{0}Instrument: {3}{0}State: {4}{0}Category: {5}{0}",                    Environment.NewLine,                    strategy.Name,                    strategy.Template,                    strategy.Instruments\[0].FullName,                          strategy.State,                    strategy.Category));    } } |









