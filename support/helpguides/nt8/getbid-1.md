


NinjaScript \> Language Reference \> Common \> Bars \> GetBid()






















GetBid()







| \<\< [Click to Display Table of Contents](getbid.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> GetBid() | [Previous page](getbar-1.md) [Return to chapter overview](bars-1.md) [Next page](getclose-1.md) |
| --- | --- |











## Definition


Returns the bid price value at a selected absolute bar index value.


 




| Notes:    •This method does NOT return the current real\-time bid price, but rather the historical / real\-time bid price at the desired index.  For obtaining the current real\-time bid price, please use [GetCurrentBid()](getcurrentbid-1.md).•This method returns expected values when 1 tick bid / ask stamped data is used and available from [your provider](data_by_provider-1.md). |
| --- |



 


 


## Method Return Value


A double value that represents the biding price at the desired bar index.


## 


## Syntax


Bars.GetBid(int index)


 


## Parameters




| index | The absolute bar index value used |
| --- | --- |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // If the Highs of the two most recent bars are falling, place a long stop market order    // at the Ask price    if (Low\[0] \> Low\[1] \&\& Low\[1] \< Low\[2])    {      EnterShortStopMarket(Bars.GetBid(CurrentBar));    } } |









