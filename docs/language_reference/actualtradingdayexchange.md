# ActualTradingDayExchange

## Definition

Obtains the date of a trading session defined by the exchange.

 

> **Notes:** would be considered 3/31/2015 12:00:00AM

## Property Value

A DateTime structure that represents the trading day.

## Syntax

<sessionIterator>.ActualTradingDayExchange

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
        sessionIterator.ActualTradingDayExchange);
    }
}
```