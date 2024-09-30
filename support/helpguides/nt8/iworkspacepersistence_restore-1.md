
NinjaScript \> Language Reference \> Add On \> IWorkspacePersistence Interface \> Restore()
Restore()
| \<\< [Click to Display Table of Contents](iworkspacepersistence_restore.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [IWorkspacePersistence Interface](iworkspacepersistence_interface-1.md) \> Restore() | [Previous page](iworkspacepersistence_interface-1.md) [Return to chapter overview](iworkspacepersistence_interface-1.md) [Next page](iworkspacepersistence_save-1.md) |
| --- | --- |
Restores the window from workspaces.
 
## 
## Examples
| ns |
| --- |
| // IWorkspacePersistence member. Required for restoring window from workspaces public void Restore(XDocument document, XElement) {      if (MainTabControl !\= null)           MainTabControl.RestoreFromXElement(element); } |
