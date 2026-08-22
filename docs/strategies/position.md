# Position

## Definition

Represents position related information that pertains to an instance of a strategy.

> **Tips:**
- For multi-instrument scripts, please see [Positions](positions.md) object which holds an array of all instrument positions managed by the strategy's account
- For a real-world Account Position, please see [PositionAccount](positionaccount.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| Account | An [Account](../addons/account_class.md) object which corresponds to the position |
| [AveragePrice](position_averageprice.md) | Gets the average entry price of the strategy position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss.md) | Gets the unrealized PnL |
| [Instrument](position_instrument.md) | An [Instrument](../language_reference/instrument.md) value representing the instrument of an order |
| [MarketPosition](position_marketposition.md) | Gets the current market position    Possible values:  MarketPosition.Flat  MarketPosition.Long  MarketPosition.Short |
| [Quantity](position_quantity.md) | Gets the current position size |
| ToString() | A string representation of a position |

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average entry price
    Print("The average entry price is " + Position.AveragePrice);
}
```