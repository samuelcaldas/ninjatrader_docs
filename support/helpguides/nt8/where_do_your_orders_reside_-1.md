
Operations > Order Entry > Where do your orders reside?
Where do your orders reside?

| << [Click to Display Table of Contents](where_do_your_orders_reside_.md) >> **Navigation:**     [Operations](operations-1.md) > [Order Entry](order_entry-1.md) > Where do your orders reside? | [Previous page](working_with_forex-1.md) [Return to chapter overview](order_entry-1.md) [Next page](trade_controls-1.md) |
| --- | --- |

## NinjaTrader
Orders in a state "Accepted" or "Working" or "Suspended" are at the brokerage or exchange. If the exchange does not support a specific order type, the order will be active on the NinjaTraders servers.
Most OCO (One Cancels Other) functionality is simulated on your local PC.
## 
## Continuum/CQG
Orders in a state "Accepted" or "Working" are at the brokerage or exchange. If the exchange does not support a specific order type, the order will be active on the Continuum servers.
Most OCO (One Cancels Other) functionality is natively supported on their servers, but please see the disclaimer section here for more information: [https://support.ninjatrader.com/s/article/Connecting-To-Your-NinjaTrader-Continuum-Feed](https://support.ninjatrader.com/s/article/Connecting-To-Your-NinjaTrader-Continuum-Feed)
 
## FOREX.com/City Index
Orders in a state "Accepted" or "Working" are on FOREX.com servers.
OCO (One Cancels Other) functionality is simulated on your local PC.
 
## FXCM
Orders in a state "Accepted" or "Working" are on FXCM servers.
OCO (One Cancels Other) functionality is natively supported on their servers.
 
Interactive Brokers
Orders in a state "Accepted" or "Working" are at the brokerage or exchange. If the exchange does not support a specific order type, the order will be active on the Interactive Broker servers.
OCO (One Cancels Other) functionality is natively supported on their servers.
 
## Rithmic
Orders in a state "Accepted" or "Working" are at the brokerage or exchange. If the exchange does not support a specific order type, the order will be active on the Rithmic servers.
OCO (One Cancels Other) functionality is simulated on your local PC.
 
## TD Ameritrade
Orders in a state "Accepted" or "Working" are at the brokerage or exchange. If the exchange does not support a specific order type, the order will be active on the TD Ameritrade servers.
OCO (One Cancels Other) functionality is natively supported on their servers.

| Note: Please note that MIT orders and Simulated Orders, which are in [TriggerPending state](order_state_definitions-1.md), could not be recovered by NinjaTrader, if the provider does not provide native support. The order state after connection recovery would then be 'Unknown'. |
| --- |

