


NinjaScript \> Language Reference \> Add On \> NTTabPage Class \> Restore()






















Restore()







| \<\< [Click to Display Table of Contents](nttabpage_restore.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [NTTabPage Class](nttabpage_class-1.md) \> Restore() | [Previous page](getheaderpart-1.md) [Return to chapter overview](nttabpage_class-1.md) [Next page](nttabpage_save-1.md) |
| --- | --- |











Restores any elements in our NTTabPage from the workspace. (e.g. Selected accounts or instruments)


 


## 


## Examples




| ns |
| --- |
| // NTTabPage member. Required for restoring elements from workspaces public void Restore(XElement element) {      if (element \=\= null)          return;        // Restore any elements you may have saved. e.g. selected accounts or instruments } |









