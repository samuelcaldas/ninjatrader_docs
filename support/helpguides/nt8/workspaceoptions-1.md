
NinjaScript > Language Reference > Add On > IWorkspacePersistence Interface > WorkspaceOptions
WorkspaceOptions

| << [Click to Display Table of Contents](workspaceoptions.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [IWorkspacePersistence Interface](iworkspacepersistence_interface-1.md) > WorkspaceOptions | [Previous page](iworkspacepersistence_save-1.md) [Return to chapter overview](iworkspacepersistence_interface-1.md) [Next page](nttabpage_class-1.md) |
| --- | --- |

## Definition
Sets required workspace options. 
 
| Notes:  - The WorkspaceOptions class includes logic for opening, closing, saving, and restoring workspaces, checking windows are off screen, and setting basic properties such as the workspace name and current status.- A WorkspaceOptions property must simply be declared within your NTWindow, as in the example below. All of its contained logic is taken care of automatically. |
| --- |

| Tip: For a complete, working example of this class in use, please download the [AddOn Framework NinjaScript Basic Example](http://ninjatrader.com/support/helpGuides/AddOn_Framework_NinjaScript_Basic.zip) to your desktop. |
| --- |

## Examples
| ns |
| --- |
| // IWorkspacePersistence member public WorkspaceOptions WorkspaceOptions { get; set; } |

