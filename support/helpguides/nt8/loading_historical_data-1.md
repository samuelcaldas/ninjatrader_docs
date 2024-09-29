


Operations \> Historical Data \> Loading Historical Data






















Loading Historical Data







| \<\< [Click to Display Table of Contents](loading_historical_data.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Historical Data](historical_data_manager-1.md) \> Loading Historical Data | [Previous page](historical_data_manager-1.md) [Return to chapter overview](historical_data_manager-1.md) [Next page](data_by_provider-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









NinjaTrader has 3 levels of data access: From provider, from cache, and from memory.


 


1\.From provider is naturally the slowest, since data has to be transferred over the internet from your connected data provider.

2\.From cache is much faster, since we cache the data to the hard drive and load from there on any subsequent request.

3\.From memory is the fastest and typically results in "instant" chart loads, which is possible since the data is already in use by NinjaTrader so we don't have to make a trip to the cache or the provider.

 


The reality is for any chart load, there typically will be data returned from multiple levels of data access. Where NinjaTrader will load as much as possible from the memory or cache and make a request to fill any gap to the provider. 


![tog_minus](tog_minus-1.gif)        [The NinjaTrader memory and speeding up the loading of data](javascript:HMToggle('toggle','ThePRODUCTNAMEcacheandspeedinguptheloadingofdata','ThePRODUCTNAMEcacheandspeedinguptheloadingofdata_ICON'))




| Data that is currently being used will be in the memory and will first be used to populate your charts. Additionally, to minimize the need to load data and to speed up chart load times, NinjaTrader maintains an internal cache of your prior accessed data. When data is in this cache, NinjaTrader will use it to populate your charts instead of loading from your data provider.    There are two ways to ensure that the memory contains data for your instrument of interest:   1\.Load the instrument into a [Market Analyzer](market_analyzer-1.md) window along with an indicator column with the same chart parameters you plan to be loading.2\.Open and maintain a chart with the same data type and days to load that you plan on loading. |
| --- |



![tog_minus](tog_minus-1.gif)        [When does NinjaTrader download historical data?](javascript:HMToggle('toggle','WhendoesNinjaTraderdownloadhistoricaldata','WhendoesNinjaTraderdownloadhistoricaldata_ICON'))




| NinjaTrader loads data from your data provider whenever it determines it could potentially not have all the data pertaining to the requested time period.    NinjaTrader will load data when:   1\.The End date parameter of the [Data Series](working_with_price_data-1.md) window contains the current day (this results in the current and prior day downloading)2\.The most recent day of data in your data request is not available in the data repository (this results in the most recent day from your data request and prior day downloading)3\.When the oldest day of data in your data request is not available in the data repository or it only goes up to that date (this results in all requested historical trading day data downloading and the prior day)  The prior day is included as many instruments trading days starts on the prior day. |
| --- |



![tog_minus](tog_minus-1.gif)        [What historical data is loaded from provider?](javascript:HMToggle('toggle','Whathistoricaldataisloadedfromprovider','Whathistoricaldataisloadedfromprovider_ICON'))




| Examples of when NinjaTrader will fetch data if the data repository contains data from 1/2/14 to 1/5/14 and the current date is 1/6/14:   1\.Chart of 1/2/14 to 1/6/14 \-\> load data request for 1/6/14, use data stored in memory/cache for other dates2\.Chart of 1/2/14 to 1/5/14 \-\> load data request for 1/5/14, use data stored in memory/cache for other dates3\.Chart of 1/2/14 to 1/4/14 \-\> use data stored in memory/cache for all dates4\.Chart of 12/27/13 to 1/4/13 \-\> load data request for all dates  Expanded example for a more detailed explanation:   Historical tick data in the repository from 12/1/2013 until 1/1/2014 2:00 PM  Historical minute data in the repository from 1/1/2013 until 1/1/2014 2:00 PM  Historical daily data in the repository from 1/1/2013 until 1/1/2014  Today is the 1/2/2014 9:00 AM and the Trading Hours Template is "CME US Index Futures ETH"     | Scenario | Requested from Local Repository | Downloaded From Provider | | --- | --- | --- | | 1 tick chart 3 days back with end date of today | 12/31/2013 7:00 PM to 1/1/2014 2:00 PM | 1/1/2014 2:00 PM to 1/2/2014 9:00 AM | | 1 minute chart 5 days back with end date of today | 12/29/2013 7:00 PM to 1/1/2014 2:00 PM | 1/1/2014 2:00 PM to 1/2/2014 9:00 AM | | 1 day chart 365 days back with end date of today | 1/2/2013 to 1/1/2014 | 2/1/2014 |          | Critical: All NinjaTrader historical data requests are handled using calendar days format, please keep this in mind when for example interpreting loading results that include weekends or holidays periods where the may be no actual data \- the affected calendar day would still be counted as a 'day' in the request. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










