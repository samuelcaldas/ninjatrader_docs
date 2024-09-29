


NinjaScript \> Language Reference \> Add On \> IWorkspacePersistence Interface \> Restore()






















Restore()







| \<\< [Click to Display Table of Contents](iworkspacepersistence_restore.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [IWorkspacePersistence Interface](iworkspacepersistence_interface.md) \> Restore() | [Previous page](iworkspacepersistence_interface.md) [Return to chapter overview](iworkspacepersistence_interface.md) [Next page](iworkspacepersistence_save.md) |
| --- | --- |











Restores the window from workspaces.


 


## 


## Examples




| ns |
| --- |
| // IWorkspacePersistence member. Required for restoring window from workspaces public void Restore(XDocument document, XElement) {      if (MainTabControl !\= null)           MainTabControl.RestoreFromXElement(element); } |









