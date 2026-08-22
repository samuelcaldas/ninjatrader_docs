# AddRenko()

## Definition

Similar to the [AddDataSeries()](adddataseries.md) method for adding Bars objects, this method adds a Renko Bars object for multi-series NinjaScript.

> **Notes:** Developing for Tick Replay for more information.

## Syntax

AddRenko(marketDataType)  
AddRenko(tradingHoursName)  
AddRenko(?isResetOnNewTradingDay)

> **Warnings:** Unable to load bars series. Your NinjaScript may be trying to use an additional data series dynamically in an unsupported manner.

## Parameters

|  |  |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| brickSize | int determining the size (in ticks) of each bar |
| marketDataType | The MarketDataType used for the bars object (last, bid, ask)   Possible values are:      here on using Bid/Ask series. |
| tradingHoursName | string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | Break at EOD   \*Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |

> MarketDataType.Last)

## Examples

```csharp
OnStateChange()
{
    State.Configure)
    {
        // Add a 1 minute Renko Bars object for the ES 03-18 contract - BarsInProgress index = 1
    }
}
{
    // Ignore the primary Bars object and only process the Renko Bars object
    )
    {
        // Do something;
    }
}
```
