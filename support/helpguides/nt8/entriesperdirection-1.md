


NinjaScript \> Language Reference \> Strategy \> EntriesPerDirection






















EntriesPerDirection







| \<\< [Click to Display Table of Contents](entriesperdirection.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> EntriesPerDirection | [Previous page](disconnectdelayseconds-1.md) [Return to chapter overview](strategy-1.md) [Next page](entryhandling-1.md) |
| --- | --- |











## Definition


Determines the maximum number of entries allowed per direction while a position is active based on the [EntryHandling](entryhandling-1.md) property.


 




| Note:  This property ONLY applies to Managed order methods.  When [IsUnmanaged](isunmanaged-1.md) is set to true, Entry Handling properties will be hidden from the UI. |
| --- |



 


 


## Property Value


An int value represents the maximum number of entries allowed.  Default value is 1\.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


EntriesPerDirection


 


## 


## Examples




| ns If an open position already exists, subsequent EnterLong() calls are ignored. |
| --- |
| // Example \#1  protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          EntriesPerDirection \= 1;          EntryHandling \= EntryHandling.AllEntries;      } }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry); } |



 


 




| ns EnterLong() will be processed once for each uniquely named entry. |
| --- |
| // Example \#2 protected override void OnStateChange() {      EntriesPerDirection \= 1;      EntryHandling \= EntryHandling.UniqueEntries; }   protected override void OnBarUpdate() {      if (CrossAbove(SMA(10), SMA(20), 1)          EnterLong("SMA Cross Entry");        if (CrossAbove(RSI(14, 3), 30, 1)          EnterLong("RSI Cross Entry); } |









