
NinjaScript \> Language Reference \> Strategy \> EntryHandling
EntryHandling
| \<\< [Click to Display Table of Contents](entryhandling.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> EntryHandling | [Previous page](entriesperdirection.md) [Return to chapter overview](strategy.md) [Next page](execution.md) |
| --- | --- |
## Definition
Sets the manner in how entry orders will handle.
 
| Note:  This property ONLY applies to Managed order methods.  When [IsUnmanaged](isunmanaged.md) is set to true, Entry Handling properties will be hidden from the UI. |
| --- |

## Property Value
An enum which sets how the entry orders are handled.  Default value is EntryHandling.AllEntries.  Possible values include:
 
| EntryHandling.AllEntries | NinjaScript will process all [order entry methods](order_methods.md) until the maximum allowable entries set by the [EntriesPerDirection](entriesperdirection.md) property is reached while in an open position |
| --- | --- |
| EntryHandling.UniqueEntries | NinjaScript will process order entry methods until the maximum allowable entries set by the EntriesPerDirection property per each uniquely named entry |
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
EntryHandling
 
## 
## Examples
| ns |
| --- |
| // Example \#1 protected override void OnStateChange()  {      if (State \=\= State.SetDefaults)      {          EntriesPerDirection \= 2;          EntryHandling \= EntryHandling.AllEntries;      } }   protected override void OnBarUpdate()  {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry"); } |

| ns |
| --- |
| // Example \#2 protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          EntriesPerDirection \= 1;          EntryHandling \= EntryHandling.UniqueEntries;      } }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry"); } |

