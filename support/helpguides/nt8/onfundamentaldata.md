﻿
NinjaScript > Language Reference > Common > OnFundamentalData()

OnFundamentalData()

| << [Click to Display Table of Contents](onfundamentaldata.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > OnFundamentalData() | [Previous page](connectionstatuseventargs.md) [Return to chapter overview](common.md) [Next page](fundamentaldataeventargs.md) |
| --- | --- |
## Definition
An event driven method which is called for every change in fundamental data for the underlying instrument.
 

| Note:  This method is NOT called on historical data (backtest) |
| --- |
 
## 
## Method Return Value
This method does not return a value.
 
## Syntax
You must override the method in your strategy or indicator with the following syntax.
 
protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate)   

{  

   

}
 

| Tip:  The NinjaScript code wizards can automatically generate the method syntax for you when creating a new script. |
| --- |
## 

## Parameters

| fundamentalDataUpdate | [FundamentalDataEventArgs](fundamentaldataeventargs.md) representing the recent change in fundamental data |
| --- | --- |
 
## 
## Examples

| ns | Code: |
| --- | --- |
|  | protected override void OnFundamentalData(FundamentalDataEventArgs fundamentalDataUpdate) {      // Print some data to the Output window      if (fundamentalDataUpdate.FundamentalDataType == FundamentalDataType.AverageDailyVolume)          Print("The current ADV is " + fundamentalDataUpdate.LongValue); } |

| Tips 1.With [multi-time frame and instrument strategies](multi-time_frame__instruments.md), OnFundamentalData() will be called for all unique instruments in your strategy. Use the [BarsInProgress](barsinprogress.md) to filter the OnFundamentalData() method for a specific instrument. 2.Do not leave an unused OnFundamentalData() method declared in your NinjaScript object. This will unnecessarily attach a data stream to your script which uses unnecessary CPU cycles. |
| --- |
