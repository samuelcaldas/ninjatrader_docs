
NinjaScript > Language Reference > Strategy > CloseStrategy()

CloseStrategy()
| << [Click to Display Table of Contents](closestrategy.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > CloseStrategy() | [Previous page](chartindicators-1.md) [Return to chapter overview](strategy-1.md) [Next page](connectionlosshandling-1.md) |
| --- | --- |
## Definition
Cancels all working orders, closes any existing positions, and finally disables the strategy.  This behavior can also be overridden for a given strategy if desired.
 
| Notes:   - If you choose to override this method using custom logic, the default behavior of the CloseStrategy() method will NOT be executed.  For this reason, it is suggested to call the base implementation of CloseStrategy() method within the virtual override to ensure that the strategy is terminated as designed, otherwise it is your responsibility to correctly manage any working orders or positions.- CloseStrategy() will work of the current strategy position and will not factor in any [StartBehavior](startbehavior-1.md) setting, i.e. calling CloseStrategy() while the script is in a virtual historical position could result in an unwanted position- The default CloseStrategy() handling will be applied to all series of a MultiSeries NinjaScript strategy. |
| --- |

## Method Return Value
This method does not return a value.
 
Syntax  

CloseStrategy(string signalName)
 
| Warning:  This method can only be call before the [State](state-1.md) has reached [State.Terminated](state-1.md) and after the [State](state-1.md) reaches [State.Realtime](state-1.md) |
| --- |

You may choose to override this method using the following syntax:
 
public override void CloseStrategy(string signalName)  

{
 
}

## Parameters
| signalName | The signal name which will be used to identify the closing order.  If no signal name exists or is null, "Close" will be substituted instead. |
| --- | --- |

## 
## 
## 
## Examples
| ns Basic usage of CloseStrategy |
| --- |
| DateTime StartTime = new DateTime();       protected override void OnStateChange() {    if (State == State.SetDefaults)    {                  Name = "ExampleStrategy";       }        else if (State == State.Transition)      StartTime = Core.Globals.Now;       }      protected override void OnBarUpdate() {    // if we're still in position 45 minutes after the start time, close strategy    if(Position.MarketPosition != MarketPosition.Flat && Time[0] >= StartTime.AddMinutes(45))      CloseStrategy("My Custom Close"); } |

| ns Overriding the Default CloseStrategy logic |
| --- |
| public override void CloseStrategy(string signalName) {    Print("Executing Custom Close Logic");      // custom close logic        // call default close action    base.CloseStrategy(signalName); } |
