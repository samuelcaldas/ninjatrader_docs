


NinjaScript \> Language Reference \> Add On \> Connection \> Status






















Status







| \<\< [Click to Display Table of Contents](connections_status.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Connection](connection_class.md) \> Status | [Previous page](connections_pricestatus.md) [Return to chapter overview](connection_class.md) [Next page](reloadallhistoricaldata.md) |
| --- | --- |











## Definition


Indicates the current status of the primary data connection.


 


## Properties


\<Connection\>.Status


 


## Example




| ns |
| --- |
| private int priceLost; private int mainLost;   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {    // Count the number of times OnAccountItemUpdate() is called with a lost price connection    if (myAccount.Connection.PriceStatus \=\= ConnectionStatus.ConnectionLost)        priceLost \+\= 1;      // Count the number of times OnAccountItemUpdate() is called with a lost primary connection    if (myAccount.Connection.Status \=\= ConnectionStatus.ConnectionLost)        mainLost \+\= 1;      // Print the number of times each connection was lost during OnAccountItemUpdate()    if (mainLost \> 0 \|\| priceLost \> 0)        Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", mainLost, priceLost)); } |









