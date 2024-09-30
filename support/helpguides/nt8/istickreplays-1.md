
NinjaScript > Language Reference > Common > OnBarUpdate() > IsTickReplays

IsTickReplays

| << [Click to Display Table of Contents](istickreplays.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnBarUpdate()](onbarupdate-1.md) > IsTickReplays | [Previous page](isresetonnewtradingdays-1.md) [Return to chapter overview](onbarupdate-1.md) [Next page](update-1.md) |
| --- | --- |
## Definition
Indicates the specified bar series is using Tick Replay.   Please see the help guide topic on using [Tick Replay](tick_replay-1.md) for general information on this mode.
 

| Note:  For a primary series, the Tick Replay option must be configured from the UI before a NinjaScript object can take use of this property.  The setting on the Chart's Data Series menu will always take precedence for an object series which already exists on the user's chart. |
| --- |

| Warning:  This property should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |
## 
 
## Property Value
A bool[] when true, indicates the specified [BarsArray](barsarray-1.md) is setup to run Tick Replay; otherwise false.  Default value is false
 
## Syntax
IsTickReplays[int idx]
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if(State == State.SetDefaults)    {        Name = "Examples Indicator";    }        else if (State == State.Configure)    {      AddDataSeries("AAPL", BarsPeriodType.Minute, 1);       }    else if (State == Data.Loaded)    {       // IsTickReplays[0] = true;        // Programmatically setting this option here for Primary [0] does not have any effect            // Primary series must be configured from UI                   // It is not possible to combine Tick Replay series and non Tick Replay series in a single chart or script      // The assignment below would not be necessary if the primary series were set to True via the UI      // IsTickReplays[1] = true;    } }   protected override void OnBarUpdate() {                     //Print out the current bars series name and tick replays setting on start up    if (CurrentBar == 0)                Print(BarsArray[BarsInProgress].ToChartString() + " " + IsTickReplays[BarsInProgress]); } |
