


Operations \> Strategy Builder \> Builder Screens






















Builder Screens







| \<\< [Click to Display Table of Contents](builder_screens.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Strategy Builder](strategy_builder-1.md) \> Builder Screens | [Previous page](strategy_builder-1.md) [Return to chapter overview](strategy_builder-1.md) [Next page](strategybuilder_condition_builder-1.md) |
| --- | --- |














The Builder point and click interface is a powerful entrypoint into NinjaScript strategy development for non programmers. Even if you target more deeper custom coding later on in the development cycle, the Builder can provide a great foundation to start with. To get started directly into full fledged programming a strategy object in the NinjaScript editor, please check into [NinjaScript Wizard](ns_wizard-1.md).


 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus-1.gif)        [Understanding the Welcome screen](javascript:HMToggle('toggle','UnderstandingTheWelcomeScreen','UnderstandingTheWelcomeScreen_ICON'))




| Welcome Screen Layout This is the first screen and starting point in the Strategy Builder.   Strategy_Builder_1   1\.In the Strategy drop\-down select New Strategy to create a new strategy script \- all other Builder made scripts will be listed as well, so should you wish to modify a script \- please select the desired one and proceed through the screens.2\.Press the View Code button at any time to view the Builder generated NinjaScript code.3\.Press the Unlock Code button at any time to open the NinjaScript editor and edit your strategy code.    Once the code is unlocked, you can no longer use the Builder for subsequent strategy editing 4\. Press the Compile button at any time to compile your strategy code. 5\. Press the \<Back or Next\> buttons to move back or forth between Builder screens \- you can also directly jump to a specific screen by using the left side navigation menu. 6\. Press the Cancel button to leave the Strategy Builder   Note: Should you want to make a copy of your strategy, you can select your saved script in the Strategy drop\-down and select 'save as' \- this opens a file dialog, where you can enter a new name to save the script copy under.   Strategy_Builder_2 |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the General screen](javascript:HMToggle('toggle','UnderstandingTheGeneralScreen','UnderstandingTheGeneralScreen_ICON'))




| General Screen Layout The General screen is where you enter the name and description of your strategy.   Strategy_Builder_3   1\. Sets the name of the strategy 2\. Sets the description of the strategy |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Default properties screen](javascript:HMToggle('toggle','UnderstandingTheDefaultPropertiesScreen','UnderstandingTheDefaultPropertiesScreen_ICON'))




| Default properties screen Layout The Default properties screen is where you can set the default values for your custom strategy properties.   Strategy_Builder_4   1\. Per default only the Calculate section is visible, click the More properties to expand the selection to include all strategy default properties as well to set for your Builder script.     | Calculate | Sets the Calculation Mode for the strategy. Possible values are "On Each Tick," "On Price Change," or "On Bar Close" | | --- | --- | | Entries per direction | Sets the maximum number of entries allowed per direction while a position is active based on the "Entry handling" property | | Entry handling | Sets the manner in which entry orders are handled. If set to "AllEntries", the strategy will process all entry orders until the maximum allowable entries set by the "Entries per direction" property have been reached while in an open position. If set to "UniqueEntries", the strategy will process entry orders until the maximum allowable entries set by the "Entries per direction" property per each uniquely named entry have been reached. | | Exit on close | When enabled, open positions will be closed on the last bar of a session | | Exit on session close seconds | Sets the number of seconds prior to the end of a session at to close any open positions held by the strategy | | Fill Limit Orders on Touch | Enables the filling of limit orders when touched for the historical portion of the chart | | Maximum Bars Look Back | Sets the maximum number of historical bars to use for strategy calculations. The TwoHundredFiftySix setting is the most memory friendly | | Minimum Bars Required | Sets the minimum number of historical bars required to start taking trades | | Order Fill Resolution | Sets the way that simulated historical orders will be processed by the strategy. See the [Understanding Historical Fill Processing](understanding_historical_fill_-1.md) page for more information. | | Real\-time error handling | Defines the behavior of a strategy when a strategy generated order is returning in a "Rejected" state. See the [Real\-time Error Handling](realtimeerrorhandling-1.md) page for more information. | | Slippage | Sets the slippage amount in ticks for the historical portion of the chart | | Start Behavior | Sets the starting behavior of the strategy, based upon the account position. See the [Syncing Account Positions](syncing_account_positions-1.md) page for more information. | | Stops and Targets | Sets how stop and target orders are submitted | | Time in force | Sets the order's time in force. Possible values are DAY and GTC | | Trace orders | Enables sending more detailed order debug info to the NinjaScript [output window](output-1.md) | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Additional data screen](javascript:HMToggle('toggle','UnderstandingTheAdditrionalDataScreen','UnderstandingTheAdditrionalDataScreen_ICON'))




