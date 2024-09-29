


NinjaScript \> Language Reference \> Add On \> IWorkspacePersistence Interface \> Save()






















Save()







| \<\< [Click to Display Table of Contents](iworkspacepersistence_save.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [IWorkspacePersistence Interface](iworkspacepersistence_interface.md) \> Save() | [Previous page](iworkspacepersistence_restore.md) [Return to chapter overview](iworkspacepersistence_interface.md) [Next page](workspaceoptions.md) |
| --- | --- |











Saves the window to workspaces.


 


## 


## Examples




| ns |
| --- |
| // IWorkspacePersistence member. Required for saving window to workspaces public void Save(XDocument document, XElement element) {      if (MainTabControl !\= null)          MainTabControl.SaveToXElement(element); } |









