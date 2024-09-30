
Operations > Advanced Trade Management (ATM) > ATM Strategy

ATM Strategy
| << [Click to Display Table of Contents](atm_strategy.md) >> **Navigation:**     [Operations](operations.md) > [Advanced Trade Management (ATM)](advanced_trade_management_atm.md) > ATM Strategy | [Previous page](server-side-vs-local-atms.md) [Return to chapter overview](advanced_trade_management_atm.md) [Next page](atm_strategy_parameters.md) |
| --- | --- |
## What is an ATM Strategy?
An ATM Strategy provides a semi-automated order management features to allow you to automate the management of a position. In trading, a position is defined as the total contracts/shares held long or short for a specific instrument in a specific account. An ATM Strategy can be thought of as:
 
"A collection of user defined rules/conditions that create and manage a set of Stop Loss and Profit Target orders that are used to govern a portion or an entire open position."
 
Let's assume the following:
 
- We want to go long the S&P E-Mini for 5 contracts 

- We want a Stop Loss set 2.5 points from our entry price 

- We want a Profit Target set 5 points from our entry price 

 
We just defined a set of conditions for the management of a 5 contract long position, or in other words, we just defined an ATM Strategy. The ATM Strategy is the foundation for how positions (or partial positions) can be managed within NinjaTrader. ATM Strategies can be defined on the fly or you can pre-define them using templates that can be recalled for later use in a split second.
 
## The Value of an ATM Strategy
Now that we understand what an ATM Strategy is, what exactly is the value of it? When trading, one develops ideas and methods for entry and further management of their position. The management of this position can be simple to complex and everything in between. The ATM Strategy allows the trader to define the rules and conditions that govern the management of the position. How many Profit Targets should there be and at what prices? What Auto Trail Stop Loss setting should be used? When should a Stop Loss be moved to breakeven? Should Profit Target orders chase the market if not filled? Should the Stop Loss order trigger immediately on trade through or should NinjaTrader's leading edge [Simulated Stop](simulated_stop_orders.md) order be used? An ATM Strategy also provides a layer of discretionary automation and intelligence that takes responsibility for mundane order modifications which can be inefficient, time-consuming and error prone. When scaling into a position, for example, all of the Stop Loss and Profit Target orders will be automatically updated to reflect the new position size. Changing order contract sizes will update the distribution of contracts on other orders. Decrease your first Profit Target order by one contract and your second Profit Target will automatically be increased by 1 contract. The bottom line is that an ATM strategy thinks the way a trader thinks about managing their trade only 100x faster. It performs a lot of the routine tasks for you allowing you to concentrate on what matters; the trade itself.
