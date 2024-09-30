
NinjaScript \> Language Reference \> Add On \> Connection \> PriceStatus

PriceStatus

| \<\< [Click to Display Table of Contents](connections_pricestatus.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Connection](connection_class-1.md) \> PriceStatus | [Previous page](connections_options-1.md) [Return to chapter overview](connection_class-1.md) [Next page](connections_status-1.md) |
| --- | --- |
## Definition
Indicates the current status of the price feed of the primary data connection
 
## Syntax
\<Connection\>.PriceStatus

## Example

| ns |
| --- |
| private int priceLost; private int mainLost;   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {    // Count the number of times OnAccountItemUpdate() is called with a lost price connection    if (myAccount.Connection.PriceStatus \=\= ConnectionStatus.ConnectionLost)        priceLost \+\= 1;      // Count the number of times OnAccountItemUpdate() is called with a lost primary connection    if (myAccount.Connection.Status \=\= ConnectionStatus.ConnectionLost)        mainLost \+\= 1;      // Print the number of times each connection was lost during OnAccountItemUpdate()    if (mainLost \> 0 \|\| priceLost \> 0)        Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", mainLost, priceLost)); } |
