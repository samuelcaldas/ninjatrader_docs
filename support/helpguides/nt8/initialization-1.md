
Operations \> Automated Trading \> Automated Trading Interface (ATI) \> Initialization
Initialization
| \<\< [Click to Display Table of Contents](initialization.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Automated Trading Interface (ATI)](automated_trading_interface_at-1.md) \> Initialization | [Previous page](commands_and_valid_parameters-1.md) [Return to chapter overview](automated_trading_interface_at-1.md) [Next page](file_interface-1.md) |
| --- | --- |
If using the DLL based interface, it is important to understand how the ATI is initialized with respect to referencing account names. The ATI is initialized to the first account name used in the first calling function.
 
Some functions accept an account name as a parameter. In most if not all functions, these parameters can be left blank in which case the "Default" account will be used.  You can set the Default account by left mouse clicking on the Tools menu in the NinjaTrader Control Center and selecting the menu item Options, once in the Options window select the Automated trading interface category and select the account you want to use from the Default account menu.  If your default account is set to 'Sim101' and you call functions and leave the account parameter blank, the Sim101 account will be automatically used. 
 
## Example:
 
- Default account \= Sim101

- A function call is made with "" empty string as the account name argument 

- Sim101 account is automatically used 

- Subsequent function calls must use empty string if you want to reference the Sim101 account 

- If you call a function and pass in the argument "Sim101", invalid information will be returned

