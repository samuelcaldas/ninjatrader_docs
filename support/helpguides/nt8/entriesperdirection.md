
NinjaScript > Language Reference > Strategy > EntriesPerDirection
EntriesPerDirection
| << [Click to Display Table of Contents](entriesperdirection.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > EntriesPerDirection | [Previous page](disconnectdelayseconds.md) [Return to chapter overview](strategy.md) [Next page](entryhandling.md) |
| --- | --- |
## Definition
Determines the maximum number of entries allowed per direction while a position is active based on the [EntryHandling](entryhandling.md) property.
 
| Note:  This property ONLY applies to Managed order methods.  When [IsUnmanaged](isunmanaged.md) is set to true, Entry Handling properties will be hidden from the UI. |
| --- |

## Property Value
An int value represents the maximum number of entries allowed.  Default value is 1.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
EntriesPerDirection
 
## 
## Examples
| ns |
| --- |
| // Example #1  protected override void OnStateChange() {      if (State == State.SetDefaults)      {          EntriesPerDirection = 1;          EntryHandling = EntryHandling.AllEntries;      } }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry); } |

| ns |
| --- |
| // Example #2 protected override void OnStateChange() {      EntriesPerDirection = 1;      EntryHandling = EntryHandling.UniqueEntries; }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry); } |

