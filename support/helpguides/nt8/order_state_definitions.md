
Operations \> Order Entry \> Order State Definitions

Order State Definitions

| \<\< [Click to Display Table of Contents](order_state_definitions.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> Order State Definitions | [Previous page](simulated_stop_orders.md) [Return to chapter overview](order_entry.md) [Next page](fifo_optimization.md) |
| --- | --- |
The table below describes the various order States your orders can be in as well as the color that represents this state in NinjaTrader. The colors can be seen when submitting, modifying or cancelling orders in the [Order Entry](order_entry.md) windows as well as the [Orders tab](orders_tab.md) of the Control Center.
 
## NinjaTrader Order State Definitions

| Order State | Definition | Color Code |
| --- | --- | --- |
| Initialized | Order information validated on local PC | Yellow |
| Submitted | Order submitted to the connectivity provider | Orange |
| Accepted | Order confirmation received by broker | Order type color |
| Working | Order confirmation received by exchange | Order type color |
| Suspended | Order held by broker and ready to be submitted when triggered | Order type color |
| Change submitted | Order modification submitted to the connectivity provider | Orange |
| Cancel pending | Order cancellation submitted to the connectivity provider/exchange | Orange |
| Cancelled | Order cancellation confirmed cancelled by exchange | No color |
| Rejected | Order rejected locally, by connectivity provider or exchange | No color |
| Partially filled | Order partially filled | No color |
| Filled | Order completely filled | No color |
| Trigger pending | Order held locally on PC and ready to be submitted to connectivity provider | Yellow |
 

| Notes: For orders in a Accepted or Working Order State, the order color will be reflective of the order type.  For example, a Limit order would by Cyan (by default) when Working. FXCM and Rithmic do not support GTD orders. These order will be submitted as GTC and the GTD functionality will be simulated on NinjaTrader. NinjaTrader must be connected for it to function |
| --- |
