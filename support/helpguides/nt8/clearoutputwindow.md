


NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> ClearOutputWindow()






















ClearOutputWindow()







| \<\< [Click to Display Table of Contents](clearoutputwindow.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Alert, Debug, Share](alert__debugging_and_sharing.md) \> ClearOutputWindow() | [Previous page](alert.md) [Return to chapter overview](alert__debugging_and_sharing.md) [Next page](log.md) |
| --- | --- |











## Definition


Clears all data from the NinjaTrader [Output Window](output.md).  


 




| Note:  The ClearOutputWindow() method only targets the Output tab most recently determined by set [PrintTo](printto.md) property. |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax


ClearOutputWindow()


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";         Description \= @"An indicator used to demonstrate various NinjaScript methods and properties";                }    else if (State \=\= State.Configure)    {                  AddDataSeries(BarsPeriodType.Minute, 5);                }           else if(State \=\= State.DataLoaded)    {      //clear the output window as soon as the bars data is loaded      ClearOutputWindow();             } } |









