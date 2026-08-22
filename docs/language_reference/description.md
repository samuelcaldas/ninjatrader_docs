# Description

## Definition

Text which is used on the UI's information box to be displayed to a user when configuration a NinjaScript object.

## Method Return Value

A string value representing text used to describe the object.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

Description

 

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "Examples Indicator";
        Description = @"An indicator used to demonstrate various NinjaScript methods and properties";
    }
}
```
