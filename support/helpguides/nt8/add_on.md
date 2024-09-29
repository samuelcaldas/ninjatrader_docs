


NinjaScript \> Language Reference \> Add On






















Add On







| \<\< [Click to Display Table of Contents](add_on.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> Add On | [Previous page](triggercustomevent.md) [Return to chapter overview](language_reference_wip.md) [Next page](controls.md) |
| --- | --- |











Custom Add Ons can be used to extend NinjaTrader's functionality. The methods and properties covered in this section are unique to custom Add On development.


 


For more information on the Add On development process please see [this](developing_add_ons.md) article.


 


 




| [NinjaTrader Controls](controls.md) | This section contains controls that are native NinjaTrader controls. |
| --- | --- |
| [Account](account_class.md) | The Account class can be used to subscribe to account related events as well as accessing account related information. |
| [BarsRequest](barsrequest.md) | BarsRequest can be used to request [Bars](bars.md) data and subscribe to real\-time Bars data events. |
| [Connection](connection_class.md) | The Connection class can be used to monitor connection related events as well as accessing connection related information. |
| [IInstrumentProvider Interface](iinstrumentprovider_interface.md) | When creating your [NTTabPage](nttabpage_class.md), if you wish to use the [instrument link](linking_windows.md), be sure to implement the IInstrumentProvider interface. |
| [IIntervalProvider Interface](iintervalprovider_interface.md) | When creating your [NTTabPage](nttabpage_class.md), if you wish to use the [interval link](linking_windows.md), be sure to implement the IIntervalProvider interface. |
| [INTTabFactory Interface](inttabfactory_class.md) | If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the INTTabFactory interface. |
| [IWorkspacePersistence Interface](iworkspacepersistence_interface.md) | When creating your [NTWindow](ntwindow.md), be sure to implement the IWorkspacePersistence interface as well for the ability to save and restore your window with NinjaTrader workspaces. |
| [NTTabPage Class](nttabpage_class.md) | This is where the actual content for tabs inside the custom add on [NTWindow](ntwindow.md) can be defined. |
| [Alert and Debug Concepts](alert_and_debug_concepts.md) | In most scenarios you can use the NinjaScript provided methods for triggering alerts and debugging functionality. However, when building your own custom objects, you may find yourself wanting to use this functionality outside the NinjaScript scope. |
| [AtmStrategy](atmstrategy.md) | AtmStrategy contains properties and methods used to manage [ATM Strategies](advanced_trade_management_atm.md). |
| [ControlCenter](controlcenter.md) | ControlCenter is a XAML\-defined class containing the layout and properties of the Control Center window. |
| [FundamentalData](fundamentaldata.md) | FundamentalData is used to access fundamental snapshot data and for subscribing to fundamental data events. |
| [MarketData](marketdata.md) | MarketData can be used to access snapshot market data and for subscribing to market data events. |
| [MarketDepth](marketdepth.md) | MarketDepth can be used to access snapshot market depth and for subscribing to market depth events. |
| [NewsItems](newsitems.md) | NewsItems can be used to store news articles. |
| [NewsSubscription](newssubscription.md) | NewsSubscription can be used for subscribing to News events. |
| [NTMenuItem](ntmenuitem.md) | NTMenuItem is used to create new menu entries. |
| [NTWindow](ntwindow.md) | The NTWindow class defines parent windows for custom window creation. Instances of NTWindow act as containers for instances of [NTTabPage](nttabpage_class.md), in which UI elements and their related logic are contained. |
| [NumericTextBox](numerictextbox.md) | NumericTextBox provides functionality for numeric text boxes to capture user input. |
| [OnWindowCreated()](onwindowcreated.md) | This method is called whenever a new [NTWindow](ntwindow.md) is created. |
| [OnWindowDestroyed()](onwindowdestroyed.md) | This method is called whenever a new [NTWindow](ntwindow.md) is destroyed. |
| [OnWindowRestored()](onwindowrestored.md) | This method is used to recall any custom XElement data from the workspace by referencing a window. |
| [OnWindowSaved()](onwindowsaved.md) | This method is used to save any custom XElement data associated with your window. |
| [StartAtmStrategy()](startatmstrategy.md) | StartAtmStrategy can be used to submit entry orders with ATM strategies. |
| [StrategyBase](strategybase.md) | StrategyBase contains properties and methods for managing a [Strategy](strategy.md) object, and is the base class from which [AtmStrategy](atmstrategy.md) derives. |
| [PropagateInstrumentChange()](propagateinstrumentchange().md) | In an [NTWindow](ntwindow.md), PropagateInstrumentChange() sends an Instrument to other windows with the same Instrument Linking color configured. |
| [PropagateIntervalChange()](propagateintervalchange().md) | In an [NTWindow](ntwindow.md), PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured. |
| [TabControl](tabcontrol.md) | The TabControl class provides functionality for working with [NTTabPage](nttabpage_class.md) objects within an [NTWindow](ntwindow.md). |
| [TabControlManager](tabcontrolmanager.md) | The TabControlManager class can be used to set or check several properties of a [TabControl](tabcontrol.md) object. |