| Additional data screen Layout The Additional data screen is where you can optionally select additional instrument data or custom series for your strategy.     | Critical: You will want to make sure to add any additional series in this section that a hosted / called MultiSeries indicator in your Builder script would use, such as for example the [Pivots](pivots-1.md), [Camarilla Pivots](camarilla_pivots-1.md) or [Fibonacci Pivots](fibonacci_pivots-1.md) indicators. | | --- |      Strategy_Builder_5   1\. Press the add button to be able to configure a new series to add 2\. Press the edit button to be able to configure an existing series 3\. Press the remove button to be able to remove an existing series   Data Series Selector Layout Select your instrument data series to add here   Strategy_Builder_6     | Use primary instrument | Checking this will use the primary instrument the strategy is applied to | | --- | --- | | Instrument | Select your instrument from the favorite or list selector or by using the search feature (press the magnifying glass) | | Price based on | Selects the price type the data series is based on, possible values are Last, Bid, Ask | | Type | Selects the bars type your series will use, possible values for the Builder interface are \-   •Tick•Minute•Day •Week•Month •Year•Volume•Range•Second | | Value | Sets the bars period type value for your series |      Custom Series Selector Layout Select your custom series to add here   Strategy_Builder_7   | Name | Set the name for your custom series | | --- | --- | | Type | Selects the data type of the custom series, possible values for the Builder interface are \-   •Bool•Double•DateTime•Int•String | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Inputs and Variables screen](javascript:HMToggle('toggle','UnderstandingTheInputsAndVariablesScreen','UnderstandingTheInputsAndVariablesScreen_ICON'))




| Inputs and Variables screen Layout The Inputs and Variables screen allows you to define the user inputs of your strategy. User inputs are important if you require input values that may vary the performance of your strategy. If for example you have a simple moving average cross over system, you may want to create an input for the fast moving average and another for the slow moving average. This then allows you to change the values of the moving averages at run time from the UI. Inputs are also required if you plan to use the NinjaTrader [Strategy Analyzer's optimization](strategy_analyzer-1.md) capabilities.   Strategy_Builder_8   1\. Press the add button to add a new user input. 2\. Press the edit button to edit an existing, selected user input. 3\. Press the remove button to remove the selected user input.     | Name | Set the name for your user input | | --- | --- | | Type | Selects the data type of the user input, possible values for the Builder interface are \-   •Bool•Double•String•Int•Time | | Default | Set the default value your user input will have | | Min | Set the minimum value your user input will have | | Description | Enter an optional description for your user input here |      Strategy_Builder_9   1\. Press the add button to add a new user variable. 2\. Press the edit button to edit an existing, selected user variable. 3\. Press the remove button to remove the selected user variable.     | Name | Set the name for your user variable | | --- | --- | | Type | Selects the data type of the user variable, possible values for the Builder interface are \-   •Bool•Double•String•Int•Time | | Default | Set the default value your user variable will have |        | Note: If an input is named the same as the generated code for an indicator, the strategy will not be able to successfully compile. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Conditions and Actions screen](javascript:HMToggle('toggle','UnderstandingTheConditionsAndActionsScreen','UnderstandingTheConditionsAndActionsScreen_ICON'))




| Conditions and Actions screen Layout The Conditions and Actions screen allows you to set conditions and subsequent actions that control the flow of your strategy.   Conditions \- Take the specified action when true  Actions \- Execute an action (submit orders, draw objects on the chart etc ...) based on its parent condition evaluating to true   Via the Builder, you can have an unlimited set of conditions with related actions and you also group conditions into a condition group (for example for a certain set of filter rules like time)   Conditions and condition groups are created using the [Condition Builder](strategybuilder_condition_builder-1.md). Actions are specified by the [Strategy Actions](actions-1.md) window.   Strategy_Builder_10   1\. Selects if all of the individual conditions have to be met in order to trigger an action, or if any will be sufficient. 2\. Displays the conditions associated with the currently selected condition set 3\. Adds, opens condition grouping(\*), edits or removes a condition (a double click on selected item will also allow editing) 4\. Displays the actions associated with the currently selected condition set 5\. Adds, edits or removes an action (a double click on selected item will also allow editing) 6\. Selects the condition set you wish to edit   \* For an example on working condition groups, please see "How to create a Time Filter' in the [Condition Builder](strategybuilder_condition_builder-1.md) section    You can copy and paste conditions from one set to another and you can even save a condition set as a template and load for future use via the right mouse button click context menu as show in the image below. To save a condition set as a template, select the Save As... menu item and then to re\-use it in another strategy or condition set at a later time, select the Load... menu item.   Strategy_Builder_11 |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Stops and Targets screen](javascript:HMToggle('toggle','UnderstandingTheStopsAndTargetsScreen','UnderstandingTheStopsAndTargetsScreen_ICON'))




| Stops and Targets screen Layout The Stops and Targets allows you to set stop loss, trail stop, parabolic stop (R15 and higher) and profit target orders that are automatically submitted and managed once your strategy opens a position.   Strategy_Builder_12   1\. Displays stops and targets associated with your strategy 2\. Adds a stop or target to your strategy 3\. Edits the selected stop or target in your strategy (a double click on the selected item will also allow editing) 4\. Removes the selected stop or target from your strategy |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the Finish screen](javascript:HMToggle('toggle','UnderstandingTheFinishScreen','UnderstandingTheFinishScreen_ICON'))




| Finish screen Layout Once you reach this screen you are finished with developing your strategy. Press the Finish button to compile your strategy which will then be ready for [backtesting](backtest_a_strategy-1.md) or [live execution](running_ninjascript_strategies-1.md).   Strategy_Builder_13 |
| --- |










