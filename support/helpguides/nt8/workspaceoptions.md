



WorkspaceOptions

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](workspaceoptions.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [IWorkspacePersistence Interface](iworkspacepersistence_interface.htm) >  WorkspaceOptions | [Previous page](iworkspacepersistence_save.htm) [Return to chapter overview](iworkspacepersistence_interface.htm) [Next page](nttabpage_class.htm) |

Definition
----------

Sets required workspace options.

 

|  |
| --- |
| Notes:  •The WorkspaceOptions class includes logic for opening, closing, saving, and restoring workspaces, checking windows are off screen, and setting basic properties such as the workspace name and current status.  •A WorkspaceOptions property must simply be declared within your NTWindow, as in the example below. All of its contained logic is taken care of automatically. |

|  |
| --- |
| Tip: For a complete, working example of this class in use, please download the [AddOn Framework NinjaScript Basic Example](http://ninjatrader.com/support/helpGuides/AddOn_Framework_NinjaScript_Basic.zip) to your desktop. |

Examples
--------

| ns |
| --- |
| // IWorkspacePersistence member  public WorkspaceOptions WorkspaceOptions { get; set; } |