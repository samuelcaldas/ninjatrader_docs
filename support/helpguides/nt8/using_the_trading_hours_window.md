


Operations \> Trading Hours \> Using the Trading Hours window






















Using the Trading Hours window







| \<\< [Click to Display Table of Contents](using_the_trading_hours_window.md) \>\> **Navigation:**     [Operations](operations.md) \> [Trading Hours](trading_hours.md) \> Using the Trading Hours window | [Previous page](trading_hours.md) [Return to chapter overview](trading_hours.md) [Next page](window_tabs.md) |
| --- | --- |














Within the Trading Hours window, Trading Hour Templates hold the session definitions for each day of the week can be created and edited based on any time zone. 


 


![tog_minus](tog_minus.gif)




| Trading Hour Templates A Trading Hour Template is a collection of session definitions that can be used anywhere NinjaTrader utilizes data. When a template is applied, any data outside of the times in the session definitions will be ignored. NinjaTrader comes pre\-loaded with the most common Trading Hour Templates and will also update these automatically from the NinjaTrader data server. You may also create your own custom Trading Hour Templates can also be created to suit your needs.   Where Trading Hour Templates can be Applied Trading Hour Templates can be applied in the following NinjaTrader dialogue windows under the property "Trading Hours":   •Chart panel via the [Data Series](working_with_price_data.md) window•Market Analyzer via customizing [columns](working_with_columns.md)•[Strategy Analyzer](strategy_analyzer.md) window when configuring backtesting•[Strategies tab](strategies_tab2.md) of the Control Center when starting a strategy |
| --- |



![tog_minus](tog_minus.gif)




| Creating a Trading Hour Template If your desired session settings are not found within the pre\-loaded Trading Hour Templates, you can create a new template.   To create a Trading Hour Template:   1\.Left mouse click on "add"2\.Type in the name of the Trading Hours Template3\.Left mouse click on the time zone drop down menu and select the time zone that represents the time inputted in the session definitions4\.Select "add" to add a new session definition, see "Understanding session definitions" below for more information. Repeat for as many sessions as required    | Note: You can right mouse click on the first session added and select the menu item Add Monday through Friday to have NinjaTrader automatically add sessions for Monday through Friday with session definitions based on the selected row. | | --- |      5\. Optionally add any Trading Holidays, see "Understanding trading holidays" below for more information. Repeat for as many Trading Holidays as required.     | Note: You can right mouse click on the Holidays grid and select Load Holidays from Trading Hours. You will be prompted to select another Trading Hours Template, once selected NinjaTrader will import the Holiday session definitions from the selected template. | | --- |      6\. Press the Apply button to save the configured session times in the Trading Hour Template.    TradingHours_NewTemplate |
| --- | --- | --- |



![tog_minus](tog_minus.gif)        [Working with Trading Hour Templates](javascript:HMToggle('toggle','WorkingWithTradingHourTemplates','WorkingWithTradingHourTemplates_ICON'))




| A saved Trading Hour Template can be selected via the Template section to the left of the Trading Hours window. Selecting the template will allow you to configure individual session definitions and trading holiday definitions for that template.    Editing Trading Hour Templates Trading Hour Templates can be edited in the following ways:   •Left mouse click the "copy" button in the templates section and insert a new template name to copy the current Trading Hours Template. •Left mouse click the "remove" button in the templates section to delete the selected Trading Hours Template.   Editing Session Definitions Individual session definitions can be edited in the following ways:   •Left mouse click on a session definition and press the "edit" button in the sessions section to edit the session.•Left mouse click on the "remove" button in the sessions section to delete the selected session definition.  Editing Holiday Definitions Individual holiday definitions can be edited in the following ways:   •Left mouse click on a trading holiday and press the "edit" button in the holidays section to edit the holiday.•Left mouse click on the "remove" button in the holidays section to delete the selected session definition. |
| --- |



![tog_minus](tog_minus.gif)        [Understanding session definitions](javascript:HMToggle('toggle','UnderstandingSessionDefinitions','UnderstandingSessionDefinitions_ICON'))




| Understanding Session Definitions Each session is defined with a start day and time and end day and time. You can have multiple sessions per day, however on the last session of the day you would check mark "EOD(End of Day)". This tells NinjaTrader that this session signifies the ending session for the current trading day and the next session will be counted as the next trading dates session.    TradingHours_Session     | Start day | Sets the Start day of the session definition. | | --- | --- | | Start time | Sets the start time of the session definition. | | End day | Sets the end day of the session definition. | | End time | Sets the end time of the session definition. | | EOD | Sets if the session is the last session for the trading day. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [Understanding trading holidays](javascript:HMToggle('toggle','UnderstandingTradingHolidays','UnderstandingTradingHolidays_ICON'))




| Understanding Trading Holidays  NinjaTrader will exclude trading holidays that are defined in the Trading Hour Template.    TradingHours_Holidays   Each Holiday has a Trading Date, Type, Start date, Start Time, End date, End time, and Description. The Holidays type will determine what fields are available.   Holiday Types   | Full Day | Any sessions between the EOD session of the Holidays Trading Date and the prior EOD marker are excluded. | | --- | --- | | Replace | Replace all session definitions for the Holidays Trading Date with the start and end time/date specified. | | Early Close | Replace the end time/date for the Holidays Trading Date EOD session. (Note: If the end time is before the start time of the EOD session then the EOD session is no longer used and the previous sessions end time/date will be used as EOD and its end time adjusted accordingly. | | Late Open | Replace the start time/date for the first session after the Holidays Trading Date prior days EOD session. | | Modify | Modifies the starting sessions start time and ending sessions end time for the Holidays Trading Date. Note: In contracts to "replace" this keeps all existing sessions defined in between the start and end session. |        | Note: Trade Holidays are automatically updated from the NinjaTrader data server, to report an issue with a trade holiday or a missing holiday please contact [\[email protected]](/cdn-cgi/l/email-protection#d5a5b9b4a1b3baa7b8a6a0a5a5baa7a195bbbcbbbfb4a1a7b4b1b0a7fbb6bab8) | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










