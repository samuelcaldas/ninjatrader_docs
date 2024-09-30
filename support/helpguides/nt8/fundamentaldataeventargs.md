
NinjaScript \> Language Reference \> Common \> OnFundamentalData() \> FundamentalDataEventArgs

FundamentalDataEventArgs

| \<\< [Click to Display Table of Contents](fundamentaldataeventargs.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [OnFundamentalData()](onfundamentaldata.md) \> FundamentalDataEventArgs | [Previous page](onfundamentaldata.md) [Return to chapter overview](onfundamentaldata.md) [Next page](onmarketdata.md) |
| --- | --- |
## Definition
Represents a change in fundamental data and is passed as a parameter in the [OnFundamentalData()](onfundamentaldata.md) method.   

 
## Methods and Parameters

| DateTimeValue | A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) value representing the time |
| --- | --- |
| DoubleValue | A double value representing fundamental data |
| FundamentalDataType | Possible values:   AverageDailyVolume Beta CalendarYearHigh CalendarYearHighDate CalendarYearLow CalendarYearLowDate CurrentRatio DividendAmount DividendPayDate DividendYield EarningsPerShare FiveYearsGrowthPercentage High52Weeks High52WeeksDate HistoricalVolatility Low52Weeks Low52WeeksDate MarketCap NextYearsEarningsPerShare PercentHeldByInstitutions PriceEarningsRatio RevenuePerShare SharesOutstanding ShortInterest ShortInterestRatio VWAP |
| IsReset | A bool value representing if an UI reset is needed after a manual disconnect. Note: This is only relevant for columns. Whenever this property is true, the UI needs to be reset. |
| LongValue | A long value representing fundamental data |
| ToString() | A string representation of the FundamentalDataEventArgs object |
 
## Examples

| ns |
| --- |
| protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate) {      // Print some data to the Output window      if (fundamentalDataUpdate.FundamentalDataType \=\= FundamentalDataType.AverageDailyVolume)          Print("Average Daily Volume \= " \+ fundamentalDataUpdate.LongValue);      else if (fundamentalDataUpdate.FundamentalDataType \=\= FundamentalDataType.PriceEarningsRatio)          Print("P/E Ratio \= " \+ fundamentalDataUpdate.DoubleValue); } |
   

Tips
1\.Not all connectivity providers support all FundamentalDataTypes.

2\.EarningsPerShare on eSignal is a trailing twelve months value. On IQFeed it is the last quarter's value.

3\.RevenuePerShare is a trailing twelve months value.
