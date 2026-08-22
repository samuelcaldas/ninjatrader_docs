# Get()

## Definition

Returns the value of an AccountItem, such as BuyingPower, CashValue, etc.

## Method Return Value

A double representing the value of the requested AccountItem

## Syntax

Get(AccountItem itemType, Cbi.Currency currency)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| itemType | The desired AccountItem to return |
| Currency | The account currency the value should be denoted (required parameter, but has no effect on returned value) |

## Examples

```csharp
// Evaluates to see if the account has more than $25000
if (Account.Get(AccountItem.CashValue, Currency.UsDollar) > 25000)
{
    // Do something;
}
```
