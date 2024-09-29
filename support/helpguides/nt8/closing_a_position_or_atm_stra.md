


Operations \> Order Entry \> Trade Controls \> Closing a Position or ATM Strategy Position






















Closing a Position or ATM Strategy Position







| \<\< [Click to Display Table of Contents](closing_a_position_or_atm_stra.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [Trade Controls](trade_controls.md) \> Closing a Position or ATM Strategy Position | [Previous page](trade_controls.md) [Return to chapter overview](trade_controls.md) [Next page](position_display.md) |
| --- | --- |











## Closing a position or ATM Strategy with the Close button


In all NinjaTrader order entry windows there are CLOSE action buttons which will close a position or an ATM Strategy depending on which mouse button is pressed (the left mouse button will close the current position and cancel any working orders associated with the instrument/account combination and the middle mouse button (scroll wheel) will close the selected active ATM Strategy position only).


 


When a position or ATM Strategy position is closed, NinjaTrader goes through the following process: (Assume we are long on the S\&P E\-mini contract at an entry price of 1000\.)


1\.Identify the active account and instrument 

2\.Send cancellation requests for any open orders on the active instrument/account

3\.Wait up to five seconds for cancellation confirmations from the connected brokerage

4\.After receiving confirmation for all cancellation requests, send an offset order to close any open position (For example, a Buy order for 3 contracts would be sent to close an open short position of 3 contracts)

 


The exception are currencies (FOREX) where all working orders are cancelled and then a market order is submitted to close the position. (Does not apply to currencies with Interactive Brokers where the previously described process is used.)


 


## Why not just submit a market order?


A lot of traders consume near 100% of their available margin. For example, you may have 1 contract position with one stop and target that consumes 90% of your margin. If you close a position by submitting a market order, the market order will get rejected due to insufficient funds and therefore cause grief if getting out of the position is critical.


 


The NinjaTrader approach offers several benefits:


•Modifying existing limit orders avoids the potential problem of breaching your account margin limitations when closing a position 

•With some brokers, modifying existing orders is more efficient than submitting new orders by up to 500 milliseconds 

•Cancellation of non essential orders unlocks available margin that could potentially get consumed if a market order is required to close out any remaining contracts that are not covered by existing limit orders 

 


This approach essentially guarantees the most efficient way to exit a position.








