
NinjaScript \> Language Reference \> Common \> Analytical \> CountIf()
CountIf()
| \<\< [Click to Display Table of Contents](countif.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Analytical](market_data-1.md) \> CountIf() | [Previous page](approxcompare-1.md) [Return to chapter overview](market_data-1.md) [Next page](crossabove-1.md) |
| --- | --- |
## Definition
Counts the number of instances the test condition occurs over the look\-back period expressed in bars.
 
| Note: This method does NOT work on [multi\-series](multi-time_frame__instruments-1.md) strategies and indicators. |
| --- |

## Method Return Value
An int value representing the number of occurrences found
 
## Syntax
CountIf(Func\<bool\> condition, int period)  

 
## Parameters
| condition | A true/false expression |
| --- | --- |
| period | Number of bars to check for the test condition |

| Tip:  The syntax for the "condition" parameter uses [lambda expression](http://msdn.microsoft.com/en-us/library/bb397687.aspx) syntax |
| --- |

## Examples
| ns |
| --- |
| // If in the last 10 bars we have had 8 up bars then go long if (CountIf(() \=\> Close\[0] \> Open\[0], 10) \> 8)      EnterLong(); |

