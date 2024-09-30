
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> FormatPrice()

FormatPrice()

| \<\< [Click to Display Table of Contents](formatprice.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> FormatPrice() | [Previous page](exchanges-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](instrumenttype-1.md) |
| --- | --- |
## Definition
Returns a price value as a string which will be formatted to the nearest tick size.  
 

| Note:  This is useful as the standard format specifier will only use the minimum number of digits for a decimal by default; however you can use this method to ensure that your data is always formatted per the instrument tick size for easier readability.  For example, a value of 1985\.50 would Print() as 1985\.5, while using FormatPrice(), we can expect the value to be formatted as 1985\.50\. |
| --- |
## 
## 
## Property Value
A string value which will ensure the price data is always formatted to the nearest tick size.

## Syntax
Bars.Instrument.MasterInstrument.FormatPrice(double price, \[bool round])
 
## Parameters

| price | A double value representing a price |
| --- | --- |
| round | An optional bool when true (default) will round the price value to the nearest tick size |
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    // called without setting the optional bool parameter, which is defaulted to true then    Print(Bars.Instrument.MasterInstrument.FormatPrice(Close\[0]));      } |

| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    Print(marketDataUpdate.Instrument.MasterInstrument.FormatPrice(marketDataUpdate.Price)); } |
