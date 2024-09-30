
NinjaScript > Language Reference > Add On > IWorkspacePersistence Interface > Save()
Save()
| << [Click to Display Table of Contents](iworkspacepersistence_save.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [IWorkspacePersistence Interface](iworkspacepersistence_interface-1.md) > Save() | [Previous page](iworkspacepersistence_restore-1.md) [Return to chapter overview](iworkspacepersistence_interface-1.md) [Next page](workspaceoptions-1.md) |
| --- | --- |
Saves the window to workspaces.
 
## 
## Examples
| ns |
| --- |
| // IWorkspacePersistence member. Required for saving window to workspaces public void Save(XDocument document, XElement element) {      if (MainTabControl != null)          MainTabControl.SaveToXElement(element); } |
