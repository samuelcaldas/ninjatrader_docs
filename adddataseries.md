# AddDataSeries()

## Definition

Adds a Bars object for developing a multi-series (multi-time frame or multi-instrument) NinjaScript.

Related Methods and Properties

|  |  |
| --- | --- |
| AddHeikenAshi() | This method adds a Heiken Ashi Bars object for multi-series NinjaScript. |
| AddKagi() | This method adds a Kagi Bars object for multi-series NinjaScript. |
| AddLineBreak() | This method adds a Line Break Bars object for multi-series NinjaScript. |
| AddPointAndFigure() | This method adds a Point-and-Figure Bars object for multi-series NinjaScript. |
| AddRenko() | This method adds a Renko Bars object for multi-series NinjaScript. |
| AddVolumetric() | This method adds a Order Flow Volumetric Bars object for multi-series NinjaScript. |
| BarsArray | AddDataSeries() method. |
| BarsInProgress | OnBarUpdate() method. |
| BarsPeriods | Holds an array of BarsPeriod objects synchronized to the number of unique Bars objects held within the parent NinjaScript object. |
| CurrentBars | Holds an array of int values representing the number of the current bar in a Bars object. |

## Syntax

The following syntax will add another Bars object for the primary instrument of the script.  
AddDataSeries(BarsPeriodbarsPeriod)  
AddDataSeries(BarsPeriodTypeperiod)

The following syntax allows you to add another Bars object for a different instrument to the script:

AddDataSeries(period)  
AddDataSeries(marketDataType)  
AddDataSeries(barsPeriod)  
AddDataSeries(tradingHoursName)  
AddDataSeries(isResetOnNewTradingDay)  
AddDataSeries(isResetOnNewTradingDay)

AddDataSeries(//only for R15 and higher

> **Warning:** OnStateChange, the input any hosted indicator is running on should be explicitly stated

## Parameters

|  |  |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| barsPeriod | BarsPeriod object (period type and interval) |
| periodType | The BarsType used for the bars period   Possible values are:
- BarsPeriodType.Year |
| period | int determining the period interval such as "3" for 3 minute bars |
| marketDataType | The MarketDataType used for the bars object (last, bid, ask)   Possible values are:      here on using Bid/Ask series. |
| tradingHoursName | string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | Break at EOD   \*Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |
| barsToLoad | int determining the number of historical bars to load |

> **Tips:** 1. You can optionally add the exchange name as a suffix to the symbol name. This is only advised if the instrument has multiple possible exchanges that it can trade on and it is configured within the Instruments window. For example: AddDataSeries();  2. You can add a custom [BarsType](bars_type.md) which is installed on your system by casting the registered enum value for that BarsPeriodType.  For example: AddDataSeries((BarsPeriodType)  3. You can specify optional [BarsPeriod](barsperiod.md) values (such as [Value2](optimization_fitness_value.md)) of a custom BarsType in the BarsPeriod object initializer.  For example: AddDataSeries(});  4. For the instrument name parameter null could be passed in, resulting in the primary data series instrument being used.

## Examples

```csharp
OnStateChange()
{
    State.Configure)
    {
        // Add a 5 minute Bars object - BarsInProgress index = 1
        );
        // Add a 100 tick Bars object for the ES 09-16 contract - BarsInProgress index = 2
    }
}
{
    // Ignore bar update events for the supplementary - Bars object added above
    )
    // Go long if we have three up bars on all bars objects
    EnterLong();
}
csharp
OnStateChange()
{
    State.Configure)
    {
        // Our hosting script needs to have the AddDataSeries call included as well, which the Pivots indicator we call in the 2nd statement below
        // also has per default in it's own State.Configure method. This is required since our Pivots indicator below is created in State.DataLoaded
        // (which is happening after State.Configure and it depends on the AddDataSeries call to have the bars available to properly calculate in
        // daily bars mode.
        );
    }
    State.DataLoaded)
    {
        //In this state, we pass the 1 day series to the Pivots indicator (as BarsArray[1]) and create its instance
        );
    }
}
```
