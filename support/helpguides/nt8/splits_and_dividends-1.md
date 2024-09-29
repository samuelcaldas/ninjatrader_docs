


Configuration \> Options \> Market data \> Splits and Dividends






















Splits and Dividends







| \<\< [Click to Display Table of Contents](splits_and_dividends.md) \>\> **Navigation:**     [Configuration](configuration-1.md) \> [Options](options-1.md) \> [Market data](options_marketdata-1.md) \> Splits and Dividends | [Previous page](options_marketdata-1.md) [Return to chapter overview](options_marketdata-1.md) [Next page](merge_policy-1.md) |
| --- | --- |











## Splits and Dividends


NinjaTrader will split and dividend\-adjust historical data. This is primarily relevant for backtesting. NinjaTrader uses a fixed level back adjustment of dividends. This means that historical data is adjusted at the fixed amount of the dividend.


 


For example:


 


Day 1: Stock trades at $10\.00  

Day 2: Stock trades at $10\.50  

Day 3: Stock trades at $11\.25  

Day 4: Stock goes ex\-dividend, the dividend is $0\.75, and finishes trading at $10\.50


 


The dividend adjusted historical data now becomes:


 


Day 1: $9\.25  

Day 2: $9\.75  

Day 3: $10\.50  

Day 4: $10\.50 (the ex\-day is not adjusted)


 


## Enabling Splits and Dividends


You can enable this data adjusting by selecting the Tools menu from the Control Center and left mouse clicking on the Options menu item. Then select the Market Data category and select Adjust for splits and/or Adjust for dividends.


 




| Warning: Should the historical data you are using come pre\-adjusted you should not readjust them a second time. |
| --- |



 




| Connectivity Provider | Split Adjusted | | Dividend Adjusted | |
| --- | --- | --- | --- | --- |
| Intraday | Daily | Intraday | Daily |
| Kinetick [www.kinetick.com](http://www.kinetick.com) | NO | YES | NO | NO |
| BarChart | YES | YES | NO | NO |
| eSignal | NO | YES | NO | NO |
| Interactive Brokers | \-\-\-\- | \-\-\-\- | \-\-\-\- | \-\-\-\- |
| IQFeed | NO | YES | NO | NO |
| TD Ameritrade | \-\-\-\- | \-\-\-\- | \-\-\-\- | \-\-\-\- |



 


## Adding Splits and Dividends


You must add splits and dividends per instrument in the Instruments window. Please see the [Adding Splits and Dividends](adding_splits_and_dividends-1.md) section of the Help Guide for more information.


 


•NinjaTrader stores historical data in it's local data repository in an unadjusted state

•If the data provider provides adjusted data, NinjaTrader will convert the data into it's unadjusted state prior to local storage








