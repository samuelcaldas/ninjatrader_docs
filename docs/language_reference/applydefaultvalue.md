# ApplyDefaultValue

## Definition

Sets the default [BarsPeriod](barsperiod.md) values used for a custom Bar Type.

## Method Return Value

This method does not return a value.

## Parameters

| Name / Option | Description |
| --- | --- |
| period | The [BarsPeriod](barsperiod.md) chosen by the user when utilizing this Bars type |

## Syntax

You must override the method in your Bars Type with the following syntax:

 

public override void ApplyDefaultValue(BarsPeriod period)  
{  
   
}

 

## Examples

```csharp
public override void ApplyDefaultValue(BarsPeriod period)
{
    period.BarsPeriodTypeName = "MyBarType";
    period.Value = 1;
}
```
