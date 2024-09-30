
Operations \> Automated Trading \> Automated Trading Interface (ATI) \> File Interface \> Order Instruction Files (OIF)

Order Instruction Files (OIF)

| \<\< [Click to Display Table of Contents](order_instruction_files_oif.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Automated Trading Interface (ATI)](automated_trading_interface_at-1.md) \> [File Interface](file_interface-1.md) \> Order Instruction Files (OIF) | [Previous page](file_interface-1.md) [Return to chapter overview](file_interface-1.md) [Next page](information_update_files-1.md) |
| --- | --- |
OIFs must be written to the folder "My Documents\\\<NinjaTrader Folder\>\\incoming" and be named oif\*.txt. You can simply send an oif.txt file however, it is suggested that you increment each OIF so that you end up with unique file names such as oif1\.txt, oif2\.txt, oif3\.txt. The reason is that if you send a lot of OIFs in rapid succession, you do run the risk of file locking problems if you always use the same file name. This will result in a situation where your file is not processed.
 
Each file must also contain correctly formatted line(s) of parameters. You may stack the instruction lines so that each file contains as many instruction lines as you desire. The delimiter required is the semicolon and this section is a good reference for generating correctly formatted OIF.  Files are processed the instant they are written to the hard disk without delay.
 
Please reference the [Commands and Valid Parameters](commands_and_valid_parameters-1.md) section for detailed information on available commands and parameters.
 
The following are examples of the required format for each of the available commands. Required fields are embraced by \<\> where optional fields are embraced by \[].
 
CANCEL COMMAND
CANCEL;;;;;;;;;;\<ORDER ID\>;;\[STRATEGY ID]
 
CANCELALLORDERS COMMAND
CANCELALLORDERS;;;;;;;;;;;;
 
CHANGE COMMAND
CHANGE;;;;\<QUANTITY\>;;\<LIMIT PRICE\>;\<STOP PRICE\>;;;\<ORDER ID\>;;\[STRATEGY ID]
 
CLOSEPOSITION COMMAND
CLOSEPOSITION;\<ACCOUNT\>;\<INSTRUMENT\>;;;;;;;;;;
 
CLOSESTRATEGY COMMAND
CLOSESTRATEGY;;;;;;;;;;;;\<STRATEGY ID\>
 
FLATTENEVERYTHING COMMAND
FLATTENEVERYTHING;;;;;;;;;;;;
 
PLACE COMMAND
PLACE;\<ACCOUNT\>;\<INSTRUMENT\>;\<ACTION\>;\<QTY\>;\<ORDER TYPE\>;\[LIMIT PRICE];\[STOP PRICE];\<TIF\>;\[OCO ID];\[ORDER ID];\[STRATEGY];\[STRATEGY ID]
## 
REVERSEPOSITION COMMAND
REVERSEPOSITION;\<ACCOUNT\>;\<INSTRUMENT\>;\<ACTION\>;\<QTY\>;\<ORDER TYPE\>;\[LIMIT PRICE];\[STOP PRICE];\<TIF\>;\[OCO ID];\[ORDER ID];\[STRATEGY];\[STRATEGY ID]
