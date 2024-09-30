
NinjaScript \> Language Reference \> Add On \> NTTabPage Class \> Save()
Save()
| \<\< [Click to Display Table of Contents](nttabpage_save.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [NTTabPage Class](nttabpage_class-1.md) \> Save() | [Previous page](nttabpage_restore-1.md) [Return to chapter overview](nttabpage_class-1.md) [Next page](alert_and_debug_concepts-1.md) |
| --- | --- |
Saves elements in our NTTabPage to the workspace (e.g. Selected accounts or instruments)
 
## 
## Examples
| ns |
| --- |
| // NTTabPage member. Required for saving elements to workspaces public void Save(XElement element) {      if (element \=\= null)          return;        // Save any elements you may want persisted. e.g. selected accounts or instruments } |
