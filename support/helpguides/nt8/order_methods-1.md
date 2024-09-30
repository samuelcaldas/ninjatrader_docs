
NinjaScript \> Language Reference \> Strategy \> Order Methods

Order Methods

| \<\< [Click to Display Table of Contents](order_methods.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> Order Methods | [Previous page](isterminalstate-1.md) [Return to chapter overview](strategy-1.md) [Next page](managed_approach-1.md) |
| --- | --- |
 

| Note: You will not be able to mix and match the two approaches. If you decide to go with the Managed approach you will only be able to use the Managed order methods. If you decide to go with the Unmanaged approach you will only be able to use the Unmanaged order methods. |
| --- |
 

| Order Methods Overview NinjaScript provides several approaches you can use for order placement within your NinjaScript strategy. The main approaches can be categorized as a Managed approach and an Unmanaged approach. | |
| --- | --- |
| Managed The Managed approach offers you order methods that are wrapped with an invisible convenience layer that allows you to focus on your system's trading rules leaving the underlying mechanics of order management and the relationships between entry and exit orders and positions to NinjaTrader. The cost for having the convenience layer is that there are [order handling rules](managed_approach-1.md) that must be followed to prevent order errors.   ›[Understanding the Managed approach](managed_approach-1.md)›[Advanced Order Handling](advanced_order_handling-1.md)›[CancelOrder()](managed_cancelorder-1.md)›[EnterLong()](enterlong-1.md)›[EnterLongLimit()](enterlonglimit-1.md)›[EnterLongMIT()](enterlongmit-1.md)›[EnterLongStopMarket()](enterlongstopmarket-1.md)›[EnterLongStopLimit()](enterlongstoplimit-1.md)›[EnterShort()](entershort-1.md)›[EnterShortLimit()](entershortlimit-1.md)›[EnterShortMIT()](entershortmit-1.md)›[EnterShortStopMarket()](entershortstopmarket-1.md)›[EnterShortStopLimit()](entershortstoplimit-1.md)›[ExitLong()](exitlong-1.md)›[ExitLongLimit()](exitlonglimit-1.md)›[ExitLongMIT()](exitlongmit-1.md)›[ExitLongStopMarket()](exitlongstopmarket-1.md)›[ExitLongStopLimit()](exitlongstoplimit-1.md)›[ExitShort()](exitshort-1.md)›[ExitShortLimit()](exitshortlimit-1.md)›[ExitShortMIT()](exitshortmit-1.md)›[ExitShortStopMarket()](exitshortstopmarket-1.md)›[ExitShortStopLimit()](exitshortstoplimit-1.md)›[GetRealtimeOrder()](getrealtimeorder-1.md)›[SetProfitTarget()](setprofittarget-1.md)›[SetStopLoss()](setstoploss-1.md)›[SetTrailStop()](settrailstop-1.md)›[SetParabolicStop()](setparabolicstop-1.md) | Unmanaged The Unmanaged approach offers you more flexible order methods without the convenience layer. This means you are not restricted to any order handling rules besides those imposed by the brokerage/exchange. With such flexibility though, you will have to ensure to program your strategy to handle any and all issues that may arise with placing orders.   ›[Understanding the Unmanaged approach](unmanaged_approach-1.md)›[CancelOrder()](unmanaged_cancelorder-1.md)›[ChangeOrder()](managed_changeorder-1.md)›[GetRealtimeOrder()](getrealtimeorder-1.md)›[IgnoreOverfill](ignoreoverfill-1.md)›[IsUnmanaged](isunmanaged-1.md)›[SubmitOrderUnmanaged()](submitorderunmanaged-1.md) |

