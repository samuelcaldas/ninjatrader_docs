﻿
Operations > Automated Trading > Automated Trading Interface (ATI) > DLL Interface > Functions

Functions

| << [Click to Display Table of Contents](functions.md) >> **Navigation:**     [Operations](operations.md) > [Automated Trading](automated_trading.md) > [Automated Trading Interface (ATI)](automated_trading_interface_at.md) > [DLL Interface](dll_interface.md) > Functions | [Previous page](dll_interface.md) [Return to chapter overview](dll_interface.md) [Next page](tradestation_email_integration.md) |
| --- | --- |
## DLL Interface Functions
int Ask(string instrument, double price, int size)
Sets the ask price and size for the specified instrument. A return value of 0 indicates success and -1 indicates an error.
 
int AskPlayback(string instrument, double price, int size, string timestamp)
Sets the ask price and size for the specified instrument for use when synchronizing NinjaTrader playback with an external application playback. A return value of 0 indicates success and -1 indicates an error. The timestamp parameter format is "yyyyMMddHHmmss".
 
double AvgEntryPrice(string instrument, string account)
Gets the average entry price for the specified instrument/account combination.
 
double AvgFillPrice(string orderId)
Gets the average entry price for the specified orderId.
 
int Bid(string instrument, double price, int size)
Sets the bid price and size for the specified instrument. A return value of 0 indicates success and -1 indicates an error.
 
int BidPlayback(string instrument, double price, int size, string timestamp)
Sets the bid price and size for the specified instrument for use when synchronizing NinjaTrader playback with an external application playback. A return value of 0 indicates success and -1 indicates an error. The timestamp parameter format is "yyyyMMddHHmmss".
 
double BuyingPower(string account)
Gets the buying power for the specified account. *Not all brokerage technologies support this value.
 
double CashValue(string account)
Gets the cash value for the specified account. *Not all brokerage technologies support this value.
 
int Command(string command, string account, string instrument, string action, int quantity, string orderType, double limitPrice, double stopPrice,   

 string timeInForce, string oco, string orderId, string strategy, string strategyId)
Function for submitting, cancelling and changing orders, positions and strategies. Refer to the [Commands and Valid Parameters](commands_and_valid_parameters.md) section for detailed information. The [Log](log_tab2.md) tab will list context sensitive error information.
 
int ConfirmOrders(int confirm)
The parameter confirm indicates if an order confirmation message will appear. This toggles the global option that can be set manually in the NinjaTrader Control Center by selecting the Tools menu and the menu item Options, then checking the "Confirm order placement" checkbox. A value of 1 sets this option to true, any other value sets this option to false.
 
int Connected(int showMessage)
Returns a value of zero if the DLL has established a connection to the NinjaTrader server (application) and if the ATI is currently enabled or, -1 if it is disconnected. Calling any function in the DLL will automatically initiate a connection to the server. The parameter showMessage indicates if a message box is displayed in case the connection cannot be established. A value of 1 = show message box, any other value = don't show message box.
 
int Filled(string orderId)
Gets the number of contracts/shares filled for the orderId.
 
int Last(string instrument, double price, int size)
Sets the last price and size for the specified instrument. A return value of 0 indicates success and -1 indicates an error.
 
int LastPlayback(string instrument, double price, int size, string timestamp)
Sets the last price and size for the specified instrument for use when synchronizing NinjaTrader playback with an external application playback. A return value of 0 indicates success and -1 indicates an error. The timestamp parameter format is "yyyyMMddHHmmss".
 
double MarketData(string instrument, int type)
Gets the most recent price for the specified instrument and data type. 0 = last, 1 = bid, 2 = ask. You must first call the SubscribeMarketData() function prior to calling this function.
 
int MarketPosition(string instrument, string account)
Gets the market position for an instrument/account combination. Returns 0 for flat, negative value for short positive value for long.
 
string NewOrderId()
Gets a new unique order ID value.
 
string Orders(string account)
Gets a string of order ID's of all orders of an account separated by '|'. *If a user defined order ID was not originally provided, the internal token ID value is used since it is guaranteed to be unique.
 
string OrderStatus(string orderId)
Gets the order state (see definitions) for the orderId. Returns an empty string if the order ID value provided does not return an order.
 
double RealizedPnL(string account)
Gets the realized profit and loss of an account.
 
int SetUp(string host, int port)
Optional function to set the host and port number. By default, host is set to "localhost" and port is set to 36973. The default port number can be set via the General tab under Options. If you change these default values, this function must be called before any other function. A return value of 0 indicates success and -1 indicates an error.
 
string StopOrders(string strategyId)
Gets a string of order ID's of all Stop Loss orders of an ATM Strategy separated by '|'. Internal token ID value is used since it is guaranteed to be unique.
 
string Strategies(string account)
Gets a string of strategy ID's of all ATM Strategies of an account separated by '|'. Duplicate ID values can be returned if strategies were initiated outside of the ATI. 
 
int StrategyPosition(string strategyId)
Gets the position for a strategy. Returns 0 for flat, negative value for short and positive value for long.
 
int SubscribeMarketData(string instrument)
Starts a market data stream for the specific instrument. Call the MarketData() function to retrieve prices. Make sure you call the UnSubscribeMarketData() function to close the data stream. A return value of 0 indicates success and -1 indicates an error.
 
string TargetOrders(string strategyId)
Gets a string of order ID's of all Profit Target orders of an ATM Strategy separated by '|'. Internal token ID value is used since it is guaranteed to be unique.
 
int TearDown()
Disconnects the DLL from the NinjaTrader server. A return value of 0 indicates success and -1 indicates an error.
 
int UnsubscribeMarketData(string instrument)
Stops a market data stream for the specific instrument. A return value of 0 indicates success and -1 indicates an error.
