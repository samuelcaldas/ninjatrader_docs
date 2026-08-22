# ActualSessionEnd

## Definition

Obtains the session's end date and end time converted to the user's configured Time Zone.

 

> object.

## Property Value

A DateTime structure that represents end of a trading session.

## Syntax

<sessionIterator>.ActualSessionEnd

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
        sessionIterator.ActualSessionEnd);
    }
}
```
