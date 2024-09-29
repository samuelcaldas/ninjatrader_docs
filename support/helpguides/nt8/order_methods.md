


NinjaScript \> Language Reference \> Strategy \> Order Methods






















Order Methods







| \<\< [Click to Display Table of Contents](order_methods.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> Order Methods | [Previous page](isterminalstate.md) [Return to chapter overview](strategy.md) [Next page](managed_approach.md) |
| --- | --- |











 




| Note: You will not be able to mix and match the two approaches. If you decide to go with the Managed approach you will only be able to use the Managed order methods. If you decide to go with the Unmanaged approach you will only be able to use the Unmanaged order methods. |
| --- |



 




| Order Methods Overview NinjaScript provides several approaches you can use for order placement within your NinjaScript strategy. The main approaches can be categorized as a Managed approach and an Unmanaged approach. | |
| --- | --- |
| Managed The Managed approach offers you order methods that are wrapped with an invisible convenience layer that allows you to focus on your system's trading rules leaving the underlying mechanics of order management and the relationships between entry and exit orders and positions to NinjaTrader. The cost for having the convenience layer is that there are [order handling rules](managed_approach.md) that must be followed to prevent order errors.   ›[Understanding the Managed approach](managed_approach.md)›[Advanced Order Handling](advanced_order_handling.md)›[CancelOrder()](managed_cancelorder.md)›[EnterLong()](enterlong.md)›[EnterLongLimit()](enterlonglimit.md)›[EnterLongMIT()](enterlongmit.md)›[EnterLongStopMarket()](enterlongstopmarket.md)›[EnterLongStopLimit()](enterlongstoplimit.md)›[EnterShort()](entershort.md)›[EnterShortLimit()](entershortlimit.md)›[EnterShortMIT()](entershortmit.md)›[EnterShortStopMarket()](entershortstopmarket.md)›[EnterShortStopLimit()](entershortstoplimit.md)›[ExitLong()](exitlong.md)›[ExitLongLimit()](exitlonglimit.md)›[ExitLongMIT()](exitlongmit.md)›[ExitLongStopMarket()](exitlongstopmarket.md)›[ExitLongStopLimit()](exitlongstoplimit.md)›[ExitShort()](exitshort.md)›[ExitShortLimit()](exitshortlimit.md)›[ExitShortMIT()](exitshortmit.md)›[ExitShortStopMarket()](exitshortstopmarket.md)›[ExitShortStopLimit()](exitshortstoplimit.md)›[GetRealtimeOrder()](getrealtimeorder.md)›[SetProfitTarget()](setprofittarget.md)›[SetStopLoss()](setstoploss.md)›[SetTrailStop()](settrailstop.md)›[SetParabolicStop()](setparabolicstop.md) | Unmanaged The Unmanaged approach offers you more flexible order methods without the convenience layer. This means you are not restricted to any order handling rules besides those imposed by the brokerage/exchange. With such flexibility though, you will have to ensure to program your strategy to handle any and all issues that may arise with placing orders.   ›[Understanding the Unmanaged approach](unmanaged_approach.md)›[CancelOrder()](unmanaged_cancelorder.md)›[ChangeOrder()](managed_changeorder.md)›[GetRealtimeOrder()](getrealtimeorder.md)›[IgnoreOverfill](ignoreoverfill.md)›[IsUnmanaged](isunmanaged.md)›[SubmitOrderUnmanaged()](submitorderunmanaged.md) |



 


 








