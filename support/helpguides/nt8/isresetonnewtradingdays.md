
NinjaScript \> Language Reference \> Common \> OnBarUpdate() \> IsResetOnNewTradingDays

IsResetOnNewTradingDays

| \<\< [Click to Display Table of Contents](isresetonnewtradingdays.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [OnBarUpdate()](onbarupdate.md) \> IsResetOnNewTradingDays | [Previous page](isfirsttickofbar.md) [Return to chapter overview](onbarupdate.md) [Next page](istickreplays.md) |
| --- | --- |
## Definition
Determines if the specified bar series is using Break at EOD
 

| Note:  The property available on the UI will override any values set in code. Please see the help guide topic on using [Break at EOD](break_at_eod.md) for more information |
| --- |
 
## Property Value
A bool\[] when true, indicates the specified [BarsArray](barsarray.md) is setup to run Break at EOD; otherwise false.  Default value is false
 
## Syntax
IsResetOnNewTradingDays\[int idx]

| Warning:  This property should NOT be accessed within the [OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded |
| --- |
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name \= "Examples Indicator";    }      else if (State \=\= State.Configure)    {      //Add AAPL 1 minute with RTH trading hours, set to break EOD      AddDataSeries("AAPL", new BarsPeriod() { BarsPeriodType \= BarsPeriodType.Minute, Value \= 1 }, 50, "US Equities RTH", true);    }   } protected override void OnBarUpdate() {                   //Print out the current bars series name and break EOD setting on start up  //   IsResetOnNewTradingDays\[0]  Primary  //   IsResetOnNewTradingDays\[1]  AAPL    if (CurrentBar \=\= 0)              Print(BarsArray\[BarsInProgress].ToChartString() \+ " " \+ IsResetOnNewTradingDays\[BarsInProgress]);    //Output:    //ES 03\-15 (1 Minute) True  //AAPL (1 Minute) False          } |
