
Operations > Risk > Using the Risk window
Using the Risk window

| << [Click to Display Table of Contents](using_the_risk_window.md) >> **Navigation:**     [Operations](operations-1.md) > [Risk](understanding_risks-1.md) > Using the Risk window | [Previous page](understanding_risks-1.md) [Return to chapter overview](understanding_risks-1.md) [Next page](simulation-1.md) |
| --- | --- |
Within the Risk window, Risk Templates hold the risk definitions for local simulation accounts. A risk definition holds the amount of margin needed per contract, it also limits the amount of contracts allowed to trade. To define your Live or Simulation NinjaTrader risk, you can go to the Client Dashboard under Tools.
 
![tog_minus](tog_minus-1.gif)        [Understanding Risk Templates](javascript:HMToggle('toggle','UnderstandingTradingHourTemplates','UnderstandingTradingHourTemplates_ICON'))
| Risk Templates A Risk Template is a collection of risk definitions that can be used by Simulation accounts to track the amount of Margin being used.    Where Risk Templates can be Applied Risk Templates can be applied via the Control Center or Account Data Accounts tab.   - Right click on a Simulation Account- Select "Edit Account" - Change the selected "Risk" template parameter    | Note:  Risk definitions are activated as soon as the template is applied. However, there are some values (i.e., Intraday margin, Initial margin, Maintenance margin) which are calculated only as the position is updated.  Should you be in a position when the risk template is applied, these values would NOT calculate until the position is updated.  You can force this calculation by disconnecting and reconnecting to your data account connection. | | --- | |
| --- | --- |

![tog_minus](tog_minus-1.gif)        [How to create and edit a Risk Template](javascript:HMToggle('toggle','HowToCreateAndEditATradingHourTemplate','HowToCreateAndEditATradingHourTemplate_ICON'))
| Creating a Risk Template If your desired session risk settings are not found within the pre-loaded Risk Templates, you can create a new template.   To create a Risk Template: 1.Left mouse click on "add"2.Type in the name of the Risk Template3.Select "add" to add a new risk definition, see "Understanding risk definitions" below for more information. Repeat for as many risk definitions as required. 4.Press the Apply button to save the configured session times in the Risk Template.   Risk_1 |
| --- |

![tog_minus](tog_minus-1.gif)        [Working with Risk Templates](javascript:HMToggle('toggle','WorkingWithTradingHourTemplates','WorkingWithTradingHourTemplates_ICON'))
| A saved Risk Template can be selected via the Template section to the left of the Risk window. Selecting the template will allow you to configure individual risk definitions for that template.    Editing Risk Templates Risk Templates can be edited in the following ways:   - Left mouse click the "copy" button in the templates section and insert a new template name to copy the current Risk Template. - Left mouse click the "remove" button in the templates section to delete the selected Risk Template. |
| --- |

![tog_minus](tog_minus-1.gif)        [Understanding risk definitions](javascript:HMToggle('toggle','UnderstandingSessionDefinitions','UnderstandingSessionDefinitions_ICON'))
| Understanding Risk Definitions Each risk definition applies to an individual instrument. You can only have one instrument definition per instrument.    Risk_2     | Buy Intraday Margin | Sets the intraday margin required for buy orders. | | --- | --- | | Sell Intraday Margin | Sets the intraday margin required for sell orders. | | Initial Margin | Sets the initial margin required. | | Maintenance Margin | Sets the maintenance margin required. | | Max Order Size | Sets the max allowable order size. | | Max Position Size | Sets the max allowable position size. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
