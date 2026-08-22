# ToChartString()

﻿

    NinjaScript > Language Reference > Common > Charts > ChartBars > ToChartString()

ToChartString()

## Definition

Returns a formatted string representing the [ChartBars.Properties.Label](chartbars_properties.md) property, [BarsPeriod](barsperiod.md) Value, and BarsPeriodType name.

 

[](../operations/working_with_price_data.md)[](tochartstring.md)

> **Note:** The property returned is dependent on a user configured Data Series property, and results may return differently than expected.  See also Bars.ToChartString() for a return value which is not subject to user-defined variables.

 

 

## Syntax

ChartBars.ToChartString()

 

## Return Value

A string value that represents the ChartBars label and configured bars period

 

## Parameters

This method does not accept any parameters

##  

## Examples

##

|  |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)<br>{<br>   if (ChartBars != null)<br>      Print(ChartBars.ToChartString()); // My Favorite Instrument (1 Minute)<br>} |