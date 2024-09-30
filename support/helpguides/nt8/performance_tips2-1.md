
Configuration > Performance Tips
Performance Tips
| << [Click to Display Table of Contents](performance_tips2.md) >> **Navigation:**     [Configuration](configuration-1.md) > Performance Tips | [Previous page](multiple_connections-1.md) [Return to chapter overview](configuration-1.md) [Next page](operations-1.md) |
| --- | --- |
## Performance Factors
There are many variables that contribute to overall performance of the NinjaTrader application.
 
- Different connectivity providers (market data vendors and broker technologies) that NinjaTrader supports vary in their level of real-time data service. For example, providers who deliver unfiltered tick data (submit all market ticks) will impose heavier processing load than a vendor that provides throttled market data.

- The load you place on the NinjaTrader application (running 200 charts will consume more processing power than running only 20 charts)

- The capability of your PC hardware (are you running a brand new state of the art machine or a 4 year old PC with limited RAM)

- A single bad 'setting' can cause performance issues and a single active Third Party script can cause general performance issue. See the [Understanding the impact of installing Add-Ons](using_3rd_party_add-ons-1.md) section.

 
| Note: High memory usage may not be related to poor performance. It takes computer resources to figure out when to free up memory that is no longer being used. So, rather than using resources to constantly determine what memory to free up, the system will determine the best time to free up memory when it is needed. |
| --- |

 
## Optimize Performance
The following are some suggestions that can help you fine tune your NinjaTrader installation to run optimally.
 
1.Close any unneeded open workspaces. Although a workspace may not be in view, it does still use system resources when open.

2.Exit any unneeded Charts, SuperDOMs, Market Analyzers, etc. in your open workspace(s). Additionally, if you have multiple tabs in any windows that you do not need, exit out of those.

3.Ensure that every indicator applied is using the Calculate setting of On price change or On bar close. There is no benefit to using On each tick unless the indicator deals with volume or tick counting.

4.Remove unneeded indicators from Charts, Market Analyzers, and SuperDOMs.

5.Reduce the Days to Load on Charts and on Market Analyzer indicator columns. This can be especially effective with any tick-based series.

6.Use Tick Replay sparingly and only when needed. For example, a simple Pivot indicator which just uses the current and previous daily price levels would not see any advantage from using tick replay. In contrast, a Volume profile indicator which relies on the exact sequence of trades to calculate various levels would greatly benefit from using tick replay.

7.Remove unneeded drawing objects. Especially over time as you have more drawing objects on your charts the performance can decline since there is more to render. 

8.Workspaces which have a single or fewer number of instruments are unable to take advantage of multi-core processors. For example, having 30 charts with the same instrument will not perform as well as 30 charts of different instruments on a multi-core processor. Reducing the number of windows with the same instrument can increase performance. Alternatively, workspaces that have one or only a few instruments would benefit from a processor with a higher clock speed.

9.Reduce the amount of charts with Global crosshairs enabled.

10.Set crosshair to Draw cursor only. Systems with less powerful GPUs can benefit from the reduced rending which results in this change. This setting is within the chart’s properties.

11.Reset and clear history of your simulation account. A large amount of simulated trades can grow the size of your data base. If you do not need this historical information, completing this step will free up more resources.

12.Restart NinjaTrader daily.

13.Disable market recording for Playback and Record live data as historical if it’s not needed.

14.Reduce the number of tickers expanded in the Options Chain.

15.The "Show Volume Text" property in the SuperDOM's Volume column can impact PC performance and the speed of rendering objects in the SuperDOM. This property is disabled by default to minimize the performance impact, and when disabled, you can hover your mouse cursor over any Volume row to view the exact volume at that row.

16.Some computer configurations provide two graphics cards (integrated vs. dedicated).  To get the most out of chart rendering performance, enable a high-performance dedicated graphic processor.

17.Use a hardwired internet connection. Wireless and satellite connections can drop packets or have a poor latency. If a low latency connection is not available, a VPS can be a great solution.

18.Set your connection to connect on start up. This will make it so your workspace only needs to load once, rather than once when you start NinjaTrader and a second time when new data is download after you connect.

19.Reduce the number of applications running on your system.

20.Windows search indexing can also place an extra burden on your processor when running NinjaTrader, negatively impacting performance. It is recommended to exclude the folders listed below from indexing, as well, which can be done via the Windows Control Panel.

 C:\\Users\\User\\Documents\\NinjaTrader 8
 C:\\Program Files (x86)\\NinjaTrader 8
 
## Playback
1.Remove unused instrument subscriptions in playback. In your playback setup, be mindful for which instruments you have added (for example in a Market Analyzer or via Charts) you would have data to playback actually available, as each instrument subscription here would consume CPU cycles and thus contribute to performance experienced. For example, having the SP500 index added in your Market Analyzer but then only replaying MSFT data is expected to have lower performance in contrast to having only this one MSFT instrument listed in the Market Analyzer as well.

## 
## Additional Diagnostics
If you're still having performance issues, follow these diagnostics steps to isolate the problem.
 
1.Start NinjaTrader in Safe Mode.

 Safe Mode will prevent NinjaTrader from:
         Loading workspaces.
         Connecting on start-up.
         Loading custom assemblies.
         Getting instrument updates from the server.
To enable safe mode, please use the following steps:
         Exit NinjaTrader.
         Hold the CONTROL key and double click the NinjaTrader icon.
         Keep the CONTROL key held down until you see the Control Center.
         You can verify you are in safe mode by going to Help -> About.
2.Open some windows and test performance without loading any custom indicators.

3.If everything looks good, attempt to open up your workspace. You may need to close your workspace, without saving it, then reopening it. If this works well, installed custom assemblies may be the cause.

4.If performance is poor with the workspace in safe mode it could be that the workspace is too resource intense for your system, which may be from the scripts being used.

5.To determine if there are specific scripts that are resulting in poor performance you will need to recreate your workspace and add back any scripts one at a time to see which one may be resulting in poor performance.

6.For further assistance, or assistance with any of these steps, please write into [[email protected]](/cdn-cgi/l/email-protection)
