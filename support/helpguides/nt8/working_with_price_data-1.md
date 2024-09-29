


Operations \> Charts \> Working with Price Data






















Working with Price Data







| \<\< [Click to Display Table of Contents](working_with_price_data.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Charts](charts-1.md) \> Working with Price Data | [Previous page](chart_objects-1.md) [Return to chapter overview](charts-1.md) [Next page](working_with_multiple_data_series-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









A Data Series represents a series of price data, which can be displayed on a chart using one of several [Bar Types](bar_types-1.md) and Chart Styles. One or more Data Series will be applied to a new chart when it is created, and additional Data Series can be added, edited, or removed via the Data Series window.


 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus-1.gif)        [Understanding the Data Series Window](javascript:HMToggle('toggle','UnderstandingTheDataSeriesWindow','UnderstandingTheDataSeriesWindow_ICON'))




| The Data Series window is used to configure the Data Series within a chart, edit Data Series parameters, and save default values for different Period Types.   Accessing the Data Series Window There are multiple ways to access the Data Series window:   •Select the New menu from the NinjaTrader Control Center, then select the Chart menu item.•Right mouse click in the chart background and select the Data Series menu item.•Use the default CTRL\+F [Hot Key](hot_key_manager-1.md) from an open chart.•Double left mouse click on a Data Series within the chart.•Right mouse click on a selected Data Series within a chart, then select the Properties menu item.  Sections of the Data Series Window The image below displays the four sections of the Data Series window.   PriceData1   1\.Instrument Selector2\.Data Series currently applied to the chart3\.Selected Data Series' parameters4\.Saved Chart Templates that can be applied to the new chart. See the [Saving Chart Defaults and Templates](saving_chart_defaults_and_templates-1.md) page for more information.    | Note:  If a [Chart Template](saving_chart_defaults_and_templates-1.md) is selected, settings from that template will take precedence over any settings manually configured on the Data Series.  For example, Trading Hours currently configured will be ignored, and the chart will use the Trading Hours which were saved in the Chart Template. | | --- | |
| --- | --- |



![tog_minus](tog_minus-1.gif)        [How to add a Data Series](javascript:HMToggle('toggle','HowToAddADataSeries','HowToAddADataSeries_ICON'))




| Adding a Data Series Multiple Data Series objects can be applied within a single chart. A new panel is automatically created for each Data Series added, unless the "Panel" property is manually changed to an existing panel. There are multiple ways to add a Data Series to a chart using the Data Series window:   1\.Use the Instrument Selector dropdown menu to select a recently used or pinned instrument, or any instrument in an Instrument List.2\.Type the instrument symbol (including the contract month for futures instruments) directly into the Instrument Selector, then press the "Enter" key. 3\.Left mouse click on the magnifying glass icon next to the Instrument Selector. In the window that appears, use the search field to search available instruments by symbol or description, then double left mouse click on an instrument in the search results to add it to the list of applied Data Series.  The added Data Series will now be visible in the list in the "Applied" section, allowing you to change any parameters to desired values (see the "How to edit Data Series parameters" section below).     | Tip: A Data Series can also be added by typing directly into an open chart. Type the plus symbol (\+) followed by the instrument symbol, contract month for Futures, and appropriate interval value. For example, typing "\+ES \#\#\-\#\# 5M" will add a 5 minute ES continuous contract Data Series to the selected chart (See the "How to change a Data Series" section below for more information). | | --- |        PriceData2   In the image above, we can use the [Instrument Selector](usingtheinstrumentselector-1.md) to add a recently viewed or pinned instrument, as well as any instruments in an Instrument List. |
| --- | --- |



![tog_minus](tog_minus-1.gif)        [How to edit Data Series parameters](javascript:HMToggle('toggle','HowToEditDataSeriesParameters','HowToEditDataSeriesParameters_ICON'))




