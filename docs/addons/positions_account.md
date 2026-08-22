# Positions

## Definition

A collection of Position objects generated for the specified account

## Property Value

An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Position objects

## Syntax

Account.Positions

<Account>.Positions

## Examples

```csharp
private Account myAccount; protected override void OnStateChange(){
    if (State == State.SetDefaults)
    {
        // Find our Sim101 account
        lock (Account.All)
        myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");
    }
    if (State == State.DataLoaded)
    {
        lock (myAccount.Positions)
        {
            Print("Positions in State.DataLoaded:");
            foreach (Position position in myAccount.Positions)
            {
                Print(String.Format("Position: {0} at {1}", position.MarketPosition, position.AveragePrice));
            }
        }
}}
```
