


Operations \> Charts \> Working with Drawing Tools \& Objects






















Working with Drawing Tools \& Objects







| \<\< [Click to Display Table of Contents](working_with_drawing_tools__ob.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Charts](charts-1.md) \> Working with Drawing Tools \& Objects | [Previous page](working_with_indicators-1.md) [Return to chapter overview](charts-1.md) [Next page](working_with_automated_strateg-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









There are many customizable Drawing Tools and objects available to use in NinjaTrader charts. Drawing Tools can be applied to individual charts or all open charts displaying the same instrument, and templates for each Drawing Tool can be saved to apply commonly used properties in the future.


 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus-1.gif)        [How to draw on a chart](javascript:HMToggle('toggle','HowToDrawOnAChart','HowToDrawOnAChart_ICON'))




| Drawing on a Chart Various Drawing Tools are available and customizable within a chart. The image below shows an example of several Drawing Tools applied to a chart.   DrawObjects1   Accessing  Drawing Tools Drawing Tools can be accessed in three ways:   •Right mouse click within the chart and select the Drawing Tools menu, then select an individual Drawing Tool from the list that appears•Left mouse click on the Drawing Tools button in the toolbar at the top of the chart, then select the Drawing Tool you wish to use•Press the default or custom [Hot Key](hot_key_manager-1.md) for a specific drawing tool (see the list of default hot keys under the "Available Drawing Tools" heading below)  Stay in Draw Mode When "Stay in Draw Mode" is enabled from the Drawing Tools menu, any drawing tool you select will remain selected after creating a drawing object with that tool. The Drawing Tool can then be used to draw multiple objects without having to access the Drawing Tools menu each time.   Line Tools There are multiple Line tools which can be utilized. They can be placed as desired or after placing the first anchor, you can hold SHIFT on the keyboard and move the mouse around to adjust the line in 45 degree increments. This is based on chart scaling at the time the line is placed.   Ruler Tool The Ruler measures the number of bars, length of time, and y\-axis distance between two anchor points for a Data Series. The measurement data is attached in a flag at a third, independent anchor point.   To use the Ruler:   1\.Select the Ruler Drawing Tool from the Drawing Tools menu2\.If you have more than one Data Series or indicator applied to your chart, first select the Data Series or indicator you wish to measure by left mouse clicking on it 3\.Left mouse click on the chart where you wish to place the first anchor point4\.Left mouse click a second time on the chart where you wish to place the second anchor point5\.Left mouse click a third time to set the anchor point for the Ruler display flag.  The anchor points can be relocated by left mouse clicking on an anchor point and dragging it to a new location.   DrawObjects2   In the image above, we see the ruler tool used to measure a distance of 42 bars over 7 hours, with a y\-axis movement of 10\.75 points.   Risk\-Reward Tool The Risk\-Reward tool can help you to determine the placement of your profit targets to achieve a specific risk/reward ratio on any trade.   To use the Risk\-Reward tool:   1\.Select the Risk\-Reward Drawing Tool from the Drawing Tools menu2\.If you have more than one Data Series applied to your chart, first select the Data Series you wish to work with by left mouse clicking on it 3\.Left mouse click on the chart at the entry price of an active, pending, or hypothetical trade4\.Left mouse click a second time on the chart at the point representing the maximum risk you are willing to take on the trade5\.Open the Properties window for the Drawing Object you have just placed (See the "Understanding Drawing Object Properties" section below)6\.Enter your desired Risk/Reward ratio in the "Ratio" field, then select the OK button  Once the object has been drawn and the Risk/Reward ratio set, two lines will extend outward from the first anchor point. The first line, culminating in a number colored red by default, represents the maximum risk you are willing to take, as specified by the second anchor point. The second line, culminating in a number colored green by default, represents the price point determined by multiplying the risk by the chosen Risk/Reward ratio.    DrawObjects9   1\. In the image above, the first anchor point is set at 1\.08900, with a risk/reward ratio of 1\.5 2\. The second anchor point (the maximum risk) is set at 1\.08430 3\. Based on the 0\.00470 distance between the first and second anchor points (1\.08900 \- 1\.08430\), the third anchor point is automatically placed at 1\.09605 to achieve a 1:1\.5 risk/reward ratio (1\.08900 \+ (0\.00470 \* 1\.5\))   Region Highlight X / Region Highlight Y The Region Highlight X and Region Highlight Y tools allow you to highlight or shade an entire horizontal or vertical region on a chart. The Highlight Region X tool will highlight a horizontal region, and the highlighting will extend indefinitely upwards and downwards, keeping the highlight in place if you choose to re\-scale the chart on the price axis. The Highlight Region Y tool will highlight a vertical region, and in the same way, will extend the highlighting indefinitely to the right and left, allowing you to draw a region which will continue to cover the entire width of the chart as new bars come in, or as you scroll backwards on the time axis.   To use the Region Highlight X or Region Highlight Y tools:   1\.Select one of the two tools from the Drawing Tools menu2\.When using Region Highlight X, click on the chart where you would like to place the first anchor point, then click once more to the left or right of that point to place the second anchor point3\.When using Region Highlight Y, begin the same way, but place the second anchor point above or below the first anchor point  DrawObjects11   The image above shows the Highlight Region X tool in use, highlighting a 7\-leg uptrend.   DrawObjects12   The image above shows the Highlight Region Y tool in use, highlighting a recent consolidation.   Available Drawing Tools Following are the available Drawing Objects and their associated default hot keys found within the Drawing Tools menu:     | Ruler | Ctrl \+ F3 | | --- | --- | | Risk/Reward | Ctrl \+ F4 | | Region Highlight X | Ctrl \+ F1 | | Region Highlight Y | Ctrl \+ F2 | | Line | F2 | | Ray | F3 | | Extended Line | F4 | | Arrow Line | Ctrl\+F2 | | Horizontal Line | F6 | | Vertical Line | F7 | | Path | Ctrl \+ 4 | | Fibonacci Retracements | F8 | | Fibonacci Extensions | F9 | | Fibonacci Time Extensions | F10 | | Fibonacci Circle | F11 | | Andrew's Pitchfork | Ctrl \+ F8 | | Gann Fan | Ctrl \+ F9 | | Regression Channel | Ctrl \+ F10 | | Trend Channel | Ctrl \+ 2 | | Time Cycles | Alt \+ F11 | | Ellipse | Ctrl \+ F11 | | Rectangle | Ctrl\+ F12 | | Triangle | Ctrl \+ F6 | | Polygon | Alt \+ F10 | | Order Flow Volume Profile | Ctrl \+ 3 | | Arc | Ctrl \+ F7 | | Text | F12 ( Tip : pressing Alt \+ Enter while editing the draw text content lets you create line breaks) | | Chart Marker: Arrow Up Arrow Down Diamond Dot Square Triangle Up Triangle Down | Alt\+F2 Alt \+F3 Alt \+F5 Alt \+F6 Alt \+F7 Alt \+F8 Alt \+F9 |      Applying a Drawing Object to a Chart To apply a Drawing Object to a chart, using a Drawing Tool:   1\.Select a drawing tool from the Drawing Tools menu. The cursor will change to resemble a pen (Right clicking or pressing the "Esc" key will cancel the operation).2\.Left mouse click on the chart where you wish to set the first anchor point.3\.Left mouse click again on the chart for any other necessary anchor points. Once all anchor points are set, the cursor will change back to the cursor type you had previously selected.  Once the Drawing Object is applied to the chart, it can be selected by left mouse clicking on it. Once selected, the object can be moved throughout the chart, and the anchor points can be moved by left mouse clicking and dragging to a new location. |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding snap mode](javascript:HMToggle('toggle','UnderstandingSnapMode','UnderstandingSnapMode_ICON'))




