# RearmAlert()

﻿

    NinjaScript > Language Reference > Add On > Alert and Debug Concepts > RearmAlert()

RearmAlert()

## Definition

Rearms an existing alert event by the string "id" parameter created via the [AlertCallback()](../addons/alertcallback.md) method.  A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert()'s rearmSeconds parameter.

 

[](rearmalert.md)

> **Note:** The NinjaScriptBase has a non-static method implemented with the same name.  Please see the RearmAlert() method for Indicator or Strategies.

 

 

## Method Return Value

This method does not return a value.

 

## Syntax

NinjaTrader.NinjaScript.Alert.RearmAlert(string id)

 

##  

Parameters

| id | A unique string id representing an alert id to reset |
| --- | --- |

##  

 

## Examples

##

|  |
| --- |
| if (resetCondition) <br>{<br>    NinjaTrader.NinjaScript.Alert.ResetAlertRearmById("someId");<br>    resetCondition = false;<br>} |