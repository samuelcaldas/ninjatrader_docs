# OnPositionUpdate()

## Definition

Called every time a [position](../strategies/position.md) changes state.

> **Note:** The OnPositionUpdate() method is called on ALL position updates (e.g., any account and instrument combination) and NOT just the specific items which are selected in the SuperDOM.

## Method Return Value

This method does not return a value.

## Syntax

protected override void OnPositionUpdate(PositionEventArgs positionUpdate)  
{

   
}

 

## Method Parameters

|  |  |
| --- | --- |
| positionUpdate | A PositionEventArgs representing the change in position |

## Examples

```csharp
protected override void OnPositionUpdate(PositionEventArgs positionUpdate)
{
    // Do not take action if the position update does not come from the selected SuperDOM instrument/account
    if (positionUpdate.Position.Instrument != SuperDom.Instrument
    || positionUpdate.Position.Account != SuperDom.Account)
    return;
    // Do something
}
```
