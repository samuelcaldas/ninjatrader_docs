


Operations \> Automated Trading \> Automated Trading Interface (ATI) \> What can I do and how?






















What can I do and how?







| \<\< [Click to Display Table of Contents](what_can_i_do_and_how_.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Automated Trading Interface (ATI)](automated_trading_interface_at-1.md) \> What can I do and how? | [Previous page](automated_trading_interface_at-1.md) [Return to chapter overview](automated_trading_interface_at-1.md) [Next page](commands_and_valid_parameters-1.md) |
| --- | --- |














## What can I do through automation?


 


•Place orders 

•Initiate a NinjaTrader [ATM Strategy](advanced_trade_management_atm-1.md) 

•Change orders 

•Cancel orders 

•Close ATM Strategies and positions 

•Flatten accounts 

•Cancel all orders 

•Retrieve information on positions and orders 

 


NinjaTrader provides three options for communicating from an external application to NinjaTrader for trade automation. The Email Interface requires absolutely no programming experience whatsoever, other options require various levels of programming/scripting experience.


 


![tog_minus](tog_minus-1.gif)        [Understanding the three interface options](javascript:HMToggle('toggle','UnderstandingTheThreeInterfaceOptions','UnderstandingTheThreeInterfaceOptions_ICON'))




| TradeStation Email Interface  The TradeStation Email Interface allows you to take advantage of TradeStation's email notification capabilities right out of the box. Run your TradeStation strategy in real time, order signals are emailed within your computer (never leaves your PC) to NinjaTrader which processes the order through to your broker.   File Interface The File interface uses standard text files as input. These files are called order instruction files (OIF) and have specific format requirements. NinjaTrader processes the OIF the instant the file is written to the hard drive and subsequently deletes the file once the processing operation is complete.    DLL Interface NinjaTrader provides a DLL named NtDirect.dll that supports various functions for automated trading. |
| --- |



![tog_minus](tog_minus-1.gif)        [Which interface option should I use?](javascript:HMToggle('toggle','WhichInterfaceOptionShouldIUse','WhichInterfaceOptionShouldIUse_ICON'))




| TradeStation Systems  •If you are not running your own strategies or you have limited or no programming experience you should use the TradeStation Email Interface •If you are running your own system and you are comfortable with EasyLanguage and want to have bi\-directional control of your real\-time order processing you should use the DLL interface.  Other Charting Applications  •You should use the DLL if your charting application supports that interface type or use the File Interface  Custom Applications •You should use the DLL interface |
| --- |










