
NinjaScript \> Language Reference \> Add On \> Account \> Get()
Get()
| \<\< [Click to Display Table of Contents](get.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Get() | [Previous page](flatten-1.md) [Return to chapter overview](account_class-1.md) [Next page](name_account-1.md) |
| --- | --- |
## Definition
Returns the value of an AccountItem, such as BuyingPower, CashValue, etc.  

 
## Method Return Value
A double representing the value of the requested AccountItem
 
## Syntax
Get(AccountItem itemType, Cbi.Currency currency)
 
## Parameters
| itemType | The desired AccountItem to return |
| --- | --- |
| Currency | The account currency the value should be denoted (required parameter, but has no effect on returned value) |
 
## 
## Examples
| ns |
| --- |
| // Evaluates to see if the account has more than $25000 if (Account.Get(AccountItem.CashValue, Currency.UsDollar) \> 25000) {    // Do something; } |

