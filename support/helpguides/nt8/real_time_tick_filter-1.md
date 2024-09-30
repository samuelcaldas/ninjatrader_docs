
Configuration > Options > Market data > Real-time Tick Filter

Real-time Tick Filter

| << [Click to Display Table of Contents](real_time_tick_filter.md) >> **Navigation:**     [Configuration](configuration-1.md) > [Options](options-1.md) > [Market data](options_marketdata-1.md) > Real-time Tick Filter | [Previous page](merge_policy-1.md) [Return to chapter overview](options_marketdata-1.md) [Next page](multiple_connections-1.md) |
| --- | --- |
## What is tick filtering?
Tick filtering is a function where each incoming tick is evaluated in relation to the last known price and if it is outside of a user defined percentage value, the tick is thrown away and not distributed to any NinjaTrader object that requires market data such as advanced charts or strategies. This prevents data spikes from showing on your charts and can also prevent unwanted actions taken by automated strategies due to a data spike.
 
## How does it work?
A bad tick is detected if the tick price is less than the last valid traded price - (last traded Price * (1 - bad tick offset as %))
A bad tick detected if the tick price is greater than the last valid traded price + (last traded Price * (1 + bad tick offset as %))
If a bad tick is detected but the prior two ticks were also bad ticks, then the tick being processed is now a valid last traded price and is NOT filtered out
 
## How do I enable tick filtering?
You can enable real-time tick filtering by selecting the Tools menu from the Control Center window and selecting the Options menu item. The Options dialog window will appear. Within the Options dialog window, left mouse click on the Market data category. Under the Real-time data section you can place a check mark next to Filter bad ticks and set the % off market value.
 
## When should I used tick filtering?
- If you are using a market data vendor where you often see data spikes come in 

- If you trade primarily equities 

- If you are running automated strategies where data spikes have implications 
