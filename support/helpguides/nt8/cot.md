


Operations \> Charts \> COT






















COT







| \<\< [Click to Display Table of Contents](cot.md) \>\> **Navigation:**     [Operations](operations.md) \> [Charts](charts.md) \> COT | [Previous page](power_volume_indicators.md) [Return to chapter overview](charts.md) [Next page](wiseman.md) |
| --- | --- |














Description


The COT indicator plots weekly data from the Commitment Of Traders report, indicating holdings of different participants in the U.S. futures market.


The report is released every Friday at 3:30pm and contains position data supplied by reporting firms from that Tuesday.


 


![tog_minus](tog_minus.gif)




| Getting Data In order to plot the COT indicator you must first enable COT data to be download. To do this, within the Control Center go to Tools\> Options\> Market Data then check Download COT data at start up and restart NinjaTrader.   cot1   If this option is not enabled and you attempt to apply the COT indicator to a chart, a message will display on the chart saying "Download COT data at startup" must be enabled in Options to receive the latest data.   cot2   Display The COT indicator is able to display 1\-5 plots at a time from a single instance of the indicator for many U.S. futures instruments. By default it loads 4 plots with some of the most frequently used report fields.   cot3   The Open Interest plot typically has a value much larger than the others and it may be preferable to plot Open Interest on it's own. To do this, within the indicator properties change the Number of COT plots to 1 and change COT 1 to the Open interest Field. Adjust plot colors and values as desired.   cot4   Next add another COT indicator and set Number of COT plots to 3.   cot5   Now you will have a chart with Open Interest on its own panel and the net position report fields on their own panel to increase visibility.   cot6   Using the COT COT data is often times used to compare what market participants are long vs short. This information can then be used to help determine a position per your own trading method. Here we can see that the red  Futures \- Commercial net plot is 558k short, indicated by the negative value, where as the blue Futures \- Non\-commercial net plot is 541k long.    cot7   Another common use is to see when a market participant reverses their position or when market participants plots cross, potentially indicating a change in market direction. Here we can see as the red commercials moved to long and crossed the blue non\-commercials the price started to move in a bullish direction.    cot8       | Note: Since the COT reports are weekly data, the most current data will continue to plot forward until new data is available. After the new report is released on Friday at 3:30pm Eastern time, NinjaTrader will need to be restarted to download the updated data. Since the data is from that weeks Tuesday, the plots will then be updated from that Tuesday forward. | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [COT Parameters](javascript:HMToggle('toggle','COTParameters','COTParameters_ICON'))




| | Number of COT plots | Indicates how many plots you would like the indicator to have from 1\-5 | | --- | --- | | COT \# | | Report | Indicates which report to get data from | | --- | --- | | Field | Indicates what field from the report you want to plot | |        | Note: Since this indicator is a historical weekly report and does not change based on new prices or volume, there is no benefit to having this indicator Calculate On price change or On each tick. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [COT Values NinjaScript access](javascript:HMToggle('toggle','COTValuesNinjaScriptaccess','COTValuesNinjaScriptaccess_ICON'))




| For information on how to access the COT values in NinjaScript, please see the [Commitment Of Traders (COT)](commitment-of-traders-(cot).md) page in the NinjaScript section of the Help Guide. |
| --- |



 









