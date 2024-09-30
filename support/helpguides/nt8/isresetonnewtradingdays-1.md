
NinjaScript \> Language Reference \> Common \> OnBarUpdate() \> IsResetOnNewTradingDays

IsResetOnNewTradingDays

| \<\< [Click to Display Table of Contents](isresetonnewtradingdays.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [OnBarUpdate()](onbarupdate-1.md) \> IsResetOnNewTradingDays | [Previous page](isfirsttickofbar-1.md) [Return to chapter overview](onbarupdate-1.md) [Next page](istickreplays-1.md) |
| --- | --- |
## Definition
Determines if the specified bar series is using Break at EOD
 

| Note:  The property available on the UI will override any values set in code. Please see the help guide topic on using [Break at EOD](break_at_eod-1.md) for more information |
| --- |
 
## Property Value
A bool\[] when true, indicates the specified [BarsArray](barsarray-1.md) is setup to run Break at EOD; otherwise false.  Default value is false
 
## Syntax
IsResetOnNewTradingDays\[int idx]

| Warning:  This property should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";    }      else if (State \=\= State.Configure)    {      //Add AAPL 1 minute with RTH trading hours, set to break EOD      AddDataSeries("AAPL", new BarsPeriod() { BarsPeriodType \= BarsPeriodType.Minute, Value \= 1 }, 50, "US Equities RTH", true);    }   } protected override void OnBarUpdate() {                   //Print out the current bars series name and break EOD setting on start up  //   IsResetOnNewTradingDays\[0]  Primary  //   IsResetOnNewTradingDays\[1]  AAPL    if (CurrentBar \=\= 0)              Print(BarsArray\[BarsInProgress].ToChartString() \+ " " \+ IsResetOnNewTradingDays\[BarsInProgress]);    //Output:    //ES 03\-15 (1 Minute) True  //AAPL (1 Minute) False          } |
