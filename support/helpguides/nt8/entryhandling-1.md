
NinjaScript \> Language Reference \> Strategy \> EntryHandling
EntryHandling
| \<\< [Click to Display Table of Contents](entryhandling.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> EntryHandling | [Previous page](entriesperdirection-1.md) [Return to chapter overview](strategy-1.md) [Next page](execution-1.md) |
| --- | --- |
## Definition
Sets the manner in how entry orders will handle.
 
| Note:  This property ONLY applies to Managed order methods.  When [IsUnmanaged](isunmanaged-1.md) is set to true, Entry Handling properties will be hidden from the UI. |
| --- |

## Property Value
An enum which sets how the entry orders are handled.  Default value is EntryHandling.AllEntries.  Possible values include:
 
| EntryHandling.AllEntries | NinjaScript will process all [order entry methods](order_methods-1.md) until the maximum allowable entries set by the [EntriesPerDirection](entriesperdirection-1.md) property is reached while in an open position |
| --- | --- |
| EntryHandling.UniqueEntries | NinjaScript will process order entry methods until the maximum allowable entries set by the EntriesPerDirection property per each uniquely named entry |
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
EntryHandling
 
## 
## Examples
| ns Allow a maximum of two entries while a position is open |
| --- |
| // Example \#1 protected override void OnStateChange()  {      if (State \=\= State.SetDefaults)      {          EntriesPerDirection \= 2;          EntryHandling \= EntryHandling.AllEntries;      } }   protected override void OnBarUpdate()  {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry"); } |

| ns EnterLong() will be processed once for each uniquely named entry. |
| --- |
| // Example \#2 protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          EntriesPerDirection \= 1;          EntryHandling \= EntryHandling.UniqueEntries;      } }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry"); } |

