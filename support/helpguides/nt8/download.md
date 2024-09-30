
Operations \> Historical Data \> Download

Download
| \<\< [Click to Display Table of Contents](download.md) \>\> **Navigation:**     [Operations](operations.md) \> [Historical Data](historical_data_manager.md) \> Download | [Previous page](editing.md) [Return to chapter overview](historical_data_manager.md) [Next page](hot_key_manager.md) |
| --- | --- |
Historical data can be downloaded from the data provider via the Download section.
 
| How to Download Historical Data To download historical data first make sure NinjaTrader is [connected](connecting.md) and [historical data](data_by_provider.md) is available from your data provider.   1 2 3 4 Press the "Download" button to begin the download   MarketDataArchives_Download   A message in the bottom right of the Historical Data Window will appear and display the status of the download.    To cancel a historical data request close the Historical Data Window window.     | Notes: - If you already have historical data for an instrument, please be sure to only select a date range in which your data provider offers historical data. If you choose a range older than what your data provider offers you may lose any data you had stored on those dates in that range outside of what your data provider offers.- Downloading historical data will function based on the Merge Policy being used. Using MergeBackAdjusted or MergeNonBackAdjusted will switch what contract month is being downloaded based on the rollovers occurring during the selected date range. To download data for just the selected contract the Merge Policy will need to be set to DoNotMerge. See the [Merge Policy](merge_policy.md) section for more information on Merge Policies. | | --- | |
| --- | --- |