| Editing a Data Series A Data Series object's parameters are available to configure within the Data Series window once it has been added to a chart (see the "How to add a Data Series" section above).   To edit Data Series parameters:   1\.Open the Data Series window (see the "Understanding the Data Series window" section above).2\.Select the Data Series you would like to edit in the "Applied" section.3\.Once selected, the Data Series parameters will be available to edit on the right hand side.   PriceData3   Available Data Series parameters can be found in the list below:   Data Series Parameters   | Price based on | Sets the type of market data used to drive the Data Series | | --- | --- | | Type | Sets the bar type of the Data Series. See the [Bar Types](bar_types-1.md) page for more information. | | Value | Sets the Data Series value, based on the selected Bar Type | | Tick Replay | Enables Tick Replay on the selected Data Series. This option will only display when "Show Tick Replay" is enabled in the [Options](options-1.md) window | | Load data based on | Determines how much data is loaded based on number of bars, number of days, or a custom date range. | | Days Back / Bars Back / Start Date | Sets the value for the amount of historical data to load, based on the "Load Data Based On" setting. The label on this property will change based upon what you have selected for the "Load Data Based On" property. | | End date | Sets the end date of the chart. If the specified end date is within the range of an applied Trading Hours template whose end time falls on a future date, then the Chart will end on that future date. | | Trading Hours | Sets the Trading Hours template to be used for the Data Series. See the [Trading Hours](trading_hours-1.md) page for more information. | | Break at EOD | When enabled bars will be cut off at the end of the Trading Hours session regardless of whether it is fully complete. So a 10 range bar may close with a range of 3 or a 4 hour bar may close after 2 hours. When disabled, such a bar will continue to develop until it is complete, potentially causing it to post outside of the Trading Hours session. For more information, see the [Break at EOD](break_at_eod-1.md) page. | | Chart Style | Sets the style of the bars. Custom [Chart Styles](chart_style-1.md) can be created via NinjaScript to extend the pre\-built list. | | Bar Width | Sets the width of the bars drawn on the chart | | Additional Chart Style Options | Additional options for configuring bar colors and related properties will be displayed beneath the Bar Width property, depending on which Chart Style you have selected. | | Auto Scale | When enabled, the Data Series will be part of the chart's auto scaling.    •In case the chart is set to a fixed scale, this property has no effect. •In case there are no objects on the chart which have this property set to true, the first chart object will be used for the chart's auto\-scaling. | | Center on Price Scale | When enabled, the current price will be centered on the price axis, and all visible historical bars will be scaled accordingly | | Display in Data Box | Enables or Disables the display of the selected Data Series in the [Data Box](data_box-1.md) | | Label | Sets the label text to be displayed in a chart panel when more than one Data Series has been applied to a chart. This can be left blank to remove the label entirely. | | Panel | Sets the panel in which the selected Data Series will be plotted. When more than one Data Series has been added to a chart, all but the first Data Series in the list will provide the option to plot in a New Panel in the "Panel" field. | | Price Marker | Expanding this property will allow you to change the color for the price markers on the chart, as well as enable or disable the price markers' visibility. | | Scale justification | Sets the scale on which the Data Series will be plotted. Possible values are "Right," "Left," and "Overlay" | | Show Global Draw Objects | Sets whether Global Drawing Objects will be displayed for this Data Series. See the "Understanding local vs. global drawing objects" section of the [Working with Drawing Tools \& Objects](working_with_drawing_tools__ob-1.md) page for more information. | | Trading Hours Break Line | Sets the color, dash style, and width of the Trading Hours break line plotted on the chart for the selected Data Series | | Color for Executions \- Buy | Sets the color for Buy\-side execution markers | | Color for Executions \- Sell | Sets the color for Sell\-side execution markers | | NinjaScript Strategy Profitable Trade Line | Sets the color, dash style, and width for the lines connecting entries and exits of profitable trades taken by a NinjaScript strategy | | NinjaScript Strategy Unprofitable Trade Line | Sets the color, dash style, and width for the lines connecting entries and exits of unprofitable trades taken by a NinjaScript strategy | | Plot Executions | Sets the plotting style of the trade executions.     | Note: Real\-time executions are timestamped based on the timezone set in the "General" section of the Options window, which can be accessed from the [Tools](tools_menu-1.md) menu in the Control Center. Please see the [How Trade Executions are Plotted](how_trade_executions_are_plott-1.md) page for more information. | | --- | |      Saving Data Series Parameters as Default You can optionally save your customized Data Series parameters as default. Defaults are saved based on the Interval Type selected. Saving defaults will recall your customized settings the next time you add a Data Series with that specific Interval Type to a chart. Please see the [Saving Chart Defaults and Templates](saving_chart_defaults_and_templates-1.md) page for more information. |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [How to change a Data Series](javascript:HMToggle('toggle','HowToChangeADataSeries','HowToChangeADataSeries_ICON'))




