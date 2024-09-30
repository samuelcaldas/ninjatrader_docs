
NinjaScript > Language Reference > Common > SessionIterator > IsTradingDayDefined()

IsTradingDayDefined()

| << [Click to Display Table of Contents](istradingdaydefined.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) > IsTradingDayDefined() | [Previous page](isnewsession-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](simplefont_class-1.md) |
| --- | --- |
## Definition
Indicates a trading day is defined for a specific date.
 
## Property Value
A bool value when true indicates that the date passed in as an argument is defined as a full or partial trading day in the configured Trading Hours template; otherwise false. Also returns false if the specified date is marked as a full-day exchange holiday. 

## Parameters

| date | The DateTime value representing the date to check |
| --- | --- |

## Syntax
<SessionIterator>.IsTradingDayDefined(DateTime time);
 
## 
## Example

| ns |
| --- |
| DateTime thanksGivingDay = new DateTime(2017, 11, 23);   // Determine if the current instrument's exchange is open for trading on Thanksgiving day in 2017 if(Bars.SessionIterator.IsTradingDayDefined(thanksGivingDay))    Print(String.Format("{0} will be open for trading on Thanksgiving day, {1}", Instrument.MasterInstrument.Name, thanksGivingDay.Date)); |
