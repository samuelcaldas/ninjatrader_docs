
NinjaScript \> Language Reference \> Common \> SessionIterator \> GetTradingDay()
GetTradingDay()
| \<\< [Click to Display Table of Contents](gettradingday.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [SessionIterator](sessioniterator.md) \> GetTradingDay() | [Previous page](getnextsession.md) [Return to chapter overview](sessioniterator.md) [Next page](gettradingdaybeginlocal.md) |
| --- | --- |
## Definition
Returns the actual trading date based on the exchange, calculated from a DateTime object passed with with the local time. GetTradingDay() calls CalculateTradingDay() on a custom SessionIterator object created by passing in a Bars object as an argument. 
 
| Warning: This method can ONLY be called when a SessionIterator was created with a 'Bars' parameter. |
| --- |

 
## 
## Property Value
A DateTime object representing the [ActualTradingDayExchange](actualtradingdayexchange.md) property.
 
## Syntax
\<SessionIterator\>.GetTradingDay(DateTime timeLocal)
## 
## Parameters
| timeLocal | The DateTime value used to calculate the next trading day. |
| --- | --- |

## 
## Example
| ns |
| --- |
| // Declare a new custom SessionIterator SessionIterator mySessionIterator;   protected override void OnStateChange() {    if (State \=\= State.Historical)    {        // Instantiate mySessionIterator once in State.Configure        mySessionIterator \= new SessionIterator(BarsArray\[0]);    } }   protected override void OnBarUpdate() {    // Obtain the ActualTradingDayExchange value for mySessionIterator, based on today's date    Print(mySessionIterator.GetTradingDay(DateTime.Now).ToString()); } |
