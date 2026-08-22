# Time

## Definition

A collection of historical bar time stamp values.

## Property Value

An `ISeries<DateTime>` object.

## Syntax

Time  
Time[int barsAgo] (returns a [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure)

## Examples

```csharp
// Prints the current bar time stamp
Print(Time[0].ToString());
// Checks if current time is greater than the bar time stamp
if (DateTime.Now.Ticks > Time[0].Ticks)
Print("Do something");
```
