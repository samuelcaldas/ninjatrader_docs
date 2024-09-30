
NinjaScript \> Language Reference \> Bars Type \> IsTimeBased

IsTimeBased
| \<\< [Click to Display Table of Contents](barstype_istimebased.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Bars Type](bars_type.md) \> IsTimeBased | [Previous page](isremovelastbarsupported.md) [Return to chapter overview](bars_type.md) [Next page](ondatapoint.md) |
| --- | --- |
## Definition
Used to indicate the BarsType is built from time\-based bars (day, minute, second).  Setting this property on a custom bar type is useful for correct calculations from many core data and session logic, and can also be used by 3rd party NinjaScript objects to determine how to interact with the [bars](bars.md).
 
## Property Value
A bool which when true tells other objects the bars are built from time; default set to false.
 
## Syntax
Bars.IsTimeBased
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name     \= "Custom BarsType";      IsTimeBased   \= true; // indicates to the core the these bars are built using time.    }    } |

| ns |
| --- |
| protected override void OnBarUpdate() {    // include milliseconds time stamps for tick based bars    string timeFormat \= "HH:mm:ss:fff";      if (Bars.BarsType.IsTimeBased)    {      // on time based bars, only format up to "seconds"      timeFormat \= "HH:mm:ss";    }    // format string based on the appropriate time format    Print(Time\[0].ToString(timeFormat)); } |
