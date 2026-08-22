# AddVolumetric()

## Definition

Similar to the [AddDataSeries()](adddataseries.md) method for adding Bars objects, this method adds a [Order Flow](../strategies/order_flow_volumetric_bars.md) Volumetric Bars object for multi-series NinjaScript.

> **Notes:** here.

## Syntax

AddVolumetric(tickPerLevel)  
AddVolumetric(isResetOnNewTradingDay)  
AddVolumetric(isResetOnNewTradingDay)

AddVolumetric(isResetOnNewTradingDay) (R17 and higher only)

 

> **Warnings:** may be trying to use an additional data series dynamically in an unsupported manner.

## Parameters

| Name / Option | Description |
| --- | --- |
| instrumentName | string determining instrument name such as "MSFT" |
| baseBarsPeriodType | The underlying BarsType used for the Volumetric bars period.   Possible values are:
- BarsPeriodType.Year |
| baseBarsPeriodTypeValue | int determining the underlying period interval such as "3" for 3 minute bars |
| deltaType | The DeltaType used for the Volumetric bars object delta calculations   Possible values are:
- VolumetricDetlaType.UpDownTick |
| ticksPerLevel | int setting the aggregation of price levels for the Volumetric bar, pass in a 1 to analyze each price level individually |
| sizeFilter | int setting the trade size allowed to count in the delta calculations |
| tradingHoursName | string determining the trading hours template for the instrument |
| isResetOnNewTradingDay | Break at EOD   \*Will accept true, false or null as the input.  If null is used, the data series will use the settings of the primary data series. |

> );

## Examples

![Ns](../images/ns.png)

```csharp
OnStateChange()
{
    State.SetDefaults)
    {
    }
    State.Configure)
    {
        // Add a 1 minute Order Flow Volumetric Bars object for the ES 03-18 contract - BarsInProgress index = 1
        );
    }
}
{
    // Ignore the primary Bars object and only process the Order Flow Volumetric object
    )
    {
        // Do something;
    }
}
```