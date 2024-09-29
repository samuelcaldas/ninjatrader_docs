


Operations \> Alerts \> Condition Builder






















Condition Builder







| \<\< [Click to Display Table of Contents](condition_builder.md) \>\> **Navigation:**     [Operations](operations.md) \> [Alerts](alerts.md) \> Condition Builder | [Previous page](configuring_alerts.md) [Return to chapter overview](alerts.md) [Next page](alertsexamples.md) |
| --- | --- |














The Condition Builder is a very powerful feature that allows you to define complex conditions for your alerting systems without having to know how to program.  The sections below assume you have read and understood how to configure the alerts dialog and understand how to select a Condition Object to be used in the condition.  If you have not yet, please be sure to review the material under [Configuring Alerts](configuring_alerts.md).


 


![tog_minus](tog_minus.gif)




| Condition Builder Most if not all trading system code wizards are limited in scope in that they provide canned pre\-defined expressions and only allow you to change a few parameters on those expressions. The NinjaTrader Condition Builder is advanced in that you can develop powerful expressions with extensive configurations. Due to its power and flexibility, it is extremely important that you read through and understand its capabilities.   The Condition Builder can be accessed via the Alerts Dialog screen by selecting the "add" text   Condition_Builder_Add   Basic Operation The general concept of the Condition Builder to generate a Boolean expression also known as comparison expressions or conditional expressions. What does that mean? It is simply an expression that results in a value of either TRUE or FALSE. For example, the expression  2 \< 7 (2 is less than 7\) is a Boolean expression because the result is TRUE. All expressions that contain relational operators are Boolean. Boolean expressions or "Conditions" as they are known in NinjaTrader is used to determine when to take a specified action such as submitting an order or drawing on the chart.   Looking at the image below, you can instantly see that the Condition Builder is set up like a Boolean expression. Select an item from the left window, select the relational operator (2\) and compare it to a selected item in the right window.   Condition_Builder   1\. Available items such as indicators, price data, etc. to use for the comparison 2\. List of relational operators   Relational operator invalid comparisons Since the relational operator will let you select any items from the left to compare to the right in the Condition Builder, you need to be mindful what you attempt comparing. For example comparing a price based value like the ES \#\#\-\#\# Data Series to the Time category Time Value would not be possible, and prompt the Condition Builder to issue an error like shown below \-    "Type of left expression and right expression do not match, please select similar expressions"   Condition_Builder_cb1   To work around, you would need to select expressions with a similar return value that would allow for a programmatic comparison. In the example used above, the ES \#\#\-\#\# Data Series provides an double value in return that is attempted to be compared to a time span value, which Time Value would return.   The correct approach is shown below, the ES \#\#\-\#\# price would return a double value which would be compared to the Numeric Value 2275 to see if the price will Cross Above that.   Condition_Builder_cb2 |
| --- |



![tog_minus](tog_minus.gif)        [How to make chart price data comparisons](javascript:HMToggle('toggle','HowToMakeChartPriceDataComparisons','HowToMakeChartPriceDataComparisons_ICON'))




| Price Data Comparisons You can compare a chart's bar price data such as checking for a higher close.  In order to compare the current bar value, to a previous bar value, we will need to use a Chart's Data Series as our condition object.   In our example, we are using the ES 12\-14 (1 minute) Data Series as our condition object.   The following is an an example and represents one of many possible combinations.   1\.Select the Data Series and set the Price type to Close.2\.Select the "greater" relational operator3\.Select the Data Series and set the Price type to Close.4\.Set the Bars ago parameter to a value of "1"  Alerts_ConditionBuilder_PriceData1   Once the OK button is pressed, a condition is created that would translate to the following:   "Current closing price is greater than the closing price of 1 bar ago" |
| --- |



![tog_minus](tog_minus.gif)        [How to offset an item value](javascript:HMToggle('toggle','HowToOffsetAnItemValue','HowToOffsetAnItemValue_ICON'))




| Offsetting an Item Value You can offset the value of most items available in the Condition Builder. An offset is a value that is added or subtracted from the actual item's value. When an item is selected such as an indicator or price data, the Offset type and Offset parameters become visible in the window directly below the item selected. This is shown as numbers 5 and 6 in the image below.     | Note:  Offsetting a condition CANNOT be applied directly to Drawing Tools.  Should you wish to be alerted once a value is within N\-value of the drawing tool, apply the offset calculation to the data series or indicator condition. | | --- |        Offset type can be set to:     | Arithmetic | Performs simple math functions such as adding, subtracting, multiplying, or dividing from the items value | | --- | --- | | Pips | An absolute pip value (for forex) from the item's value | | Percent | A percentage value of the item's value. A value of 10 is equal to 10% | | Ticks | The number of ticks (0\.01 for stocks and the tick size for futures) from the item's value |        Once the Offset type is selected, you must set the value Offset.    The following is an example and represents one of many possible combinations:   1\. Select the Data Series and set the Price type to Close 2\. Select the "greater" relational operator 3\. Select the Data Series and set the Price type to High 4\. Set the Bars ago parameter to a value of "1" 5\. Set the Offset type parameter to Ticks 6\. Set the Offset parameter to a value of "1"   Alerts_ConditionBuilder_Offset   Once the OK button is pressed, a condition is created that would translate to the following:   "Current closing price is greater than the high price of 1 bar ago \+ 1 tick" |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [How to make indicator to value comparisons](javascript:HMToggle('toggle','HowToMakeIndicatorToValueComparisons','HowToMakeIndicatorToValueComparisons_ICON'))




