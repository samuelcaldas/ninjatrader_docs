# ActualSessionBegin

## Definition

Obtains the sessions start date and start time converted to the user's configured Time Zone.

 

> SessionIterator object.

## Property Value

A DateTime structure that represents beginning of a trading session.

## Syntax

<sessionIterator>.ActualSessionBegin

## Example

![Ns](../images/ns.png)

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
        sessionIterator.ActualSessionBegin);
    }
}
```