


Operations \> Market Analyzer \> Working with Columns






















Working with Columns







| \<\< [Click to Display Table of Contents](working_with_columns.md) \>\> **Navigation:**     [Operations](operations.md) \> [Market Analyzer](market_analyzer.md) \> Working with Columns | [Previous page](working_with_instrument_rows.md) [Return to chapter overview](market_analyzer.md) [Next page](dynamic_ranking_and_sorting.md) |
| --- | --- |














The Market Analyzer allows you to add a variety of columns ranging from indicators to position information.  To add, remove, and customize columns in your Market Analyzer window please review the information below.


 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus.gif)




| The Columns window is used to add, remove, and edit columns within the Market Analyzer window.   Accessing the Columns Window To access the Columns window press down on your right mouse button in the Market Analyzer window and select the menu item Columns...   Sections of the Columns Window The image below displays the four sections of the Columns window.   1\.List of available columns2\.Current columns applied to the Market Analyzer3\.Selected column's parameters  MarketAnalyzer_22 |
| --- |



![tog_minus](tog_minus.gif)        [How to add columns](javascript:HMToggle('toggle','HowToAddColumns','HowToAddColumns_ICON'))




| A wide variety of columns can be added to your Market Analyzer window allowing you to see indicator, position, or price information at a glance.   Adding columns to the Market Analyzer window To add a column to the Market Analyzer window:   1\.Open the Columns window (see the "Understanding the Columns window" section above)    2\.Select the column you want to add from the list of available columns3\.Press the Add button or simply double click on the column you want to add4\.The column will now be visible in the list of applied columns5\.The column's parameters will be editable on the right side of the Columns window when the column is selected from the applied columns list (see the "How to customize columns" section below)6\.Press the OK button to apply the column(s) to your Market Analyzer, and exit the Columns window  MarketAnalyzer_23   Adding an Indicator Column To add an indicator column to the Market Analyzer window:   1\.Open the Columns window (see the "Understanding the Columns window" section above) 2\.Left mouse click on the Indicator column and press the Add button or simply double click on it3\.The column will now be visible in the list of applied columns and listed as "ADL on 1 Min data"4\.You can now select the indicator of your choice from the Indicator parameter |
| --- |



![tog_minus](tog_minus.gif)        [How to customize columns](javascript:HMToggle('toggle','HowToCustomizeColumns','HowToCustomizeColumns_ICON'))




| Once you have added columns to your Market Analyzer window (see the "How to add columns" section above) you can customize the column by editing the column's parameters.   Editing a Column's Parameters You can customize any column from the Columns window.   1\.Open the Columns window (see the "Understanding the Columns window" section above)  2\.Highlight the column you would like to edit in the list of Configured columns (as shown by the image below).3\.Once highlighted this column's parameters will be editable on the right hand side4\.You can choose to display the column Type as Regular or as a BarGraph5\.You can configure the color settings, including checking Enable color distribution to apply a range of colors based on their values6\.You can set [Cell or Filter](creating_cell_and_filter_condi.md) conditions for any column from the Conditions parameters section  MarketAnalyzer_24   Changing the Order and Width of Columns To order columns in the Market Analyzer window you can use "up" or "down" in the Configured columns section.   MarketAnalyzer_25   •Left mouse click "up" to move the selected applied column left in the Market Analyzer window•Left mouse click "down" to move the selected applied column right in the Market Analyzer window  Please see the [Data Grids](data_grids.md) section of the user help guide for information on sizing and ordering columns.   Understanding Indicator Column Properties An Indicator column has many unique properties used to determine how the indicator is calculated.  It is important to understand how these properties will impact the resulting indicator value displayed in your Market Analyzer column.     | Indicator |  | | --- | --- | | Indicator | Selects the indicator used for the column | | Plot | Selects which of the indicator's plot is used.  Some indicators will have several plots. | | Data Series |  | | Input Series | Selects the price type used. Close is the most common | | Price based on | Selects the data type used. Last is the most common | | Type | Selects the bar type which the indicator is calculated on | | Value | Selects the interval used in correlation to the bar type | | Time Frame |  | | Load data based on | Select from Bars, Days or a Custom Range in terms of historical data used for the indicator | | Bars to load | Selects the number of bars (or days) used requested to calculate the indicator. | | End date | Sets the last day used for calculation. | | Trading hours | Sets the trading session used for calculation | | Break at EOD | Sets if the indicator values are reset at the end of each session | | Set up |  | | Calculate | Sets the frequency that the indicator calculates.  On bar close will slow down the calculation until the close of a bar; On price change will calculate on when there has been a change in price; On each tick calculate the indicator's value which each incoming tick. | | Maximum bars look back | Max number of bars used for calculating an indicator's value.  The TwoHundredFiftySix setting is the most memory friendly. |        | Note: Setting the Type to Bar Graph under Data Series for text based columns will result in the column being blank. Text based columns require the Type to be Regular. | | --- |      Saving a Customized Column Presets Once you have an individual column properties set to your preference, you can left mouse click on the "preset" text located in the bottom right of the properties dialog. Selecting the option "save" will save these settings as the default settings used every time you apply a new column.   If you change your settings and later wish to go back to the original settings, you can left mouse click on the "preset" text and select the option to "restore" to return to the original settings. |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [How to remove columns](javascript:HMToggle('toggle','HowToRemoveColumns','HowToRemoveColumns_ICON'))




| Columns can be removed from the Columns window or from the Market Analyzer directly.   Removing Columns from the Market Analyzer Window There are two ways to remove a column:   1\.From the Market Analyzer window left mouse click on the column header and hold down the left mouse button to drag the column outside the Market Analyzer window, once the cursor changes to a black X release the left mouse button to remove the column.2\.Open the Columns window (see the "Understanding the Columns window" section above). Highlight the column you would like to remove in the list of Configured columns (as shown in the image below) then press the Remove button.  MarketAnalyzer_26 |
| --- |



![tog_minus](tog_minus.gif)        [Dynamic ranking and sorting](javascript:HMToggle('toggle','DynamicRankingAndSorting','DynamicRankingAndSorting_ICON'))




| See the [Dynamic Ranking and Sorting](dynamic_ranking_and_sorting.md) section of the user help guide for information on sorting and raking your Market Analyzer columns. |
| --- |










