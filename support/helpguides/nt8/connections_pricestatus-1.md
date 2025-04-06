



PriceStatus

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\connections_pricestatus.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Connection](connection_class-1.htm) >  PriceStatus | [Previous page](connections_options-1.htm) [Return to chapter overview](connection_class-1.htm) [Next page](connections_status-1.htm) |

Definition
----------

Indicates the current status of the price feed of the primary data connection

Syntax
------

<Connection>.PriceStatus

Example
-------

| ns |
| --- |
| private int priceLost;  private int mainLost;     private void OnAccountItemUpdate(object sender, AccountItemEventArgs e)  {     // Count the number of times OnAccountItemUpdate() is called with a lost price connection     if (myAccount.Connection.PriceStatus == ConnectionStatus.ConnectionLost)         priceLost += 1;        // Count the number of times OnAccountItemUpdate() is called with a lost primary connection     if (myAccount.Connection.Status == ConnectionStatus.ConnectionLost)         mainLost += 1;        // Print the number of times each connection was lost during OnAccountItemUpdate()     if (mainLost > 0 || priceLost > 0)         Print(String.Format("Main connection lost {0} times. Price feed lost {1} times.", mainLost, priceLost));  } |