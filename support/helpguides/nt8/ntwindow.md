﻿


NinjaScript \> Language Reference \> Add On \> NTWindow






















NTWindow







| \<\< [Click to Display Table of Contents](ntwindow.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> NTWindow | [Previous page](ntmessageboxsimple_show().md) [Return to chapter overview](add_on.md) [Next page](numerictextbox.md) |
| --- | --- |











## Definition


The NTWindow class defines parent windows for custom window creation. Instances of NTWindow act as containers for instances of [NTTabPage](nttabpage_class.md), in which UI elements and their related logic are contained. 


 




| Notes:  •The [IWorkspacePersistance](iworkspacepersistence_interface.md) interface should be implemented if you want your window to be saved and restored with NinjaTrader workspaces.•AddOn Classes which derive from NTWindow or implements IWorkspacePersistance CANNOT be a [nested type](https://msdn.microsoft.com/en-us/library/ms173120.aspx) of another class and MUST have a [default constructor](https://msdn.microsoft.com/en-us/library/ms173115.aspx) |
| --- |



 


 


## Example


The example below shows how to instantiate an NTWindow while:


•Implementing IWorkspacePersistence to ensure the window is saved/restored in workspaces

•Setting the window caption and dimensions

•Instantiating a TabControl to support tabs within the window

•Setting workspace options

 




| Tip:  For a complete, working example of this class in use, download framework example located on our [AddOn Development Overview](addon_development_overview.md) |
| --- |



## 


## 




| ns |
| --- |
| public class AddOnFrameworkWindow : NTWindow, IWorkspacePersistence {    // default constructor    public AddOnFrameworkWindow()    {        // set Caption property (not Title), since Title is managed internally to properly combine selected Tab Header and Caption for display in the Windows taskbar        // This is the name displayed in the top\-left of the window        Caption \= "AddOn Framework";          // Set the default dimensions of the window        Width   \= 1085;        Height \= 900;          // TabControl should be created for window content if tab features are wanted        TabControl tc \= new TabControl();          // Attached properties defined in the TabControlManager class should be set to achieve adding, removing, and moving tabs        TabControlManager.SetIsMovable(tc, true);        TabControlManager.SetCanAddTabs(tc, true);        TabControlManager.SetCanRemoveTabs(tc, true);          // if ability to add new tabs is desired, TabControl has to have attached property "Factory" set.        TabControlManager.SetFactory(tc, new AddOnFrameworkWindowFactory());        Content \= tc;          /\* In order to have link buttons functionality, tab control items must be derived from Tools.NTTabPage         They can be added using extension method AddNTTabPage(NTTabPage page) \*/        tc.AddNTTabPage(new AddOnFrameworkTab());          // WorkspaceOptions property must be set        Loaded \+\= (o, e) \=\>        {            if (WorkspaceOptions \=\= null)                WorkspaceOptions \= new WorkspaceOptions("AddOnFramework\-" \+ Guid.NewGuid().ToString("N"), this);        };    }      // IWorkspacePersistence member. Required for restoring window from workspace    public void Restore(XDocument document, XElement element)    {        if (MainTabControl !\= null)            MainTabControl.RestoreFromXElement(element);    }      // IWorkspacePersistence member. Required for saving window to workspace    public void Save(XDocument document, XElement element)    {        if (MainTabControl !\= null)            MainTabControl.SaveToXElement(element);    }      // IWorkspacePersistence member    public WorkspaceOptions WorkspaceOptions { get; set; } } |









