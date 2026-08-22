# GetCurrentBidVolume()

## Definition

Returns the current real-time bid volume.

> **Notes:** 1. When accessed during State.Historical, the [Volume](../indicators/volume.md) of the evaluated bar series is substituted.  To access historical Bid Volumes, please see [Developing for Tick Replay](../ninjascript/developing_for__tick_replay.md).  2. The GetCurrentBidVolume() method runs on the bar series currently updating determined by the [BarsInProgress](barsinprogress.md) property.  For [multi-instrument](multi-time_frame__instruments.md) scripts, an additional int "barsSeriesIndex" parameter can be supplied which forces the method to run on an supplementary bar series.

## Method Return Value

A long value representing the current bid volume.

Syntax  
GetCurrentBidVolume()  
GetCurrentBidVolume(int barsSeriesIndex)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| barsSeriesIndex | An int value determining the bar series the method runs. Note:  This optional parameter is reserved for multi-instrument scripts |

## Examples

```csharp
protected override void OnBarUpdate()
{
    long currentBidVolume = GetCurrentBidVolume();
    Print("The Current Bid volume is: " + currentBidVolume);
    //The Current Bid volume is: 158
}
```

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "Examples Indicator";

![Ns](../images/ns.png)

![Ns](../images/ns.png)

    }
    if (State == State.Configure)
    {
        //Add MSFT as our additional data series
        AddDataSeries("MSFT", BarsPeriodType.Minute, 1);
    }
}
protected override void OnBarUpdate()
{
    if(BarsInProgress == 0)
    {
        long currentBidVolume = GetCurrentBidVolume(0);
        Print("The Current Bid volume is: " + currentBidVolume);
        //The Current Bid volume is: 346
    }
    if(BarsInProgress == 1)
    {
        long msftBidVolume = GetCurrentBidVolume(1);
        Print("MSFT's Current Bid volume is: " + msftBidVolume);
        //MSFT's Current Bid volume is: 1548
    }
}
```