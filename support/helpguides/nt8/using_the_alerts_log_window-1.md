


Operations \> Alerts Log \> Using the Alerts Log Window






















Using the Alerts Log Window







| \<\< [Click to Display Table of Contents](using_the_alerts_log_window.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Alerts Log](alerts_log-1.md) \> Using the Alerts Log Window | [Previous page](alerts_log-1.md) [Return to chapter overview](alerts_log-1.md) [Next page](alerts_log_properties-1.md) |
| --- | --- |














The Alerts Log window displays information for each alert that is triggered within NinjaTrader. 


 


![tog_minus](tog_minus-1.gif)        [Understanding the Alerts Log window](javascript:HMToggle('toggle','UnderstandingTheAlertsLogWindow','UnderstandingTheAlertsLogWindow_ICON'))




| Alerts Log Window Display When an alert is triggered, the following information is available in the Alerts Log window:   1\.Instrument name2\.Source of alert3\.Priority of alert4\.Time of the alert5\.User defined message  Alerts_Log_1   Right Click Menu Right mouse clicking within the Alerts Log window will bring up the following menu options:   Alerts_Log_2     | Clear | Clears the Alerts Log history | | --- | --- | | Instrument Type | Filters alerts by type of instrument | | Priority | Filters alerts by user defined priority | | Source | Filters alerts by originating source | | Go To Alert | Brings source of alert in focus | | Send To | Loads the selected instrument into another NinjaTrader window | | Always On Top | Sets the Alerts Log window to always be on top of other windows | | Show Tabs | Set if the window should allow for tabs | | Export | Exports the Alerts Log contents to "CSV" or "Excel" file format | | Find... | Search for a term in the Alerts Log | | Print | Displays Print options | | Share | Displays Share options | | Properties | Set the Alerts Log properties | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Setting up alert filters](javascript:HMToggle('toggle','SettingUpAlertFilters','SettingUpAlertFilters_ICON'))




| Filtering Alerts By default, all alerts triggered in the workspace will be displayed in the Alerts Log window.  However, each Alerts Log window and tab has the capability to only display certain alerts based on a number of alert attributes.   The following alert filter attributes will be available from the Alerts Log right click menu:     | Instrument Type | Forex, Future, Index, Option, Stock, CFD | | --- | --- | | Priority | High, Medium, Low | | Source | Chart, Market Analyzer, Hot List Analyzer, News, NinjaScript |      To enable or disable these filters, simply right click on the Alerts Log window and check or uncheck the attribute you wish to configure.   When checked, only alerts which meet the alert attribute description will be displayed on the current Alerts Log window or tab.  You can create multiple tabs, or multiple windows to setup varying filters for each attribute you desire to help organize the type of alerts that are displayed. |
| --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Using Alerts Logs and multiple workspaces](javascript:HMToggle('toggle','UsingAlertsLogsAndMultipleWorkspaces','UsingAlertsLogsAndMultipleWorkspaces_ICON'))




| Finding an Alert From the Alerts Log, you can quickly locate the source window or tab in which the alert was generated.   1\.Double clicking an alert entry row will bring the the source window or tab to front and focus.  2\.You can also right click on the alert entry row and select Go To Alert.  Alerts Logs in Multiple Workspaces The default behavior of the Alerts Log is to only receive alerts from its parent workspace. However, you can configure an individual Alerts Log window or tab to receive alerts from other workspaces by right clicking on the Alert Log, selecting Properties and checking Receive alerts from all active workspaces (Please note that NinjaScript objects are excluded from this check).   With this configuration, should you attempt to Go To Alert which was generated from another workspace, you will receive a prompt asking if you would like to navigate to the source workspace. Selecting Yes on this prompt will then switch the active workspace and set the source window or tab into view. |
| --- |










