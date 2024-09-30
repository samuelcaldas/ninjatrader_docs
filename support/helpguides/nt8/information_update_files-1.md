
Operations \> Automated Trading \> Automated Trading Interface (ATI) \> File Interface \> Information Update Files
Information Update Files
| \<\< [Click to Display Table of Contents](information_update_files.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Automated Trading Interface (ATI)](automated_trading_interface_at-1.md) \> [File Interface](file_interface-1.md) \> Information Update Files | [Previous page](order_instruction_files_oif-1.md) [Return to chapter overview](file_interface-1.md) [Next page](dll_interface-1.md) |
| --- | --- |
NinjaTrader provides update information files that are written to the folder "My Documents\\\<NinjaTrader Folder\>\\outgoing". The contents of this folder will be deleted when the NinjaTrader application is restarted.
 
![tog_minus](tog_minus-1.gif)        [Understanding order state files](javascript:HMToggle('toggle','UnderstandingOrderStateFiles','UnderstandingOrderStateFiles_ICON'))
| Order State Files Orders that are assigned an order ID value in the "PLACE" command will generate an order state update file with each change in order state. The file name is 'orderId.txt' where orderId is the order ID value passed in from the "PLACE" command. Possible order state values can be found [here](order_state_definitions-1.md). The format of this file is:   Order State;Filled Amount;Average FillPrice |
| --- |
![tog_minus](tog_minus-1.gif)        [Understanding position update files](javascript:HMToggle('toggle','UnderstandingPositionUpdateFiles','UnderstandingPositionUpdateFiles_ICON'))
| Position Update Files Position update files are generated on every update of a position. The name of the file is Instrument Name \+ Instrument Exchange\_AccountName\_Position.txt. An example would be ES 0914 Globex\_Sim101\_Position.txt. The format of the file is:   Market Position; Quantity; Average Entry Price   Valid Market Position values are either LONG, SHORT or FLAT. |
| --- |
![tog_minus](tog_minus-1.gif)        [Understanding connection state files](javascript:HMToggle('toggle','UnderstandingConnectionStateFiles','UnderstandingConnectionStateFiles_ICON'))
| Connection State Files Connection state files are written with each change of connection state. The name of the file is ConnectionName.txt where connectionName is the name of the connection given in the [Connection Manager](connecting-to-multi-provider-c-1.md). The format of the file is:   Connection State   Valid connection state values are CONNECTED or DISCONNECTED. |
| --- |
