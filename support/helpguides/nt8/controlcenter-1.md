



ControlCenter

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\controlcenter.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) >  ControlCenter | [Previous page](atmstrategy-1.htm) [Return to chapter overview](add_on-1.htm) [Next page](fundamentaldata-1.htm) |

Definition
----------

ControlCenter is a XAML-defined class containing the layout and properties of the Control Center window. When altering the Control Center window (for example, to add a menu item into the "New" menu to launch an NTWindow as part of an AddOn, as seen in the example below), a generic reference to a Window object can be cast to ControlCenter specifically.

|  |
| --- |
| Note:  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.htm) |

Example
-------

| ns |
| --- |
| private NTMenuItem ControlCenterNewMenu;     protected override void OnWindowCreated(Window window)  {     // We want to place the menu item for the AddOn in the Control Center's "New" menu     // First obtain a reference to the Control Center window     ControlCenter cc = window as ControlCenter;     if (cc == null)         return;        /\* Determine we want to place the AddOn in the Control Center's "New" menu      Other menus can be accessed via the control's "Automation ID". For example: toolsMenuItem, workspacesMenuItem, connectionsMenuItem, helpMenuItem. \*/     ControlCenterNewMenu = cc.FindFirst("ControlCenterMenuItemNew") as NTMenuItem;  } |