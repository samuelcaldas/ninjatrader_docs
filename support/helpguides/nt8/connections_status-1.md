
NinjaScript > Language Reference > Add On > Connection > Status

Status

| << [Click to Display Table of Contents](connections_status.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Connection](connection_class-1.md) > Status | [Previous page](connections_pricestatus-1.md) [Return to chapter overview](connection_class-1.md) [Next page](reloadallhistoricaldata-1.md) |
| --- | --- |
## Definition
Indicates the current status of the primary data connection.
 
## Properties
<Connection>.Status
 
## Example

| ns |
| --- |
| private int priceLost; private int mainLost;   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {    // Count the number of times OnAccountItemUpdate() is called with a lost price connection    if (myAccount.Connection.PriceStatus == ConnectionStatus.ConnectionLost)        priceLost += 1;      // Count the number of times OnAccountItemUpdate() is called with a lost primary connection    if (myAccount.Connection.Status == ConnectionStatus.ConnectionLost)        mainLost += 1;      // Print the number of times each connection was lost during OnAccountItemUpdate()    if (mainLost > 0 || priceLost > 0)        Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", mainLost, priceLost)); } |
