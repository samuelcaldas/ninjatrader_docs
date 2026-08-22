# DaysToLoad

## Definition

Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid.

> **Notes:** 1.This property does NOT affect a strategy configured of a Chart or the Strategy Analyzer.  2.A trading day is defined by a [[[Trading Hour](../operations/using_the_trading_hours_window.md) template

## Property Value

An int value determining the number of trading days to load for historical data processing.  Default value is 5, but can be configured and overridden  from the UI.

## Syntax

DaysToLoad

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DaysToLoad = 15;
    }
}
```
