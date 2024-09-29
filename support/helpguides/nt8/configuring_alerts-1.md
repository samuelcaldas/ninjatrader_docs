


Operations \> Alerts \> Configuring Alerts






















Configuring Alerts







| \<\< [Click to Display Table of Contents](configuring_alerts.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Alerts](alerts-1.md) \> Configuring Alerts | [Previous page](alerts_dialog-1.md) [Return to chapter overview](alerts-1.md) [Next page](condition_builder-1.md) |
| --- | --- |














Alerts can be created using conditions which monitor various "objects" which exist on the chart, or market analyzer display.  Possible Condition Objects include a chart's data series, indicators, drawing tools, or any Market Analyzer column value.


 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus-1.gif)        [How to add a condition object](javascript:HMToggle('toggle','HowToAddAConditionObject','HowToAddAConditionObject_ICON'))




| Adding an alert from the alert dialog You can create a new generic alert by first accessing the [Alerts Dialog](alerts_dialog-1.md) window, and selecting the "add" text which will add a new alert to your configured alerts panel.     Alerts_3   Any suitable object which currently exists on the window or tab will be available to use as a Condition Object for the alert.  For example, if you have a Market Analyzer with several customized columns added, you will be able to use any of those columns as a Condition Object.  A Chart will work the same way in that any data series, indicator, or drawing object that currently exists on the chart will be available as a Condition Object.   Creating an alert from a chart indicator If you have an indicator configured on an existing chart you wish to use in your alert condition, you can easily access this by first left mouse clicking on the indicator plot to select the indicator, and then selecting Alert   Alerts_4   Doing so will automatically add the selected indicator as an object that is used in the Conditions properties.   Alerts_5   Adding an alert from a chart drawing object Drawing tools which exist on a chart can also be added as a condition object by first left clicking on the drawing tool, then selecting Alert.   Alerts_7   Doing so will automatically add the selected drawing tool as an object that is used in the Conditions properties.   Alerts_8   Adding an alert from a chart data series If you have multiple data series on your chart (e.g., 5 minute and 10 minute data series), you can select one of these series to be used as an condition object. Simply left mouse click on the chart data series itself, and select Alert   Alerts_6   Doing so will automatically add the selected data series as an object that is used in the Conditions properties.   Alerts_9 |
| --- |



![tog_minus](tog_minus-1.gif)        [Understand the general alert properties](javascript:HMToggle('toggle','UnderstandTheGeneralAlertProperties','UnderstandTheGeneralAlertProperties_ICON'))




| General Alert Properties The General section allow you to configure the following alert properties:     | Enabled | When checked, the current alert will be active | | --- | --- | | Name | Sets the displayed name of the alert | | Apply to | Determines which instrument(s) are used to be monitored by the alert. This property is just for the Market Analyzer and Hot List Analyzer. | | Rearm type | Sets under what condition the alert will rearm.  Possible options are listed in the table below:     | Never | The alert will only trigger once and never rearm | | --- | --- | | On timer | Rearm after a specific number of seconds defined in the rearm seconds property | | On bar close | Rearm on the next bar close for the data series used in the alert condition. Only columns which have a data series are eligible for OnBarClose alerts. | | On condition reversed | Rearm once the condition is no longer true | | On connect\* | Rearm after NinjaTrader has been manually connected to a data provider | | Remove | Once triggered the alert will never rearm and be removed. | | | Rearm seconds | Sets the number of seconds an alert will rearm. If the same alert is called within a time window of the time of last alert Rearm seconds, the alert will be ignored (only visible if Rearm type option 'On timer' is selected) |      \*The On connect rearm type is aware of 4 different types of connection events which will define how the On connect rearm type behaves:     | Event | Description | Rearm behavior | | --- | --- | --- | | Manual disconnect | When user has selected to disconnect from the data provider, or shut down NinjaTrader | Alert will be disabled | | Manual reconnect | When a user has selected to connect to a data provider | Alert will be rearmed | | Disconnect | When the data provider has been temporarily disconnected due to connectivity issues | Alert will just stay in active state and will wait for reconnect. | | Reconnect | When the data provider connection has recovered from the lost connection | Alert will resume in active state |      Alerts_10   Applying alerts to specific instruments If you are using a window which has multiple instruments, such as a Market Analyzer, or a Chart with multiple data series, the default behavior will be monitor "All" instruments contained in that window tab.   By selecting the Magnify glass icon next to the Apply to property, a new window will appear which will list all of the configured instruments and allow you to select a specific set of instruments to be monitored by the alert:   1\.From the newly opened Instruments window, select the instruments you wish to apply the condition to    | Tip:   Multi\-select is supported in the Instrument window: •To select a consecutive instruments, click the first instrument, press and hold down the Shift key, and then click the last instrument.•To select non\-consecutive instruments, press and hold down the Ctrl key, and then click each instrument that you want to select. | | --- |        Alerts_11   2\. Press OK on the Instruments window   3\. Your Apply to field will now list the instrument names you selected earlier, indicating that alerts will only be triggered on instruments contained in this list.    Alerts_12   Tip: You can also simply type in the Apply to field to add a specific instrument, or use your backspace key to delete a specific instrument |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the conditions properties](javascript:HMToggle('toggle','UnderstandingTheConditionsProperties','UnderstandingTheConditionsProperties_ICON'))




