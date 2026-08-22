# All

## Definition

A collection of Account objects

 

## Property Value

A [[[Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Account objects

## Syntax

Accounts.All

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.DataLoaded)
    {
        foreach (Account sampleAccount in Account.All)
        Print(String.Format("The account {0} has a {1} unit FX lotsize set", sampleAccount.Name, sampleAccount.ForexLotSize));
    }
}
```
