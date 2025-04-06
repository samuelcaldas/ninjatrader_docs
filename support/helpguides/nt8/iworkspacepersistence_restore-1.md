



Restore()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\iworkspacepersistence_restore.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [IWorkspacePersistence Interface](iworkspacepersistence_interface-1.htm) >  Restore() | [Previous page](iworkspacepersistence_interface-1.htm) [Return to chapter overview](iworkspacepersistence_interface-1.htm) [Next page](iworkspacepersistence_save-1.htm) |

Restores the window from workspaces.

Examples
--------

| ns |
| --- |
| // IWorkspacePersistence member. Required for restoring window from workspaces  public void Restore(XDocument document, XElement)  {      if (MainTabControl != null)           MainTabControl.RestoreFromXElement(element);  } |