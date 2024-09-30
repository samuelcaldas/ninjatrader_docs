
NinjaScript \> Language Reference \> Bars Type \> GetPercentComplete()
GetPercentComplete()
| \<\< [Click to Display Table of Contents](getpercentcomplete.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Bars Type](bars_type-1.md) \> GetPercentComplete() | [Previous page](getinitiallookbackdays-1.md) [Return to chapter overview](bars_type-1.md) [Next page](icon_barstype-1.md) |
| --- | --- |
## Definition
Determines the value your BarsType would return for [Bars.PercentComplete](percentcomplete-1.md)
 
## Method Return Value
This method returns a double value.
## 
## Method Parameters
| bars | The [bars](bars-1.md) object chosen by the user when utilizing this Bars type |
| --- | --- |
| now | The DateTime value to measure |

## Syntax
You must override the method in your Bars Type with the following syntax.
 
public override double GetPercentComplete(Bars bars, DateTime now)  

{  

   

}
## 
## Examples
| ns |
| --- |
| public override double GetPercentComplete(Bars bars, DateTime now) {      // Calculate the percent complete for our monthly bars      if (now.Date \<\= bars.LastBarTime.Date)      {          int month \= now.Month;          int daysInMonth \= (month \=\= 2\) ? (DateTime.IsLeapYear(now.Year) ? 29 : 28\) :                 (month \=\= 1 \|\| month \=\= 3 \|\| month \=\= 5 \|\| month \=\= 7 \|\| month \=\= 8 \|\| month \=\= 10 \|\| month \=\= 12 ? 31 : 30\);          return (daysInMonth \- (barsSeries.LastBarTime.Date.AddDays(1\).Subtract(now).TotalDays / barsSeries.BarsPeriod.Value)) /                daysInMonth; // an estimate      }      return 1; } |