| Snap Mode Drawing Objects can be attached to price and/or time data within the chart by using any of the Snap Mode options available in the Drawing Tools menu:     | Disabled | Disables Snap Mode and allows the Drawing Object anchor point(s) to be placed anywhere on the chart | | --- | --- | | Bar | Sets the x\-axis value of Drawing Object anchor point(s) to the bar interval values only | | Price | Sets the y\-axis value of Drawing Object anchor point(s) to the price, rounded to the nearest tick | | Bar and Price | Sets the x\- and y\-axis of Drawing Object anchor point(s) to be aligned with bar interval values, Data Series OHLC, and indicator price values only | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding drawing object properties](javascript:HMToggle('toggle','UnderstandingDrawingObjectProperties','UnderstandingDrawingObjectProperties_ICON'))




| Each Drawing Tool can be customized using the Drawing Objects window.   Accessing the Drawing Object Properties To access the Drawing Objects dialogue:   1\.Left mouse click on a drawing object to select it (once selected, the anchor points will be visible).2\.Either double left mouse click on the drawing object, or right mouse click and select the Properties menu item.  The Drawing Objects dialogue is also accessible directly from the Drawing Tools menu on the chart toolbar, or by right mouse clicking in a chart, then selecting the Drawing Tools menu item.     | Note: Regardless of the method used to open the Drawing Objects dialogue, all Drawing Objects on the chart will be accessible in the dialogue. At any time, you can select a different object from the list in the "Configured" section to edit its properties. | | --- |      Drawing Object Properties Menu Properties vary between drawing objects. There are common properties, as shown in the image below, and there are also specific properties depending on the type of Drawing Object.   The general properties of the drawing object are located in the General section. The image below shows the General section properties for all Drawing Objects, as well as addition properties unique to the Line Drawing Object.   DrawObjects3   The properties listed below are included for all Drawing Tools, in addition to each tool's unique properties:     | Attach to | Applies the Drawing Object to the selected instrument on a single chart or all charts with the same instrument (see the "Understanding local vs. global drawing objects" section below). Additionally, a drawing object can be applied to an indicator so that it will be associated to the indicator and it's scale | | --- | --- | | Auto Scale | Adds the Drawing Object to the auto\-scaling of the chart. | | Locked | Locks the Drawing Object in position on the chart, making it immovable. You can also lock a Drawing Object by left clicking the object to select it, then right clicking the object to view the right click menu, then selecting Lock. | | Tag | The Tag property is a naming convention used to access the drawing object via NinjaScript. Any Tag values generated via NinjaScript are grayed out and cannot be changed. Each Drawing Object must have a unique Tag value. | | Visible | Enables or disables the visibility of the Drawing Object on the chart |      The Data section displays the data locations of the Drawing Object anchor points in the chart. These fields can be modified to change the location of the Drawing Object within the chart. Some drawing tools will include additional properties in the Data section, and some may include variations of the following properties:     | Start Time | Sets the x\-axis start value of the drawing object | | --- | --- | | Start Y | Sets the y\-axis start value of the drawing object | | End Time | Sets the x\-axis end value of the drawing object | | End Y | Sets the y\-axis end value of the drawing object | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding Drawing Object templates](javascript:HMToggle('toggle','UnderstandingDrawingObjectTemplates','UnderstandingDrawingObjectTemplates_ICON'))




