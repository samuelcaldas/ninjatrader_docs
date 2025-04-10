



Add On

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\add_on.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) >  Add On | [Previous page](triggercustomevent-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](controls-1.md) |

Custom Add Ons can be used to extend NinjaTrader's functionality. The methods and properties covered in this section are unique to custom Add On development.

For more information on the Add On development process please see [this](developing_add_ons-1.md) article.

|  |  |
| --- | --- |
| NinjaTrader Controls | This section contains controls that are native NinjaTrader controls. |
| Account | The Account class can be used to subscribe to account related events as well as accessing account related information. |
| BarsRequest | Bars data and subscribe to real-time Bars data events. |
| Connection | The Connection class can be used to monitor connection related events as well as accessing connection related information. |
| IInstrumentProvider Interface | instrument link, be sure to implement the IInstrumentProvider interface. |
| IIntervalProvider Interface | interval link, be sure to implement the IIntervalProvider interface. |
| INTTabFactory Interface | If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the INTTabFactory interface. |
| IWorkspacePersistence Interface | NTWindow, be sure to implement the IWorkspacePersistence interface as well for the ability to save and restore your window with NinjaTrader workspaces. |
| NTTabPage Class | NTWindow can be defined. |
| Alert and Debug Concepts | In most scenarios you can use the NinjaScript provided methods for triggering alerts and debugging functionality. However, when building your own custom objects, you may find yourself wanting to use this functionality outside the NinjaScript scope. |
| AtmStrategy | ATM Strategies. |
| ControlCenter | ControlCenter is a XAML-defined class containing the layout and properties of the Control Center window. |
| FundamentalData | FundamentalData is used to access fundamental snapshot data and for subscribing to fundamental data events. |
| MarketData | MarketData can be used to access snapshot market data and for subscribing to market data events. |
| MarketDepth | MarketDepth can be used to access snapshot market depth and for subscribing to market depth events. |
| NewsItems | NewsItems can be used to store news articles. |
| NewsSubscription | NewsSubscription can be used for subscribing to News events. |
| NTMenuItem | NTMenuItem is used to create new menu entries. |
| NTWindow | NTTabPage, in which UI elements and their related logic are contained. |
| NumericTextBox | NumericTextBox provides functionality for numeric text boxes to capture user input. |
| OnWindowCreated() | NTWindow is created. |
| OnWindowDestroyed() | NTWindow is destroyed. |
| OnWindowRestored() | This method is used to recall any custom XElement data from the workspace by referencing a window. |
| OnWindowSaved() | This method is used to save any custom XElement data associated with your window. |
| StartAtmStrategy() | StartAtmStrategy can be used to submit entry orders with ATM strategies. |
| StrategyBase | AtmStrategy derives. |
| PropagateInstrumentChange() | NTWindow, PropagateInstrumentChange() sends an Instrument to other windows with the same Instrument Linking color configured. |
| PropagateIntervalChange() | NTWindow, PropagateIntervalChange() sends an interval to other windows with the same Interval Linking color configured. |
| TabControl | NTWindow. |
| TabControlManager | TabControl object. |