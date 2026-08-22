# Running concurrent strategies in the same market

NinjaTrader uses a number of different properties in the TradeStation generated email to identify unique orders as they are sent to NinjaTrader.

## These properties include

- Instrument name

- Action (Buy, Sell etc...)

- Signal name

- Workspace name

## If you are running concurrent strategies on the same market you should ensure that you either

- Make all signal names unique or

- Run the concurrent strategies in different TradeStation workspaces

This will ensure accurate processing of your automated signals.