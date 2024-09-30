
NinjaScript \> Language Reference \> Common \> Analytical \> CountIf()
CountIf()
| \<\< [Click to Display Table of Contents](countif.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> CountIf() | [Previous page](approxcompare.md) [Return to chapter overview](market_data.md) [Next page](crossabove.md) |
| --- | --- |
## Definition
Counts the number of instances the test condition occurs over the look\-back period expressed in bars.
 
| Note: This method does NOT work on [multi\-series](multi-time_frame__instruments.md) strategies and indicators. |
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

