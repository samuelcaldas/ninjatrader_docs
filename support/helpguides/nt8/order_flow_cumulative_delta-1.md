


Operations \> Charts \> Order Flow \+ \> Order Flow Cumulative Delta






















Order Flow Cumulative Delta







| \<\< [Click to Display Table of Contents](order_flow_cumulative_delta.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Charts](charts-1.md) \> [Order Flow \+](order_flow_plus-1.md) \> Order Flow Cumulative Delta | [Previous page](order_flow_volumetric_bars-1.md) [Return to chapter overview](order_flow_plus-1.md) [Next page](order_flow_vwap-1.md) |
| --- | --- |














## Description
An indicator that accumulates the volume of orders filled at bid and ask prices or up and down ticks throughout the session or bar and compares them to determine buy/sell pressure.


 


![tog_minus](tog_minus-1.gif)        [Order Flow Cumulative Delta Overview](javascript:HMToggle('toggle','OrderFlowCumulativeDeltaOverview','OrderFlowCumulativeDeltaOverview_ICON'))




| Display There are 2 view of the Order Flow Cumulative Delta, both of which can be calculated on a Delta type of Bid Ask or Up Down Tick.   1\) Session, in which the delta will accumulate over the session. Each close price will be carried over to the open of the next bar. 2\) Bar, in which the delta will accumulate over a bar. Each bars open will start over and have an open of zero.   OFCD1   Using the Order Flow Cumulative Delta A common function of the Order Flow Cumulative Delta is to confirm trends. In the image below we can see that the price is bullish. However, this was not confirmed by the Order Flow Cumulative Delta which was bearish. The market then became bearish.   OFCD2   Another common function is to confirm new daily highs or lows. In this image we can see that the price reached a new low for the day, but this was not confirmed by the Order Flow Cumulative Delta. The bears could not hold momentum and then the market became bullish.   OFCD3     | Notes:  1\. To plot historically with Delta type Bid Ask requires historical bid ask stamped tick data. See the [Data by Provider](data_by_provider-1.md) section for information on what providers offer historical bid/ask stamped tick data. 2\. Volume bars could split a single tick into multiple bars for both historical and real\-time data. As such Order Flow Cumulative Delta could run into tracking limitations on the internally added 1 tick series, as all the volume would be processed on the first 1 tick bar / delta calculation. | | --- |        | Critical: Forex instruments are not supported with the Delta type Bid Ask. Since forex has no last price, this mode will result in the cumulative delta bars moving in one direction. If using the Delta Type Up Down Tick mode, this will be calculated on data series Price based on property. Last data is bid data for forex instruments. | | --- | |
| --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Order Flow Cumulative Delta Parameters](javascript:HMToggle('toggle','OrderFlowCumulativeDeltaParameters','OrderFlowCumulativeDeltaParameters_ICON'))




| | Delta type | | Bid Ask | Accumulates the volume of orders filled at the bid or less vs ask or more. Orders filled at the ask or more price are considered buying pressure. Orders filled at the bid or less price are considered selling pressure. If the current tick price is between ask and bid, the volume will be recorded to the same pressure as the previous tick. | | --- | --- | | Up Down Tick | Accumulates the volume of up ticks vs down ticks. Up ticks are considered buying pressure. Down ticks are considered selling pressure. If the current tick price is the same as the previous tick price, the volume will be recorded to the same pressure as the previous tick. | | | --- | --- | --- | --- | --- | --- | | Period | | Session | Accumulates volume per session | | --- | --- | | Bar | Accumulates volume per bar | | | Size filter | Input to exclude volume less than the selected value | | Candle body outline | Color and line settings for the candle body outline | | Candle wick | Color and line settings for the candle wick | | Color for down bars | Color for bars that have a close less than the open | | Color for up bars | Color for bars that have an open greater than the open | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Order Flow Cumulative Delta Values NinjaScript access](javascript:HMToggle('toggle','OrderFlowCumulativeDeltaValuesNINJASCRIPTaccess','OrderFlowCumulativeDeltaValuesNINJASCRIPTaccess_ICON'))




| For information on how to access the Order Flow Cumulative Delta values in NinjaScript, please see the [Order Flow Cumulative Delta](order_flow_cumulative_delta2-1.md) page in the NinjaScript section of the Help Guide. |
| --- |










