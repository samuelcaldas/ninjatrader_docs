
Operations > Historical Data > Download

Download
| << [Click to Display Table of Contents](download.md) >> **Navigation:**     [Operations](operations-1.md) > [Historical Data](historical_data_manager-1.md) > Download | [Previous page](editing-1.md) [Return to chapter overview](historical_data_manager-1.md) [Next page](hot_key_manager-1.md) |
| --- | --- |
Historical data can be downloaded from the data provider via the Download section.
 
| How to Download Historical Data To download historical data first make sure NinjaTrader is [connected](connecting-1.md) and [historical data](data_by_provider-1.md) is available from your data provider.   1 Select an instrument for data to be downloaded. (Tip: You may also select an instrument list) 2 Select the desired Start and End date range 3 Select the desired Intervals and Data Types  4 Press the "Download" button to begin the download   MarketDataArchives_Download   A message in the bottom right of the Historical Data Window will appear and display the status of the download.    To cancel a historical data request close the Historical Data Window window.     | Notes: - If you already have historical data for an instrument, please be sure to only select a date range in which your data provider offers historical data. If you choose a range older than what your data provider offers you may lose any data you had stored on those dates in that range outside of what your data provider offers.- Downloading historical data will function based on the Merge Policy being used. Using MergeBackAdjusted or MergeNonBackAdjusted will switch what contract month is being downloaded based on the rollovers occurring during the selected date range. To download data for just the selected contract the Merge Policy will need to be set to DoNotMerge. See the [Merge Policy](merge_policy-1.md) section for more information on Merge Policies. | | --- | |
| --- | --- |
