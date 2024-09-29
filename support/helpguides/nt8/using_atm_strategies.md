


NinjaScript \> Educational Resources \> Using ATM Strategies






















Using ATM Strategies







| \<\< [Click to Display Table of Contents](using_atm_strategies.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> Using ATM Strategies | [Previous page](using_3rd_party_indicators.md) [Return to chapter overview](educational_resources.md) [Next page](using_bitmapimage_objects_with_buttons.md) |
| --- | --- |











You can create an automated strategy that generates a trade signal that executes a NinjaTrader [ATM Strategy](atm_strategy.md). 


 


•ATM Strategies operate in real\-time only and will not execute on historical data thus they can't be backtested 

•Executions resulting from an ATM Strategy that is created from within a NinjaScript automated strategy will not plot on a chart during real\-time operation 

•Strategy set up parameters such as [EntriesPerDirection](entriesperdirection.md), [EntryHandling](entryhandling.md), [IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy.md) do not apply when calling the [AtmStrategyCreate()](atmstrategycreate.md) method

•Executions from ATM Strategies will not have an impact on the hosting NinjaScript strategy position and PnL \- the NinjaScript strategy hands off the execution aspects to the ATM, thus no monitoring via the regular NinjaScript strategy methods will take place (also applies to strategy performance tracking)

•ATM Strategy stop orders can either be StopMarket or StopLimit orders, depending on which type is defined in the ATM Strategy Template ([Advanced Options](advanced_options.md)[)](advanced_options.md) you call in the [AtmStrategyCreate()](atmstrategycreate.md) method in your NinjaScript strategy. To make the distinction clear which is used, following a naming convention for the template name is highly suggested (i.e. AtmStrategyTemplate\_STPLMT)

•A general sample for calling ATM's is preinstalled with NinjaTrader under the 'SampleATMStrategy' script \- for a script showing how to implement reversal type setups, please see [this link](http://www.ninjatrader.com/support/forum/local_links.php?action=jump&catid=8&id=866) to our online resources.

 


## There is a Clear Line...


There is a clear line between a NinjaScript Strategy and an ATM Strategy. The use model for creating an ATM Strategy within a NinjaScript Strategy is when you want to programmatically monitor and generate an entry signal and then manualy manage the resulting open position via an ATM Strategy in one of NinjaTrader's order entry windows.


 


## !!! IMPORTANT: Manually Closing an ATM Strategy from an Order Entry Window such as the SuperDOM


It is crucial that when running ATM Strategies created by a NinjaScript strategy that you understand how to properly manually close the ATM Strategy from any of the order entry windows.


 


•If the order entry window [ATM Strategy Selection Mode](atm_strategy_selection_mode.md) is NOT in "DisplaySelectedATMStrategyOnly" click on the "CLOSE" button via your middle mouse button (scroll wheel) 

•If the order entry window ATM Strategy Selection Mode is in "DisplaySelectedATMStrategyOnly" you can click on the "CLOSE" button with your left mouse button to close the selected active ATM strategy 

 


Following the approaches above will internally close the ATM Strategy. Not following the approach will close the account/instrument position, terminate all strategies and cancel all orders. The result is that your NinjaScript strategy will be terminated.








