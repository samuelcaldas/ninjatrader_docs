
Operations \> Historical Data \> Data by Provider
Data by Provider
| \<\< [Click to Display Table of Contents](data_by_provider.md) \>\> **Navigation:**     [Operations](operations.md) \> [Historical Data](historical_data_manager.md) \> Data by Provider | [Previous page](loading_historical_data.md) [Return to chapter overview](historical_data_manager.md) [Next page](importing.md) |
| --- | --- |
## Understanding the data provided by your connectivity provider
NinjaTrader, LLC is not a market data provider. Historical data is provided by our connectivity providers that offer historical data as part of their service. The table below displays all NinjaTrader supported connectivity providers as well as the historical and real\-time data provided by each:
 
| Connectivity Provider | Real\-Time Data | Historical Tick Data | Historical Bid/Ask Minute Data | Historical Bid/Ask Daily Data | Historical Bid/Ask Tick Data | Historical Minute Data | Historical Daily Data | Real\-Time Timestamp | Instruments Supported | Real\-Time News | Tick Replay | Bid/Ask Stamped Tick Data | Daily Bars Trading Hours | Settlement adjusted Close Price For Daily Bars |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| NinjaTrader | YES | YES | YES | YES | YES | YES | YES | Native | F, I | NO | YES | YES | Extended Trading Hours | YES |
| Kinetick [www.kinetick.com](http://www.kinetick.com) | YES (subscription only) | YES (subscription only) | NO | NO | \*YES | YES (subscription only) | YES | Native | E(O), F(O), FX, I | YES | YES | YES | Symbol Map Specific | YES |
| BarChart | YES | YES | NO | NO | NO | YES | YES | Native | E, F, FX, I | NO | YES | NO | Symbol Map Specific | YES |
| Coinbase | YES | YES | YES | YES | YES | YES | YES | Native | CC | NO | NO | NO | UTC | N/A |
| Continuum/CQG | YES | YES | YES | YES | YES | YES | YES | Native | F, I | NO | YES | YES | Extended Trading Hours | YES |
| Continuum/CQG WebAPI | YES | YES | YES | YES | YES | YES | YES | Native | F(O), I | NO | YES | YES | Extended Trading Hours | YES |
| cTrader | YES | YES | NO | NO | YES | YES | YES | Native | C | NO | YES | NO | CFD | N/A |
| eSignal | YES | YES | NO | NO | YES | YES | YES | Native | E, F, FX, I | NO | YES | NO | Symbol Map Specific | NO |
| FOREX.com/City Index | YES | YES | NO | NO | NO | YES | YES | Native | FX, C | NO | YES | N/A | Forex | N/A |
| FXCM | YES | YES | YES | YES | YES | YES | YES | Native | FX, C | NO | YES | N/A | Forex | N/A |
| Interactive Brokers | YES | NO | YES | YES | NO | YES  (live account only) | YES  (live account only) | Local | C, E(O), F(O), FX, I | NO | NO | NO | Extended Trading Hours | NO |
| IQFeed | YES | YES | NO | NO | \*YES | YES | YES | Native | E(O), F(O), FX, I | YES | YES | YES | Symbol Map Specific | YES |
| Rithmic | YES | YES | YES | YES | YES | YES | YES | Native | F | NO | YES | YES | Extended Trading Hours | YES |
| TD Ameritrade | YES | NO | NO | NO | NO | YES | YES | Local | E(O), I | NO | NO | NO | Regular Trading Hours | NO |
 
C \= CFD  

CC \= CryptoCurrency
E \= Equities
F \= Futures
FX \= Forex   

I \= Indexes
(O) \= Options on underlying instrument type
 
| Notes:  There are various limitations on data from each provider and data is subject to change. Options are not supported for NinjaScript use. \*Historical bid/ask comes from associated value at each historical last tick value. |
| --- |
## 
## Converting Real\-Time Data into Historical Data
NinjaTrader by default will always loads historical data from your provider (Recommended). However if you enable the option 'Record live data as historical' in the Control Center \> Tools \> Options \> Market Data Category then NinjaTrader will store real\-time incoming tick data to your local PC if you have a Chart or Market Analyzer (must have an indicator column added) window open. This data can then be used as historical data. For example, if you open a chart and let it run all day long, the data collected today, will be available as historical data when you open the same chart tomorrow.
 
| Warning: Recording live data uses more PC resources and is intended for connections which DO NOT provide historical data.  Enabling this option while also using a historical data provider is not recommended as it may result in data gaps. |
| --- |
 
## Connecting to your Broker and a Market Data Provider Simultaneously
If your broker technology does not support historical data, you can connect to a service like Kinetick at the same time as connecting to your broker so that you can receive historical data. Please see the topic on [Multiple Connections](multiple_connections.md) for additional information.