| Drawing Object properties can be saved as a template, allowing you to quickly apply those settings to a new Drawing Object of the same type in the future.   What is Saved The following properties are saved in the General section:   •Auto scale•Color•Dash Style•Width  Attach to will default to the Data Series on which the object is drawn. Tag will be automatically updated for each new drawing object. Locked will default to False. Visible will default to True. Properties within the Data section will NOT be saved.   Saving Drawing Object Templates To save Drawing Object settings:   1\.Open the Drawing Object Properties window by either double left mouse clicking on the drawing object or right mouse clicking and selecting Properties.2\.Set desired parameters3\.Left mouse click on the template text located in the bottom right of the Properties dialog. Selecting save will open the Save window, in which you can enter a name for a new template, select an existing template to overwrite it or could click Save as default to save your settings as the new default applied settings for that drawing object.4\.Click the Save / Save as Default button when finished  If you wish to load a previously saved template, you can select the load option after left mouse clicking on the template text. If you change your settings and later wish to go back to the original settings, you can left mouse click on the template text and select the reset option.   In the image below, a template will be saved for the Ray drawing tool.   ChartDefaults7   In the image below, we can enter a name for the new Ray template and save it for future use.   DrawObjects8   Loading a Drawing Object Template A Drawing Object template that was previously saved can be applied to any Drawing Object of the same type. For example, a template for the Fibonacci Extensions tool can be applied to a Fibonacci Extensions Drawing Object, but not to a Line Drawing Object.   To load a Drawing Object template:   1\.Left mouse click on the template text, then select the load option.2\.The Load window will appear. Select the template to load from the list of templates, then press the Load button.  Removing a Drawing Object Template To remove a Drawing Object template from the list of saved templates:   3\.Left mouse click on the template text, then select either the Save or Load menu items 1\.The Save or Load window will appear, depending on which menu item you selected. Right mouse click the template for removal from the list of templates, then select the Remove menu item.  Renaming a Drawing Object Template To rename a Drawing Object template from the list of saved templates:   4\.Left mouse click on the template text, then select either the Save or Load menu items 2\.The Save or Load window will appear, depending on which menu item you selected. Right mouse click the existing template in the list, then select the Rename menu item.  In the image below, we can either remove or rename the selected Drawing Object template.   DrawObjects4 |
| --- |



