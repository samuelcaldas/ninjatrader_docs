
NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> PrintTo

PrintTo

| \<\< [Click to Display Table of Contents](printto.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Alert, Debug, Share](alert__debugging_and_sharing.md) \> PrintTo | [Previous page](print.md) [Return to chapter overview](alert__debugging_and_sharing.md) [Next page](rearmalert.md) |
| --- | --- |
## Definition
Determines either tab of the NinjaScript [Output window](output.md) the [Print()](print.md) and [ClearOutputWindow()](clearoutputwindow.md) method targets
## 
## Property Value
An enum value representing the target Output Tab.  The default value is PrintTo.OutputTab1. 
 
Possible values are:

| PrintTo.OutputTab1 | Output Windows tab named "Output 1" |
| --- | --- |
| PrintTo.OutputTab2 | Output Windows tab named "Output 2" |
 
## Syntax
PrintTo
 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Sample PrintTo Indicator \#1";      Description \= @"Used to Print updates to Output 1";        //Set this scripts Print() calls to the first output tab      PrintTo \= PrintTo.OutputTab1;    }       }   protected override void OnBarUpdate()  {                      Print("This script will print messages to Output Tab 1");       } |

| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Sample PrintTo Indicator \#2";      Description \= "@Used to Print updates to Output 2";        //Set this scripts Print() calls to the second output tab      PrintTo \= PrintTo.OutputTab2;    }       }   protected override void OnBarUpdate()  {                      Print("This script will print messages to Output Tab 2");       } |

| ns |
| --- |
| protected override void OnMarketData(MarketDataEventArgs marketDataUpdate) {    if(marketDataUpdate.MarketDataType \=\= MarketDataType.Ask)    {      //Print Ask updates to Output 1      PrintTo \= PrintTo.OutputTab1;      Print("Ask: " \+ marketDataUpdate.Price);    }        else if (marketDataUpdate.MarketDataType \=\= MarketDataType.Bid)    {      //Print Bid updates to Output 2      PrintTo \= PrintTo.OutputTab2;      Print("Bid: " \+ marketDataUpdate.Price);    } } |
