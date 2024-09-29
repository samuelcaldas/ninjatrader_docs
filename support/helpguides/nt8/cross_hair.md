


Operations \> Charts \> Cross Hair






















Cross Hair







| \<\< [Click to Display Table of Contents](cross_hair.md) \>\> **Navigation:**     [Operations](operations.md) \> [Charts](charts.md) \> Cross Hair | [Previous page](data_box.md) [Return to chapter overview](charts.md) [Next page](trading_from_a_chart.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









The Cross Hair changes the cursor to a pair of intersecting vertical and horizontal lines, allowing you to use your cursor to pinpoint specific coordinates on your chart. The lines displayed by the Cross Hair extend to the X (time) axis and Y (price) axis of the chart, and include markers in both axes to display the precise position of the cursor. The Global Cross Hair allows you to link Cross Hairs from multiple chart windows. This means that as you move the Global Cross Hair in one chart, all other Global Cross Hairs will move together by automatically staying at the same time and price.


 


![tog_minus](tog_minus.gif)




| Enabling the Cross Hair There are multiple ways to enable the Cross Hair within a chart window:   CrossHair_ChartIcon   •Left mouse click on the Cursor icon in the chart toolbar and select the Local menu item. •Right mouse click within the chart and select the Crosshair menu, then select the Local menu item.•Use the default CTRL \+Q [Hot Key](hot_key_manager.md)  The cursor icon within the chart toolbar will change to a cross hair icon, letting you know that Cross Hair is enabled on the chart. |
| --- |



![tog_minus](tog_minus.gif)




| Enabling the Global Cross Hair Just like the Cross Hair, there are multiple ways to enable the Global Cross Hair within a chart window:   GlobalCrossHair_ChartIcon   •Left mouse click on the Cursor icon in the chart toolbar and select the Global menu item. •Right mouse click within the chart and select the Crosshair menu, then select the Global menu item.•Use the default CTRL \+G [Hot Key](hot_key_manager.md)  The cursor icon within the chart toolbar will change to a cross hair icon with a square border, letting you know that Global Cross Hair is enabled on the chart.      | Tips:  •If the active Global Cross Hair moves outside the viewable horizontal range of any other chart with Global Cross Hair enabled, the horizontal axis in the inactive charts will automatically scroll to keep aligned with the active cursor. If you wish to use the Global Cross Hair with time\-axis scrolling disabled, you can select Global (No Time Scroll) from either the chart toolbar or the Crosshair menu. With Global (No Time Scroll) selected, the cursor icon within the chart toolbar will display a cross hair with a round border. | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [How to use the Global Cross Hair](javascript:HMToggle('toggle','HowToUseTheGlobalCrossHair','HowToUseTheGlobalCrossHair_ICON'))




| Using the Global Cross Hair The Global Cross Hair must be enabled on more than one chart in order to take full advantage of its functionality.   The images below shows two CL charts, a 1 Minute and 5 Minute, both with Global Cross Hair enabled. Notice the time and price cross hair values in each chart are the same. When the cursor is moved in any chart with Global Cross Hair enabled, cross hairs in all other charts with Global Cross Hair enabled will move as well, to stay at the same time and price coordinates.    GlobalCrossHair_OneMinChart   1\. The cursor is active on the 1\-minute chart, and the time and price axis values corresponding to the position of the Global Cross Hair are displayed.   GlobalCrossHair_FiveMinChart   2\. The position of the Global Cross Hair on the 5\-minute chart automatically updates based on the position of the cursor in the 1\-minute chart. |
| --- |



![tog_minus](tog_minus.gif)        [Cross Hair Options](javascript:HMToggle('toggle','CrossHairOptions','CrossHairOptions_ICON'))




| Cross Hair Options •You can optionally lock the crosshair in a specific point in time.  To lock the time (vertical) line of the Cross Hair or Global Cross Hair, while retaining the ability to move the horizontal line, you can enable the Locked property within the Crosshair section of the [Chart Properties](chart_properties.md) window, or use the default CTRL \+L [Hot Key](hot_key_manager.md). When using the Global Cross Hair, locking will apply to all charts with Global Cross Hair enabled.  •Additional options related to the Cross Hair or Global Cross Hair can be set in the [Chart Properties](chart_properties.md) window. The following properties can be set:    | Color | Sets the color for the Cross Hair lines | | --- | --- | | Crosshair Type | Sets the type of Cross Hair to be enabled, including Local, Global, Global (No Time Scroll), and Off | | Dash Style | Sets the style to be used for the Cross Hair lines, including Solid, Dash, Dash Dot, Dash Dot Dot, and Dot | | Draw cursor only | Enables or disables drawing only a mini Cross Hair without the full lines but including the price / time axis labels. This mode can improve performance for setups operating with a lesser powerful GPU. | | Locked | Enables or disables Cross Hair locking | | Width | Sets the width of the Cross Hair lines | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










