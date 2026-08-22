# AddPointAndFigure()

## Definition

Similar to the [AddDataSeries()](adddataseries.md) method for adding Bars objects, this method adds a Point-and-Figure Bars object for multi-series NinjaScript.

> **Notes:** Developing for Tick Replay for more information.

## Syntax

AddPointAndFigure(marketDataType)  
AddPointAndFigure(tradingHoursName)  
AddPointAndFigure(isResetOnNewTradingDay)

 

> **Warnings:** Unable to load bars series. Your NinjaScript may be trying to use an additional data series dynamically in an unsupported manner.

 

## Parameters

| Name / Option | Description |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| baseBarsPeriodType | The underlying BarsType used for the Point-and-Figure bars period   Possible values are:    BarsPeriodType.Volume |
| baseBarsPeriodTypeValue | int determining the underlying period interval such as "3" for 3 minute bars |
| boxSize | int determining the price movement signified by the X's and O's of a Point-and-Figure chart |
| reversal | int determining the number of boxes the price needs to move in the reversal direction before a new column will be built |
| pointAndFigurePriceType | Determines where to base reversal calculations   Possible values are:    PointAndFigurePriceType.HighsAndLows |
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
        // Add a 1 minute Point-and-Figure Bars object for the ES 03-18 contract - BarsInProgress index = 1
        MarketDataType.Last);
    }
}
{
    // Ignore the primary Bars object and only process the Point-and-Figure Bars object
    )
    {
        // Do something;
    }
}
```