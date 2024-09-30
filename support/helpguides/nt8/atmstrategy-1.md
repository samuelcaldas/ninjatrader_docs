
NinjaScript \> Language Reference \> Add On \> AtmStrategy

AtmStrategy
| \<\< [Click to Display Table of Contents](atmstrategy.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> AtmStrategy | [Previous page](alert_rearmalert()-1.md) [Return to chapter overview](add_on-1.md) [Next page](controlcenter-1.md) |
| --- | --- |
AtmStrategy contains properties and methods used to manage [ATM Strategies](advanced_trade_management_atm-1.md). When working with an [AtmStrategySelector](atmstrategyselector-1.md), selected objects can be case to AtmStrategy to obtain or change their properties.
 
| Notes:  1\. For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.md) 2\. For more information on working with the ATM strategies programmatically in general, please see the [Using ATM Strategies](using_atm_strategies-1.md) section. |
| --- |

## 
## 
## Example
| ns |
| --- |
| // Using AtmStrategy to handle user selections in an ATM Strategy Selector myAtmStrategySelector.SelectionChanged \+\= (o, args) \=\> {    if (myAtmStrategySelector.SelectedItem \=\= null)        return;    if (args.AddedItems.Count \> 0)    {        // Change the selected TIF in a TIF selector based on what is selected in the ATM Strategy Selector         NinjaTrader.NinjaScript.AtmStrategy selectedAtmStrategy \= args.AddedItems\[0] as NinjaTrader.NinjaScript.AtmStrategy;        if (selectedAtmStrategy !\= null)        {            myTifSelector.SelectedTif \= selectedAtmStrategy.TimeInForce;        }    } }; |