![tog_minus](tog_minus-1.gif)        [How to remove drawing objects](javascript:HMToggle('toggle','HowToRemoveDrawingObjects','HowToRemoveDrawingObjects_ICON'))




| Removing Drawing Objects To remove a single Drawing Object:   1\.Left mouse click on the Drawing Object to select it (when selected, the anchor points will appear)2\.Press the Delete key on the keyboard or right mouse click on the drawing object and select the Remove menu item  To remove multiple Drawing Objects at the same time:   1\.Select the Drawing Tools menu via right mouse clicking in chart or via left mouse clicking the Drawing Tools icon in the chart toolbar2\.Left mouse click on the Remove All Drawing Objects menu item, and dialogue box will appear to confirm that you wish to remove all drawing object.3\.Click the Yes button to confirm    | Notes: •Removing a Global Drawing Object will remove the object from all charts.•Using the Remove All Drawing Objects menu item will NOT remove any locked drawing objects from the chart. Drawing Objects placed via NinjaScript will not be removed by this method, either. | | --- | |
| --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding local vs. global drawing objects](javascript:HMToggle('toggle','UnderstandingLocalVsGlobalDrawingObjects','UnderstandingLocalVsGlobalDrawingObjects_ICON'))




| Drawing Objects can be applied to a specific chart (local), or to all charts of the same instrument (global).    How to Enable a Global Drawing Object To enable a Global Drawing Object:   1\.Apply a Drawing Object to the chart (see the "How to draw on chart" section above)2\.Access the Drawing Object's properties from the Drawing Objects dialogue (see the "Understanding drawing object properties" section above) 3\.Locate the "Attach to" drop down menu and select "Instrument name" (All charts)  The Drawing Object will now be applied to all charts for that specific instrument as well as any new charts opened for that instrument. Global Drawing Objects are stored even when a chart of the instrument is not open.   DrawObjects5     | Tips:  •You can set Global Drawing Objects to be drawn in all currently open workspaces in the General section of the Options window. To access the Options window, select the Tools menu from the Control Center, then select the Options menu item. In the General section of the Options window, enable or disable the "Global drawing objects across workspaces" property.•If you wish to exclude a Global Drawing Object from one or more charts, you can do so by setting the property "Show global draw objects" to false in the [Format Data Series](working_with_price_data-1.md) window on the chart(s) you wish to exclude.•Making a draw object global means that the object would be redrawn and thus the [z\-order](chartobjects-1.md) reset to its default.•A drawing object marked as global will only display on other charts that match the scale justification of the plot it is attached to. | | --- | |
| --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding drawing object levels](javascript:HMToggle('toggle','UnderstandingDrawingObjectLevels','UnderstandingDrawingObjectLevels_ICON'))




| Drawing Object Levels Drawing Tools that include lines drawn at multiple, customizable price levels, such as Fibonacci Retracements, include a "Levels" property which can be used to add, remove, or edit levels displayed in objects drawn with that Drawing Tool.    The following Drawing Tools include a "Levels" property in the Drawing Objects dialogue:   •Fibonacci Retracements•Fibonacci Extensions•Fibonacci Time Extensions•Fibonacci Circle•Andrew's Pitchfork•Trend Channel  Managing Drawing Object Levels To add, remove, or edit levels, first left mouse click on a Drawing Object to select it, then either double\-left mouse click the Drawing Object, or right mouse click it and select the Properties menu item to open the Drawing Objects dialogue. The Levels field will display the number of levels currently applied. Left mouse click within this field to open the Levels dialogue, in which you can manage the levels applied to that object.   DrawObjects6   Adding Drawing Object Levels In the Levels dialogue, click the add option to add a new price level. A new level will be added to the bottom of the list in the "Configured" section, and will be automatically selected for editing. You can then customize the new level's line color, dash style, width and value (in percent) the "Properties" section. You can also enable or disable visibility of the level in this section.     | Note: The value property of a level is always expressed in percentage terms, and the placement of the line corresponding to that level will be based upon the anchor points you set for that particular Drawing Object. | | --- |      Removing Drawing Object Levels To remove a level from within the Levels dialogue, first select the level you wish to remove from the list, then select the remove option.   Editing Drawing Object Levels To edit an existing level from within the Levels dialogue, first select the level you wish to edit, then change any of the properties for that level in the Properties section. When all properties are set to your desired values, click the OK button to save the changes and close the window.   DrawObjects7   1\. Add new price levels with the add option 2\. Remove existing price levels with the remove option 3\. Edit properties for new or existing levels in the Properties section |
| --- | --- |










