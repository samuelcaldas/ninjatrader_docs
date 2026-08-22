# State

## Definition

Represents the current progression of the object as it advances from setup, processing data, to termination.  These states can be used for setting up or declaring various resources and properties.

> **Note:** More detailed explanation of various states along with examples can be found in the [OnStateChange()](onstatechange.md) method section of this help guide.  You can also attempt to set a new State using the [SetState()](setstate.md) method.

## Property Value

An enum value representing the current state of the object.  Possible values are:

|  |  |
| --- | --- |
| SetDefaults | Default values are set (pushed to UI). |
| Configure | User the presses the OK or Apply button. |
| Active | Object is configured and is ready to receive instructions |
| DataLoaded | All data series have been loaded |
| Historical | Begins to process historical data |
| Transition | Finished processing historical data |
| Realtime | Begins to process realtime data. |
| Terminated | Begins to shut down |

## Syntax

State

 

 

## Examples

```csharp
protected override void OnStateChange()
{
    Print(DateTime.Now + ": Current State is State."+State);
}
csharp
ns
protected override void OnBarUpdate()
{
    // only process real-time OnBarUpdate events
    if (State == State.Historical)
    return;
    //rest of logic
}
```
