
Operations > Automated Trading > Automated Trading Interface (ATI) > File Interface > Information Update Files
Information Update Files
| << [Click to Display Table of Contents](information_update_files.md) >> **Navigation:**     [Operations](operations.md) > [Automated Trading](automated_trading.md) > [Automated Trading Interface (ATI)](automated_trading_interface_at.md) > [File Interface](file_interface.md) > Information Update Files | [Previous page](order_instruction_files_oif.md) [Return to chapter overview](file_interface.md) [Next page](dll_interface.md) |
| --- | --- |
NinjaTrader provides update information files that are written to the folder "My Documents\\<NinjaTrader Folder>\\outgoing". The contents of this folder will be deleted when the NinjaTrader application is restarted.
 
![tog_minus](tog_minus.gif)
| Order State Files Orders that are assigned an order ID value in the "PLACE" command will generate an order state update file with each change in order state. The file name is 'orderId.txt' where orderId is the order ID value passed in from the "PLACE" command. Possible order state values can be found [here](order_state_definitions.md). The format of this file is:   Order State;Filled Amount;Average FillPrice |
| --- |
![tog_minus](tog_minus.gif)
| Position Update Files Position update files are generated on every update of a position. The name of the file is Instrument Name + Instrument Exchange_AccountName_Position.txt. An example would be ES 0914 Globex_Sim101_Position.txt. The format of the file is:   Market Position; Quantity; Average Entry Price   Valid Market Position values are either LONG, SHORT or FLAT. |
| --- |
![tog_minus](tog_minus.gif)
| Connection State Files Connection state files are written with each change of connection state. The name of the file is ConnectionName.txt where connectionName is the name of the connection given in the [Connection Manager](connecting-to-multi-provider-c.md). The format of the file is:   Connection State   Valid connection state values are CONNECTED or DISCONNECTED. |
| --- |