| Alert Conditions The Alert Conditions allow you to define the exactly what the alert will monitor.   1\.  Set Conditions to match "If Any" or "If All" of the following conditions are met:     | If Any | Alert if any of the listed conditions are true | | --- | --- | | If All | Alert only if all of the listed conditions are true |      2\.  A list of the current objects and conditions to monitor 3\.  Add a new condition, or edit and remove existing conditions   Alerts_13   Managing Alert Conditions To define a new alert condition, select the "add" text which will open a Condition Builder window where you can specify exactly which condition to monitor.  Please see our Help Guide article on the [Condition Builder](condition_builder-1.md) for information on defining an alert condition.    The "edit" text will allow you to edit a selected condition.    Selecting "remove" will remove the selected condition. |
| --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the alert message properties](javascript:HMToggle('toggle','UnderstandingTheAlertActionProperties','UnderstandingTheAlertActionProperties_ICON'))




| Alert Message The alert message properties allow you to define general settings for how the alert is treated when the condition is satisfied.  All alerts that are generated are sent to to the [Alerts Log](alerts_log-1.md) window and will display the message you configured in this section.  You will also be able to control the priority of the alert, as well as background and foreground colors used.     | Message | The text that is displayed in the Alerts Log window.  There are a number of keywords which begin with an "@" symbol which will work as variables to fill in information related to the alert, such as the Instrument, Time, Price, etc. | | --- | --- | | Priority | The priority of the alert for filtering and sorting in the Alerts Log window | | Color for background | The color used for the grid background in the Alerts Log | | Color for foreground | The text color used in the Alerts Log | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding the action properties](javascript:HMToggle('toggle','UnderstandingTheAdditionalActionProperties','UnderstandingTheAdditionalActionProperties_ICON'))




| Actions When an alert has been triggered, there are a number of customizable actions that can be taken at that time.  These actions include the following:     | Play Sound | Play a user defined sound file.  Sounds can include system default sounds, or custom sound files | | --- | --- | | Share | Share a message or screenshot to a selected Sharing Service | | Pop Up Dialog | Display a Pop Up Dialog with a custom message | | Submit Order | Submit a custom order |      Configuring Actions To access these actions, you will need to make sure the Actions group is expanded by selecting the arrow next to this field in the Alerts properties menu as per the screen shot below:   Alerts_16   Selecting the "add" text will open the Actions window where you can define the custom actions.  You can setup as many custom actions as you would like.  This means you can have an alert do more than one custom action as you want.  For example, you can set an alert to Play a Sound and Share a message to a Sharing Service under he same condition.   Alerts_17   Working with Actions Templates After configuring Actions, you can right click within the Actions columns, select Template, and Save As to create a template. Within the right click menu is also where you would be able to load any saved templates   Alerts_18   Actions Property Definitions   | PlaySound |  | | --- | --- | | Sound | Sets the location of the sound file to be played | | Share |  | | Message | Sets the text that is sent to the sharing service | | Screenshot type | Optional image to be attached with the message. Possible screen shot types are:   •None \- No screen shot is included with the message•Chart \-  A screen shot of the chart that generated the alert will be sent•Tab \- Screenshots are taken from the currently active tab. Therefore changing the tab will result in a screenshot of the current tab and not the original.•Window \- A screen shot of the entire window that generated the alert will be sent | | Share to | Selects the [Sharing Service](general_section-1.md) that the alert message is sent to. | | Pop Up Dialog |  | |  | Note:  There is no property for this section and is intentionally left blank.  The pop up dialog will use the "Message" that is configured on the Alert Message section of the Alerts window | | Submit Order |  | | Account | Selects the account the order is submitted | | Instrument | Selects the instrument to submit the order to. Using @INSTRUMENT will submit to the primary instrument. | | Limit Price | Sets the limit price used for the order | | Order action | Selects the type of action used.  Possible order actions are:   •Buy•Buy to cover•Sell•Sell short | | Order type | Selects the type of order used.  Possible order types are:   •Limit•Market•MIT•Stop\-Limit•Stop\-Market | | Quantity | Sets the order quantity that is used for the order | | Stop Price | Sets the stop price used for the order | | Time in force | Selects the TIF (Time in Force) used for the order.  Possible TIF setting are:   •Day•GTC•GTD | | ATM Strategy | Selects the ATM strategy you would like applied to the order |          | Notes:  When applying an ATM Strategy to a Submit Order Alert, the ATM Strategy must be saved. If the saved ATM Strategy is modified before the alert is triggered, the order will submit with the modified ATM. If the ATM Strategy is removed before the alert is triggered, no ATM Strategy will be applied to the order and you will receive an error. All TIF options will display. If the broker does not support the TIF selected, there may be an error. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










