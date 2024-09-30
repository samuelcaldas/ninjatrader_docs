
NinjaScript \> Language Reference \> Add On \> NTTabPage Class \> Restore()
Restore()
| \<\< [Click to Display Table of Contents](nttabpage_restore.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [NTTabPage Class](nttabpage_class.md) \> Restore() | [Previous page](getheaderpart.md) [Return to chapter overview](nttabpage_class.md) [Next page](nttabpage_save.md) |
| --- | --- |
Restores any elements in our NTTabPage from the workspace. (e.g. Selected accounts or instruments)
 
## 
## Examples
| ns |
| --- |
| // NTTabPage member. Required for restoring elements from workspaces public void Restore(XElement element) {      if (element \=\= null)          return;        // Restore any elements you may have saved. e.g. selected accounts or instruments } |
