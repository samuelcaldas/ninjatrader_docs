
NinjaScript > Language Reference > Common > SessionIterator > GetTradingDay()
GetTradingDay()
| << [Click to Display Table of Contents](gettradingday.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) > GetTradingDay() | [Previous page](getnextsession-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](gettradingdaybeginlocal-1.md) |
| --- | --- |
## Definition
Returns the actual trading date based on the exchange, calculated from a DateTime object passed with with the local time. GetTradingDay() calls CalculateTradingDay() on a custom SessionIterator object created by passing in a Bars object as an argument. 
 
| Warning: This method can ONLY be called when a SessionIterator was created with a 'Bars' parameter. |
| --- |

 
## 
## Property Value
A DateTime object representing the [ActualTradingDayExchange](actualtradingdayexchange-1.md) property.
 
## Syntax
<SessionIterator>.GetTradingDay(DateTime timeLocal)
## 
## Parameters
| timeLocal | The DateTime value used to calculate the next trading day. |
| --- | --- |

## 
## Example
| ns |
| --- |
| // Declare a new custom SessionIterator SessionIterator mySessionIterator;   protected override void OnStateChange() {    if (State == State.Historical)    {        // Instantiate mySessionIterator once in State.Configure        mySessionIterator = new SessionIterator(BarsArray[0]);    } }   protected override void OnBarUpdate() {    // Obtain the ActualTradingDayExchange value for mySessionIterator, based on today's date    Print(mySessionIterator.GetTradingDay(DateTime.Now).ToString()); } |
