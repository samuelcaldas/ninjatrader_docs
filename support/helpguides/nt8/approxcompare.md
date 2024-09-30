
NinjaScript \> Language Reference \> Common \> Analytical \> ApproxCompare()
ApproxCompare()
| \<\< [Click to Display Table of Contents](approxcompare.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> ApproxCompare() | [Previous page](market_data.md) [Return to chapter overview](market_data.md) [Next page](countif.md) |
| --- | --- |
## Definition
Compares two double or float values for equality or being greater than / less than the compared to value.
 
| Note: Comparing for being greater than / less is done using an epsilon value of 1E19 |
| --- |
 
## Method Return Value
An int value representing the outcome of the comparison. Returns 0 if values are equal, 1 if value1 is greater than value2\. \-1 if value1 is less than value2\.
 
## Syntax
this.ApproxCompare(this double double1, double double2\)  

this.ApproxCompare(this float float1, double float2\)  

 
## Parameters
| double1 / float1 | First value to compare against (not actually passed in) |
| --- | --- |
| double2 / float2 | Second passed in value to compare against |
 
| Tip:  Main use would be using it for equality comparisons to circumvent running into floating point considerations, value compares for \< or \> could be usually done more straightforward directly. |
| --- |

## Examples
| ns | |
| --- | --- |
|  | // Build the High / Low difference and if 0 sets the indicator main Value series to 0 if ((High\[0] \- Low\[0]).ApproxCompare(0) \=\= 0)    Value\[0] \= 0; |
 