| Indicator to Value Comparisons You can compare an indicator's value to a numeric value. This can come in handy if you wanted to check if ADX is over a value of 30 (trending) or if Stochastics is under a value of 20 (oversold) or any other conditions you can think of.   The following is an an example and represents one of many possible combinations.  We have already added the ADX indicator to our chart so it is available as [condition object](configuring_alerts.md).   1\.Under the Indicators category, select the ADX indicator2\.Select the "greater" relational operator3\.Select the Numeric value category4\.Enter the numeric value  Alerts_ConditionBuilder_Indicators   Once the OK button is pressed, a condition is created that would translate to the following:   "Current value of a 14 period ADX is greater than 15" |
| --- |



![tog_minus](tog_minus.gif)        [How to compare plot values of multi\-plot indicators](javascript:HMToggle('toggle','HowToComparePlotValuesOfMultiplotIndicators','HowToComparePlotValuesOfMultiplotIndicators_ICON'))




| Comparing Plot Values of Multi\-Plot Indicators You can compare plots in the same indicator or select any individual plot within an indicator to create a condition.   The following is an example and represents one of many possible combinations.  We have already added the Stochastics indicator to our chart so it is available as [condition object](configuring_alerts.md).   1\.Under the Indicators category, select the Stochastics indicator2\.Set the indicator plot and select the K plot 3\.Select the "greater" relational operator4\.Under the Indicators category, select the Stochastics indicator5\.Set the indicator input parameters and select the D plot   Alerts_ConditionBuilder_IndicatortoIndicator   Once the OK button is pressed, a condition is created that would translate to the following:   "Current K plot value of a Stochastics indicator is greater than the current D plot value of the same Stochastics indicator" |
| --- |



![tog_minus](tog_minus.gif)        [How to create a cross over condition](javascript:HMToggle('toggle','HowToCreateACrossOverCondition','HowToCreateACrossOverCondition_ICON'))




| Cross Over Conditions You can check for either a Cross Above or Cross Below condition with a user defined look back period. The look back period sets the number of bars to look back to check for the cross over condition.   The following is an an example and represents one of many possible combinations.  We have already added two EMA indicators (9 period EMA and 20 period EMA) to our chart so they are both available as [condition objects](configuring_alerts.md).   1\.Under the Indicators category, select the 9 period EMA indicator2\.Select "cross above" relational operator3\.Set the Look back period4\.Under the Indicators category, select the 20 period EMA indicator      | Notes:  •The Look back period must be at least 1 to function.•CrossInside and CrossOutside are reserved for drawing objects, setup examples could be found on the next section [Alerts Examples](alertsexamples.md) | | --- |        Alerts_ConditionBuilder_CrossAbove   Once the OK button is pressed, a condition is created that would translate to the following:   "9 period exponential moving average crosses above the 20 period exponential moving average in the last 15 bars" |
| --- | --- |



![tog_minus](tog_minus.gif)        [How to compare account position information](javascript:HMToggle('toggle','HowToCompareAccountPositionInformation','HowToCompareAccountPositionInformation_ICON'))




| Creating Account Position Comparisons You can compare your current account state information such as but not limited to account PnL or position size using the Market Analyzer.   The following is an an example and represents one of many possible combinations.  We have already added the Unrealized profit loss column to our Market Analyzer so it is available as [condition object](configuring_alerts.md).   1\.Under the Columns category, select the Unrealized profit loss column2\.Select the "less" relational operator3\.Under the Columns category, select the Number Value category4\.Set the Value  Alerts_ConditionBuilder_UnrealizedPnL   Once the OK button is pressed, a condition is created that would translate to the following:   "Current Unrealized profit loss  is less than \-$100" |
| --- |



![tog_minus](tog_minus.gif)        [How to create time comparisons](javascript:HMToggle('toggle','HowToCreateTimeComparisons','HowToCreateTimeComparisons_ICON'))




| Creating Time Comparisons You can compare a chart bar's time data to a user defined time or date value.   The following is an an example and represents one of many possible combinations.     | Note: Time series represents a collection of bar Date/Time values of a bar series which are available from a chart | | --- |      1\.Select the Time category and select the Data Series series2\.Select the "greater equal" relational operator3\.Expand the Time value category4\.Set the Time value parameter to a user defined value of "10:00 AM"  Alerts_ConditionBuilder_TimeComparison1   Once the OK button is pressed, a condition is created that would translate to the following:   "Current bar's time is greater or equal to 10:00 AM" |
| --- | --- |










