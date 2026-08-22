# OnAccountItemUpdate()

## Definition

An event driven method used for strategies which is called for each AccountItem update for the account on which the strategy is running.

> **Note:** OnAccountItemUpdate() will be called continually in real-time if a position exists on the account on which the strategy is running. This is to provide updates on the current Unrealized Profit and Loss and associated risk values.

## Method Return Value

This method does not return a value.

## Syntax

`You must override the method in your strategy with the following syntax:`

protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value) 
{  
  
## }

## Method Parameters

| Name / Option | Description |
| --- | --- |
| account | The [Account](../addons/account_class.md) updated |
| accountItem | The [AccountItem](../addons/accountitem.md) updated |
| value | The value of the AccountItem updated |

## Examples

```csharp
protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value)
{
    Print(string.Format("{0} {1} {2}", account.Name, accountItem, value));
    // output:
    // Sim101 BuyingPower 103962.5
    // Sim101 CashValue 103962.5
    // Sim101 GrossRealizedProfitLoss 3962.5
    // Sim101 RealizedProfitLoss 3962.5
}
```