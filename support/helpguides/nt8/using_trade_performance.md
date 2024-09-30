
Operations \> Trade Performance \> Using Trade Performance
Using Trade Performance

| \<\< [Click to Display Table of Contents](using_trade_performance.md) \>\> **Navigation:**     [Operations](operations.md) \> [Trade Performance](trade_performance.md) \> Using Trade Performance | [Previous page](trade_performance.md) [Return to chapter overview](trade_performance.md) [Next page](performance_displays.md) |
| --- | --- |
You can access the Trade Performance window from within the NinjaTrader Control Center window by left mouse clicking on the menu New, and then selecting the menu item Trade Performance.
## 
| playVideo |
| --- |
|  |

## 
![tog_minus](tog_minus.gif)
| Performance Report To generate a performance report:   1\.Select the From date2\.Select the To date3\.Press the Generate button  Performance data is generated and displayed in the various [Performance Displays](performance_displays.md).   TradePerformance_1   The Generate button only needs to be pressed when adjusting the From and To dates or if since generating the report new trades have been placed within the From and To dates.     | Note:  It is possible to have before the From date being listed in your report. NinjaTrader generates reports from the last time you were flat. If a particular instrument was already in the middle of a position at the beginning of the From date, NinjaTrader will report all trades prior to this date up to the point where the position was flat. This will ensure you have a complete picture in terms of your performance on any specific date instead of "jumping" into the middle of a position which may cause inaccurate overall performance. | | --- |      Display Options Use the Display selector to select both what to display and how to display it.   Available Display Views - Summary- Analysis- Executions- Trades- Orders- Journal  Available Display Units - Currency- Percent- Points- Pips- Ticks    | Note: As Forex trade quantities are typically in multiples of 1,000, 10K, and 100K a NinjaTrader feature is to divide (normalize) your Forex trades by your account lot size. Account lot size is recorded per execution and is set by the connection. A micro Forex account is 1,000, a mini Forex account is 10K, a standard Forex account is 100K (FX lot size is set automatically if your broker supports it and if not set manually via the property "FX Lot Size" in the connection setup)   Example: Account is a mini Forex account (10K). A trade is made with quantify of 10k and gain a 1 pip. Instead of recording that profit as 10,000 pips it is recorded as 1 pip of profit. | | --- | |
| --- | --- | --- |

![tog_minus](tog_minus.gif)        [Understanding Filter Options](javascript:HMToggle('toggle','UnderstandingFilterOptions','UnderstandingFilterOptions_ICON'))
| Filter Options Pressing the Filter_Icon Filter icon will expand the Performance tab to include parameters that you can use to filter your performance reports. This filtering is done on an executions basis and not a trades basis.      | Notes:  Adjustments to the filters will automatically update within the Trade Performance window. The Generate button does not need to be selected. If the From and To dates are adjusted and then Generate is pressed unchecked filter items will become rechecked since the Generate button created a new scan to see what item are applicable for the time window. | | --- |      TradePerformance_2     | 1\. Accounts | Sets the account(s) to be included in the performance report | | --- | --- | | 2\. Instruments | Sets the instruments name or type to be included in the performance report | | 3\. Templates | Sets the ATM strategies to be included in the performance report |        | Tip: The checkbox inline with the filter label will toggle the check mark for all items in that list. Allowing you to quickly select or deselect the entire list. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
