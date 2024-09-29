


Attach to Indicator






















Attach to Indicator







| \<\< [Click to Display Table of Contents](properties3_2_2.md) \>\> **Navigation:**   »No topics above this level«   Attach to Indicator | [Return to chapter overview](sharpdx_directwrite_textlayout-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









The SuperDOM provides the ability to attach an order to an indicator value, automatically moving the order in lockstep with the indicator as its value changes. This feature can be used for entries as well as resting exit orders such as Stop Losses and Profit Targets.


## 




| playVideo |
| --- |
|  |



![tog_minus](tog_minus-1.gif)        [How to attach an order to an indicator](javascript:HMToggle('toggle','HowToAttachAnOrderToAnIndicator','HowToAttachAnOrderToAnIndicator_ICON'))




| Attaching an Order to an Indicator Use the following steps to attach an order to an indicator: 1\.Apply at least one indicator to the SuperDOM (See the [Working with Indicators](working_with_indicators_superdom-1.md) page for more information).2\.Apply a resting order to the chart (See the [Submitting Orders](submitting_orders_superdom-1.md)page for more information).3\.Left mouse click the order label displayed on the price ladder.4\.Hold the Ctrl key on your keyboard. You will see a label that reads "attach" in the cell corresponding to any indicator configured on the SuperDOM.5\.Left mouse click the cell corresponding to the indicator to which you wish to attach the order, while continuing to hold the Ctrl key6\.The Attach to Indicator Properties window will appear, in which you can select the specific indicator to which to attach the order (if more than one is applied to the chart)7\.Change any properties as needed (see the "Attach to Indicator Properties" section below), then click the OK button.  SuperDOM_60   1\. In the image above, the Ctrl key is held down on the keyboard after left mouse clicking the order label.  2\. The next left mouse click in the cell corresponding to the indicator value will bring up the Attach to Indicator Properties window, which allows us to attach the order to the indicator. |
| --- |



![tog_minus](tog_minus-1.gif)        [Attach to Indicator properties](javascript:HMToggle('toggle','AttachToIndicatorProperties','AttachToIndicatorProperties_ICON'))




| Attach to Indicator Properties The Attach to Indicator Properties window can be accessed in one of two ways. Using the process outlined above to attach an order to an indicator will bring up this window automatically, allowing you to set parameters for the indicator tracking before attaching an order. Alternatively, you can use the process outlined below: 1\.Right mouse click the label connected to the order line for an order on the chart2\.Hover your cursor over the order listed in the right click menu that appears3\.Select the Attach to Indicator menu item4\.Select the Properties menu item  The Attach to Indicator Properties window allows you to set the following properties:   ChartTrader19     | Indicator | Allows the selection of a specific indicator to which to attach an order | | --- | --- | | Offset | Sets an offset value to allow an order to trail above or below an indicator plot | | Modify toward last price only | Restricts an order to only move towards the last traded price as it follows an indicator plot, never further away | |
| --- | --- | --- | --- | --- | --- | --- |










