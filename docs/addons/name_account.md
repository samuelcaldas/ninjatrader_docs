# Name

## Definition

Indicates the name of the specified account

## Property Value

An string representing the name of the account

## Syntax

<Account>.Name

## Example

```csharp
private Account myAccount;
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}
private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)
{
    // Print the name of each account updated
    Print(String.Format("{0} account updated", myAccount.Name));
}
```