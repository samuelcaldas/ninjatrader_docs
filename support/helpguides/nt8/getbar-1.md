
NinjaScript > Language Reference > Common > Bars > GetBar()
GetBar()
| << [Click to Display Table of Contents](getbar.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Bars](bars-1.md) > GetBar() | [Previous page](getask-1.md) [Return to chapter overview](bars-1.md) [Next page](getbid-1.md) |
| --- | --- |
## Definition
Returns the first bar that matches the time stamp of the "time" parameter provided.  
 
| Note:  If the time parameter provided is older than the first bar in the series, a bar index of 0 is returned. If the time stamp is newer than the last bar in the series, the last absolute bar index is returned. |
| --- |
## 
## 
## Method Return Value
An int value representing an absolute bar index value.
 
## Syntax
Bars.GetBar(DateTime time)
 
## Parameters
| time | Time stamp to be converted to an absolute bar index |
| --- | --- |

## Examples
| ns |
| --- |
| // Check that its past 9:45 AM if (ToTime(Time[0]) >= ToTime(9, 45, 00)) {    // Calculate the bars ago value for the 9 AM bar for the current day    int barsAgo = CurrentBar - Bars.GetBar(new DateTime(2006, 12, 18, 9, 0, 0));      // Print out the 9 AM bar closing price    Print("The close price on the 9 AM bar was: " + Close[barsAgo].ToString()); } |

