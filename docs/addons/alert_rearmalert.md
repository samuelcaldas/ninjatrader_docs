# RearmAlert()

## Definition

Rearms an existing alert event by the string "id" parameter created via the [[[AlertCallback()](alertcallback.md) method.  A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert()'s rearmSeconds parameter.

> **Note:** The NinjaScriptBase has a non-static method implemented with the same name.  Please see the [[[RearmAlert()](../language_reference/rearmalert.md) method for Indicator or Strategies.

## Method Return Value

This method does not return a value.

## Syntax

NinjaTrader.NinjaScript.Alert.RearmAlert(string id)

 

## Parameters

|  |  |
| --- | --- |
| id | A unique string id representing an alert id to reset |

## Examples

```csharp
if (resetCondition)
{
    NinjaTrader.NinjaScript.Alert.ResetAlertRearmById("someId");
    resetCondition = false;
}
```
