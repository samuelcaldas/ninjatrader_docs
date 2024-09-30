
NinjaScript \> Language Reference \> Performance Metrics \> Format()
Format()
| \<\< [Click to Display Table of Contents](format.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Performance Metrics](performance_metrics-1.md) \> Format() | [Previous page](performance_metrics-1.md) [Return to chapter overview](performance_metrics-1.md) [Next page](onaddtrade-1.md) |
| --- | --- |
## Definition
This method allows you to customize the rendering of the performance value on the Summary grid.
 
## Syntax
public override string Format(object value, Cbi.PerformanceUnit unit, string propertyName)   

{  

     

}

## Examples
| ns |
| --- |
| public override string Format(object value, Cbi.PerformanceUnit unit, string propertyName) {      double\[] tmp \= value as double\[];      if (tmp !\= null \&\& tmp.Length \=\= 5)          switch (unit)          {                case Cbi.PerformanceUnit.Currency : return Core.Globals.FormatCurrency(tmp\[0], denomination);                case Cbi.PerformanceUnit.Percent   : return tmp\[1].ToString("P");                case Cbi.PerformanceUnit.Pips : return Math.Round(tmp\[2]).ToString(Core.Globals.GeneralOptions.CurrentCulture);                case Cbi.PerformanceUnit.Points : return Math.Round(tmp\[3]).ToString(Core.Globals.GeneralOptions.CurrentCulture);                case Cbi.PerformanceUnit.Ticks : return Math.Round(tmp\[4]).ToString(Core.Globals.GeneralOptions.CurrentCulture);          }      return value.ToString(); } |