| Data Series can be edited in several ways after being added to a chart.   Changing an Instrument via the Chart Toolbar To change an instrument using the chart toolbar:   1\.Left mouse click on the instrument drop down menu in the chart toolbar2\.Select a recent or pinned instrument from the top of the list, or expand any of the Instrument Lists for additional selections (for more information about editing Instrument Lists, see the [Instrument Lists](instrument_lists-1.md) page).  Using the Interval Selector The Interval Selector can be used to change a Data Series interval directly from the chart toolbar. The Interval Selector comes pre\-populated with commonly used intervals, but you can add additional intervals of your choice at any time. To access the Interval Selector, left mouse click the dropdown menu displaying the currently selected interval, located next to the instrument dropdown menu on the chart toolbar. To change the currently selected interval, select any of the values corresponding to the row labeled with your desired interval type. For example, to switch to a 5,000 Volume interval, click the "5000" option in the "Volume" row.   PriceData4   Adding Intervals to the Interval Selector To add a new interval to the Interval Selector, first click the Configure option. The Configure window that appears is separated into two sections. In the "Intervals" section on the left side, you can select any existing Interval Type to view, add, edit, or remove any specific interval value set up for that interval type. In this section, you can add new Interval Types to the list via the add option, remove an Interval Type from the list via the remove option, or move Interval Types higher or lower in the list via the up and down options. In addition to the Interval Types already available, you can add Heiken Ashi, Kagi, Line Break, Point and Figure, or Renko to the list.   With an Interval Type selected in the "Intervals" section, you can manage the specific intervals available for that type in the "Values" section. To add a specific interval to the list for a specific Interval Type, select the add option. A window will appear, in which you can set the label and Data Series options to be used when that interval is selected:   PriceData5   1\. The "Label" field sets the label that will be displayed in the Interval Selector for this interval. Entering "@VALUE" in this field will display the value entered in the "Value" field in the section below. Alternatively, you can enter any text or numbers in this field to label the interval.    2\. The "Price Based On" field determines whether the underlying Data Series will be based upon the Ask, Bid, or Last price for the selected instrument.   3\. The "Value" field sets the value to be used for the interval, based on the Interval Type.   Editing, Sorting, and Removing Intervals To remove an interval from the list for a specific interval type, first select the interval, then select the remove option.    To edit the parameters of an existing interval, select the edit option instead.    To change the placement of an interval in the list, first select the interval you wish to move, then select the up or down options to move it higher or lower in the list. Moving an interval higher in the list will cause it to be displayed further to the left in the Interval Selector, and moving it lower in the list will cause it to be displayed further to the right.   PriceData6   The Configure window pictured above allows the addition, removal, or editing of interval types and specific intervals in the Interval Selector.   Changing and Adding Instruments and Intervals with the Keyboard  You can change instruments or intervals by pressing a letter or number key in a selected chart. When a letter or number key is pressed, the Instrument Overlay appears. Within the Instrument Overlay, you can change the instrument, interval, or chart type by using the formats in the table below and pressing the "Enter" key when finished. If multiple instruments are displayed in the chart, you can change a specific instrument by left mouse clicking to select it before typing. If no instrument is selected, the primary instrument is changed.   PriceData7     | To change an instrument: | Type the instrument symbol (Add the contract month for futures instruments). Examples: "ES \#\#\-\#\#" for E\-mini S\&P 500, "AAPL" for Apple stock, or "EURUSD" for Euro/USD forex pair. | | --- | --- | | To change an interval: | Type interval value plus the interval suffix (Value \+suffix). Examples: "5M" for 5 minute bars, "100T" for 100 tick bars, "1D" for 1 Day bars,10 etc. | | Available suffixes: | Suffix interval: | | M | Minute | | T | Tick | | V | Volume | | R | Range | | S | Second | | D | Day | | W | Week | | MO | Month | | Y | Year | | RE | Renko | | To change instrument and interval | Type the symbol and interval together. For example, typing "AAPL 5M" will change to a 5 minute chart of Apple stock. | | To add additional series of primary instrument | Type a plus sign (\+) plus the interval. For example, typing "\+5M" will add a 5 minute Data Series of the primary instrument. | | To add additional series of any instrument | Type a plus sign (\+) plus the instrument and interval. For example, typing "\+AAPL 5M" will add a 5 minute series of Apple stock. If no interval is provided, then the same interval as the primary series will be added. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Removing a Data Series](javascript:HMToggle('toggle','RemovingADataSeries','RemovingADataSeries_ICON'))




| Removing a Data Series There are three ways to remove a Data Series from your NinjaTrader chart:   •Open the Data Series window (see the "Understanding the Data Series window" section above). Select a Data Series from the "Applied" section, then select the Remove option, then press the OK button to close the Data Series window. •Left mouse click a Data Series on your chart to select it, then press the "Delete" button on your keyboard.•Left mouse click  a Data Series on your chart to select it, then right mouse click the Data Series and select the Remove menu item.  If only one Data Series is applied to a chart, it cannot be removed. However, the original Data Series added to a chart can be removed if there is at least one other Data Series is still applied. |
| --- |










