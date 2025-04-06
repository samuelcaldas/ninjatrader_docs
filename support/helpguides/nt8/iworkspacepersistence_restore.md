



Restore()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](iworkspacepersistence_restore.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [IWorkspacePersistence Interface](iworkspacepersistence_interface.htm) >  Restore() | [Previous page](iworkspacepersistence_interface.htm) [Return to chapter overview](iworkspacepersistence_interface.htm) [Next page](iworkspacepersistence_save.htm) |

Restores the window from workspaces.

Examples
--------

| ns |
| --- |
| // IWorkspacePersistence member. Required for restoring window from workspaces  public void Restore(XDocument document, XElement)  {      if (MainTabControl != null)           MainTabControl.RestoreFromXElement(element);  } |