# RearmAlert()

## Definition

Rearms an alert created via the [Alert()](alert.md) method.

 

> **Note:** A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert() methods rearmSeconds parameter.

## Method Return Value

This method does not return a value.

## Syntax

RearmAlert(string id)

## Parameters

| Name / Option | Description |
| --- | --- |
| id | A unique string id representing an alert id to rearm |

## Examples

```csharp
protected override void OnBarUpdate()
{
    //rearms "myAlert" on each new trading session
    if(Bars.IsFirstBarOfSession)
    RearmAlert("myAlert");
}
```