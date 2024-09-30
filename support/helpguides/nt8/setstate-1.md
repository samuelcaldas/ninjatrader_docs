
NinjaScript > Language Reference > Common > OnStateChange()  > SetState()
SetState() 
| << [Click to Display Table of Contents](setstate.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnStateChange()](onstatechange-1.md) > SetState() | [Previous page](onstatechange-1.md) [Return to chapter overview](onstatechange-1.md) [Next page](state-1.md) |
| --- | --- |
## Definition
This method is used for changing the [State](state-1.md) of any running NinjaScript object.
 
| Notes: - Attempting to set a State earlier than the current State will be ignored- Calling SetState() multiple times will be ignored to prevent the object from erroneously setting states unexpectedly - Setting State to State.Terminated is meant as a way to abort the strategy as it is running. Doing this in a Strategy Analyzer backtest will abort the backtest entirely, and no partial backtest results will be shown.  - After setting State.Terminated, you should return from the calling method to help ensure subsequent logic is not processed asynchronously to OnStateChange() |
| --- |

## 
 
## Method Return Value
This method does not return a value.
## 
## 
## Syntax
SetState(State state)
## 
 
| Warning:  This method should only be call after the [State](state-1.md) reaches [State.DataLoaded](state-1.md) |
| --- |

 
## 
## Parameters
| state | The [State](state-1.md) to be set |
| --- | --- |

 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    // Terminate strategy at 2PM    if (ToTime(Time[0]) == 140000)    {      SetState(State.Terminated);      return;    } } |
