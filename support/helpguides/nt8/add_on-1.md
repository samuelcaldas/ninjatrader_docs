
NinjaScript \> Language Reference \> Add On
Add On
| \<\< [Click to Display Table of Contents](add_on.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> Add On | [Previous page](triggercustomevent-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](controls-1.md) |
| --- | --- |
Custom Add Ons can be used to extend NinjaTrader's functionality. The methods and properties covered in this section are unique to custom Add On development.
 
For more information on the Add On development process please see [this](developing_add_ons-1.md) article.

| [NinjaTrader Controls](controls-1.md) | This section contains controls that are native NinjaTrader controls. |
| --- | --- |
| [Account](account_class-1.md) | The Account class can be used to subscribe to account related events as well as accessing account related information. |
| [BarsRequest](barsrequest-1.md) | BarsRequest can be used to request [Bars](bars-1.md) data and subscribe to real\-time Bars data events. |
| [Connection](connection_class-1.md) | The Connection class can be used to monitor connection related events as well as accessing connection related information. |
| [IInstrumentProvider Interface](iinstrumentprovider_interface-1.md) | When creating your [NTTabPage](nttabpage_class-1.md), if you wish to use the [instrument link](linking_windows-1.md), be sure to implement the IInstrumentProvider interface. |
| [IIntervalProvider Interface](iintervalprovider_interface-1.md) | When creating your [NTTabPage](nttabpage_class-1.md), if you wish to use the [interval link](linking_windows-1.md), be sure to implement the IIntervalProvider interface. |
| [INTTabFactory Interface](inttabfactory_class-1.md) | If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the INTTabFactory interface. |
| [IWorkspacePersistence Interface](iworkspacepersistence_interface-1.md) | When creating your [NTWindow](ntwindow-1.md), be sure to implement the IWorkspacePersistence interface as well for the ability to save and restore your window with NinjaTrader workspaces. |
| [NTTabPage Class](nttabpage_class-1.md) | This is where the actual content for tabs inside the custom add on [NTWindow](ntwindow-1.md) can be defined. |
| [Alert and Debug Concepts](alert_and_debug_concepts-1.md) | In most scenarios you can use the NinjaScript provided methods for triggering alerts and debugging functionality. However, when building your own custom objects, you may find yourself wanting to use this functionality outside the NinjaScript scope. |
| [AtmStrategy](atmstrategy-1.md) | AtmStrategy contains properties and methods used to manage [ATM Strategies](advanced_trade_management_atm-1.md). |
| [ControlCenter](controlcenter-1.md) | ControlCenter is a XAML\-defined class containing the layout and properties of the Control Center window. |
| [FundamentalData](fundamentaldata-1.md) | FundamentalData is used to access fundamental snapshot data and for subscribing to fundamental data events. |
| [MarketData](marketdata-1.md) | MarketData can be used to access snapshot market data and for subscribing to market data events. |
| [MarketDepth](marketdepth-1.md) | MarketDepth can be used to access snapshot market depth and for subscribing to market depth events. |
| [NewsItems](newsitems-1.md) | NewsItems can be used to store news articles. |
| [NewsSubscription](newssubscription-1.md) | NewsSubscription can be used for subscribing to News events. |
| [NTMenuItem](ntmenuitem-1.md) | NTMenuItem is used to create new menu entries. |
| [NTWindow](ntwindow-1.md) | The NTWindow class defines parent windows for custom window creation. Instances of NTWindow act as containers for instances of [NTTabPage](nttabpage_class-1.md), in which UI elements and their related logic are contained. |
| [NumericTextBox](numerictextbox-1.md) | NumericTextBox provides functionality for numeric text boxes to capture user input. |
| [OnWindowCreated()](onwindowcreated-1.md) | This method is called whenever a new [NTWindow](ntwindow-1.md) is created. |
| [OnWindowDestroyed()](onwindowdestroyed-1.md) | This method is called whenever a new [NTWindow](ntwindow-1.md) is destroyed. |
| [OnWindowRestored()](onwindowrestored-1.md) | This method is used to recall any custom XElement data from the workspace by referencing a window. |
| [OnWindowSaved()](onwindowsaved-1.md) | This method is used to save any custom XElement data associated with your window. |
| [StartAtmStrategy()](startatmstrategy-1.md) | StartAtmStrategy can be used to submit entry orders with ATM strategies. |
| [StrategyBase](strategybase-1.md) | StrategyBase contains properties and methods for managing a [Strategy](strategy-1.md) object, and is the base class from which [AtmStrategy](atmstrategy-1.md) derives. |
| [PropagateInstrumentChange()](propagateinstrumentchange()-1.md) | In an [NTWindow](ntwindow-1.md), PropagateInstrumentChange() sends an Instrument to other windows with the same Instrument Linking color configured. |
| [PropagateIntervalChange()](propagateintervalchange()-1.md) | In an [NTWindow](ntwindow-1.md), PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured. |
| [TabControl](tabcontrol-1.md) | The TabControl class provides functionality for working with [NTTabPage](nttabpage_class-1.md) objects within an [NTWindow](ntwindow-1.md). |
| [TabControlManager](tabcontrolmanager-1.md) | The TabControlManager class can be used to set or check several properties of a [TabControl](tabcontrol-1.md) object. |

