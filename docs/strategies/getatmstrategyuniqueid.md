# GetAtmStrategyUniqueId()

## Definition

Generates a unique ATM Strategy ID value.

## Method Return Value

A string value representing a unique id value.

## Syntax

GetAtmStrategyUniqueId()

 

## Parameters

This method does use take any parameters.

 

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    string orderId = GetAtmStrategyUniqueId();
}
```