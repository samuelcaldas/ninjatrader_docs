# ClearOutputWindow()

## Definition

Clears all data from the NinjaTrader [Output Window](output.md).

 

> **Note:** The ClearOutputWindow() method only targets the Output tab most recently determined by set [PrintTo](printto.md) property.

## Method Return Value

This method does not return a value.

## Syntax

ClearOutputWindow()

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "Examples Indicator";
        Description = @"An indicator used to demonstrate various NinjaScript methods and properties";
    }
    else if (State == State.Configure)
    {
        AddDataSeries(BarsPeriodType.Minute, 5);
    }
    else if(State == State.DataLoaded)
    {
        //clear the output window as soon as the bars data is loaded
        ClearOutputWindow();
    }
}
```
