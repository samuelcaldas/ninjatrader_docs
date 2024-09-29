


NinjaScript \> Language Reference \> Add On \> TabControl






















TabControl







| \<\< [Click to Display Table of Contents](tabcontrol.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> TabControl | [Previous page](propagateintervalchange()-1.md) [Return to chapter overview](add_on-1.md) [Next page](tabcontrolmanager-1.md) |
| --- | --- |











## Definition


The TabControl class provides functionality for working with [NTTabPage](nttabpage_class-1.md) objects within an [NTWindow](ntwindow-1.md). TabControl should be instantiated within the constructor for an NTWindow instance, in order to configure the window to be able to host and work with tabs.


 




| Note:  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.md) |
| --- |



 


## 


## Example


In the example below, we define an instance of NTWindow, then use TabControl to accomplish various setup tasks:


•Provide the NTWindow with the ability to add, remove, and move tabs

•Attach a Factory to the TabControl to handle logic for creating new tabs

•Set up the TabControl with the ability to utilize window linking

## 




| ns |
| --- |
| public class MyWindow : NTWindow, IWorkspacePersistence {    public MyWindow()    {        // TabControl should be created for window content if tab features are wanted        TabControl tc \= new TabControl();          // Attached properties defined in the TabControlManager class should be set to add, remove, or move tabs        TabControlManager.SetIsMovable(tc, true);        TabControlManager.SetCanAddTabs(tc, true);        TabControlManager.SetCanRemoveTabs(tc, true);          // if the ability to add new tabs is desired, TabControl must have attached property "Factory" set.        TabControlManager.SetFactory(tc, new MyWindowFactory());        Content \= tc;          /\* In order to have link buttons functionality, tab control items must be derived from Tools.NTTabPage         They can be added using extention method AddNTTabPage(NTTabPage page) \*/        tc.AddNTTabPage(new MyTab());    } }   /\* Class which implements Tools.INTTabFactory must be created and set as an attached property for TabControl in order to use tab page add/remove/move/duplicate functionality \*/ public class MyWindowFactory : INTTabFactory {    // INTTabFactory member. Required to create parent window    public NTWindow CreateParentWindow()    {        return new MyWindow();    }      // INTTabFactory member. Required to create tabs    public NTTabPage CreateTabPage(string typeName, bool isTrue)    {        return new MyTab();    } } |









