


Operations \> Order Entry \> Trade Controls \> Quantity Selector






















Quantity Selector







| \<\< [Click to Display Table of Contents](quantity_selector.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Order Entry](order_entry-1.md) \> [Trade Controls](trade_controls-1.md) \> Quantity Selector | [Previous page](price_selector-1.md) [Return to chapter overview](trade_controls-1.md) [Next page](tif_selector-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









The Quantity Selector is a standard control available from all order entry features which allows you to select the number of contracts that are prepared for an custom order.  


![tog_minus](tog_minus-1.gif)        [Default Order Quantities](javascript:HMToggle('toggle','DefaultOrderQuantities','DefaultOrderQuantities_ICON'))




| Minimum Quantity Size The Quantity Selector is smart in that it will automatically fill in the minimum quantity value depending on the type of instrument that is selected. This is particularly useful when switching from one instrument type to another.   The table below will show the minimum quantity for each instrument type:     | Instrument Type | Default Minimum Quantity | | --- | --- | | Future | 1 | | Stock | 100 | | CFD | 1 | | Option | 1 | | Forex | Forex lot size \- 100K (Full), 10K (Mini), or 1K (Micro) |        | Note: Forex lot sizes are automatically determined by your Forex brokerage account connection. For Simulation account Forex lot size, see "Managing simulation accounts" section of the global [Trading](options_trading-1.md) options | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Increasing or Decreasing Quantity](javascript:HMToggle('toggle','IncreasingOrDecreasingQuantity','IncreasingOrDecreasingQuantity_ICON'))




| Adjusting Quantity The Quantity Selector allows you to type directly in the quantity field to specify an exact quantity with your keyboard.   You can also control the quantity using the up/down arrows next to the quantity selector, or by using the scroll wheel on your mouse.  These methods will change the quantity depending on the instrument type's minimum values described in the "Default Order Quantities" section above.     For example with a Stock selected, simply scrolling up with your mouse will change a quantity of 100 to 200\.  Holding the CTRL key on your keyboard and modifying the order quantity will increase or decreasing the value by 10\.  This means if you were to hold the CTRL key while scrolling on the Quantity Selector will increase Stock quantity from 100 to 1,100\. |
| --- |



![tog_minus](tog_minus-1.gif)        [Preset Quantity Pad](javascript:HMToggle('toggle','PresetQuantityPad','PresetQuantityPad_ICON'))




| Using Preset Quantities Middle mouse clicking on the Quantify Selector will display a Preset Quantity Pad which will allow you to optionally predefine the number of contracts used as the quantity.   Shared_Trade_Controls_2     | 1\. Quick | Sets the order quantity used to an exact pre\-defined quantity | | --- | --- | | 2\. Increment | Increases the current order quantity value by pre\-defined value |      For example if your current quantity was set to a value of 1, and you wanted to quickly set the quantity to 10, you would simply select 10 from the left side of the Preset Quantity Pad. If you wanted to increase the current quantity by 2, you would select the \+2  from the right side of the Preset Quantity Pad. Doing so will increase the current value from 1 to 3\. Selecting \+2 again would then change the quantity from 3 to 5\.   Selecting the "clear" button will reset the current order quantity to the instrument's minimum order quantity size.   Customizing Preset Quantities You can customize the preset quantity values that are displayed in these fields by selecting the "configure" button from the Preset Quantity Pad.     Shared_Trade_Controls_3   Adding a Custom Preset 1\.Select the desired Preset (Quick or Increment) from the left side Presets panel 2\.Press the "add" button in the right panel3\.Set the desired Quantity value4\.Press OK  Removing a Custom Preset 1\. Select the desired Quantity/Increment value from the right side Quantities panel 2\. Select the "remove" button   Note: Order quantities will always be organized from low to high values |
| --- | --- | --- | --- | --- |










