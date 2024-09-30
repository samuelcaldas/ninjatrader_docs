
NinjaScript > Language Reference > Add On > IWorkspacePersistence Interface
IWorkspacePersistence Interface
| << [Click to Display Table of Contents](iworkspacepersistence_interface.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > IWorkspacePersistence Interface | [Previous page](createtabpage.md) [Return to chapter overview](add_on.md) [Next page](iworkspacepersistence_restore.md) |
| --- | --- |
When creating your [NTWindow](ntwindow.md), be sure to implement the IWorkspacePersistence interface as well for the ability to save and restore your window with NinjaTrader workspaces. 
 
| Note:  AddOn Classes which derive from NTWindow or implements IWorkspacePersistance CANNOT be a [nested type](https://msdn.microsoft.com/en-us/library/ms173120.aspx) of another class and MUST have a [default constructor](https://msdn.microsoft.com/en-us/library/ms173115.aspx) |
| --- |

This interface contains two methods and one property which must be hidden by the implementing class:
 
| [Restore()](iworkspacepersistence_restore.md) | Restores the window from workspaces. |
| --- | --- |
| [Save()](iworkspacepersistence_save.md) | Saves the window to workspaces. |
| [WorkspaceOptions](workspaceoptions.md) | Sets required workspace options. |

## 
## Examples
| ns |
| --- |
| public class MyWindow : NTWindow, IWorkspacePersistence {    // default constructor     public MyWindow()      {          // Define our NTWindow. If we want to use NT style tabs, we would define that here.                     // WorkspaceOptions property must be set           Loaded += (o, e) =>           {                if (WorkspaceOptions == null)                     WorkspaceOptions = new WorkspaceOptions("MyWindow-" + Guid.NewGuid().ToString("N"), this);           };      }        // IWorkspacePersistence member. Required for restoring window from workspaces      public void Restore(XDocument document, XElement)      {          if (MainTabControl != null)                MainTabControl.RestoreFromXElement(element);      }        // IWorkspacePersistence member. Required for saving window to workspaces      public void Save(XDocument document, XElement element)      {          if (MainTabControl != null)                MainTabControl.SaveToXElement(element);      }        // IWorkspacePersistence member      public WorkspaceOptions WorkspaceOptions { get; set; } } |
