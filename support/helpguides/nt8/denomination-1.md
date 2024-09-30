
NinjaScript \> Language Reference \> Add On \> Account \> Denomination
Denomination
| \<\< [Click to Display Table of Contents](denomination.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Denomination | [Previous page](createorder-1.md) [Return to chapter overview](account_class-1.md) [Next page](executions-1.md) |
| --- | --- |
## Definition
Indicates the currency set on an account
 
## Property Value
A Currency object containing information about the currency denomination specified in the referenced account
 
## Syntax
\<Account\>.Connection
## 
## Examples
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      // Initialize myAccount here        // Print myAccount's currency denomination      NinjaTrader.Code.Output.Process("myAccount currency is set to " \+ myAccount.Denomination, PrintTo.OutputTab1\);    } } |

