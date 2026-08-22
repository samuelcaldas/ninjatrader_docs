# ActualTradingDayEndLocal

## Definition

Returns the session's End-Of-Day (EOD) in the user's configured timezone.

 

> object.

## Property Value

A DateTime structure that represents end of a trading day (EOD).

## Syntax

<sessionIterator>.ActualTradingDayEndLocal

## Example

```csharp
SessionIteratorsessionIterator;
OnStateChange()
{
    State.Historical)
    {
        SessionIterator(Bars);
    }
}
OnBarUpdate()
{
    // on new bars session, find the next trading session
    (Bars.IsFirstBarOfSession)
    {
        // use the current bar time to calculate the next session
        );
        sessionIterator.ActualTradingDayEndLocal);
    }
}
```
