


Operations \> Order Entry \> Order Ticket \> Submitting Orders






















Submitting Orders







| \<\< [Click to Display Table of Contents](submitting_orders_order_ticket.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Order Entry](order_entry-1.md) \> [Order Ticket](order_ticket-1.md) \> Submitting Orders | [Previous page](display_overview_order_ticket-1.md) [Return to chapter overview](order_ticket-1.md) [Next page](properties_order_ticket-1.md) |
| --- | --- |














The Order Ticket window is used to quickly define and submit custom orders.  This interface does not display any type of position or trade management features.  For those purposes, you would want to consider one of the other order management features: [Basic Entry](basic_entry-1.md), [Chart Trader](chart_trader-1.md), [FX Pro](fx_pro-1.md), [FX Board](fx_board-1.md), or [SuperDOM](superdom-1.md).


![tog_minus](tog_minus-1.gif)        [Selecting instruments and account](javascript:HMToggle('toggle','SelectingInstrumentsAndAccount','SelectingInstrumentsAndAccount_ICON'))




| How to Select an Instrument There are multiple ways to select an Instrument in the Order Ticket window.   •Select the Instrument Selector to open a list of recently used instruments or instruments contained in a predefined list  •With the Order Ticket window selected begin typing the instrument symbol directly on the keyboard. Typing will trigger the Overlay Instrument Selector.   For more Information on instrument selection and management please see [Instruments](instruments-1.md) section of the Help Guide.   How to Select an Account A list of all connected accounts will be listed in the Account Selector. To change the account select the account you wish to trade through via this drop down list. |
| --- |



![tog_minus](tog_minus-1.gif)        [How to submit custom orders](javascript:HMToggle('toggle','HowToSubmitCustomOrders','HowToSubmitCustomOrders_ICON'))




| To Submit an Order 1\. Set the order Quantity field ([info](quantity_selector-1.md)) 2\. Select the order Type 3\. Set the TIF (Time in Force) field ([info](tif_selector-1.md)) 4\. Set the Limit price if applicable 5\. Set the Stop price if applicable 6\. Left mouse click either the BUY or SELL button   OrderTicket_6   Tips 1\. You can quickly retrieve the current last, bid, or ask price in the Limit and Stop price fields using the following commands:   •Middle click in the field to retrieve the last traded price,•CTRL \+ middle click in the filed to retrieve the best ask price•ALT \+ middle click in the field to retrieve the best bid price  2\. Hold down the CTRL key when increasing/decreasing limit/stop prices to change the price in steps of 10 tick increments.   Close Tab on Order Submission The Order Ticket window can optionally be configured to automatically close the current tab or window after the order has been submitted.  This was designed to help discard unwanted Order Ticket displays when trading multiple instruments.   To enable this functionality:   1\.Right click on the Order Ticket tab or window2\.Select Properties...3\.Check Close tab on order submission4\.Press OK  After the order has been submitted, it can be referenced from the [Orders Tab](orders_tab-1.md) of the Account Data or Control Center window. |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the OCO (One Cancel Other) function](javascript:HMToggle('toggle','UnderstandingTheOcooneCancelOtherFunction','UnderstandingTheOcooneCancelOtherFunction_ICON'))




| OCO Orders (One Cancels Other) The Order Ticket window allows you to specify a custom user defined OCO ID using any combination of numbers and letters in the OCO field.   The image below shows the Order Ticket window configured a pending order in which we've input an OCO ID of "OCO1".     OrderTicket_5   In the example above, any additional orders placed with the OCO ID set to "OCO1" will be tied together in an order group as long as these orders are active. If one order in the group is either filled, cancelled or rejected, all orders in the group with the same OCO id will be cancelled.     | Warning:  If an order which was part of an OCO group has already been filled or cancelled, you will need to submit the pending order with a new OCO ID otherwise the pending order will be rejected. | | --- | |
| --- | --- |










