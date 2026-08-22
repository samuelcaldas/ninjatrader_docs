# Orders

## Definition

A collection of Order objects generated for the specified account

## Property Value

An [[[Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Order objects

> **Note:** Please keep in mind that orders placed when in State.Historical are not submitted live to an account.

## Syntax

<Account>.Orders

## Examples

```csharp
private Account myAccount;
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}
private void OnAccountItemUpdate(object sender, AccountItemEventArgs e)
{
    // Print the name and order action of each order processed on the account
    foreach (Order order in myAccount.Orders)
    {
        Print(String.Format("Order placed: {0} - {1}", order.Name, order.OrderAction));
    }
}
```
