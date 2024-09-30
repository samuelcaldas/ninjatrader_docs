
NinjaScript > Language Reference > Add On > NTTabPage Class > Save()
Save()

| << [Click to Display Table of Contents](nttabpage_save.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [NTTabPage Class](nttabpage_class.md) > Save() | [Previous page](nttabpage_restore.md) [Return to chapter overview](nttabpage_class.md) [Next page](alert_and_debug_concepts.md) |
| --- | --- |

Saves elements in our NTTabPage to the workspace (e.g. Selected accounts or instruments)
 
## 
## Examples
| ns |
| --- |
| // NTTabPage member. Required for saving elements to workspaces public void Save(XElement element) {      if (element == null)          return;        // Save any elements you may want persisted. e.g. selected accounts or instruments } |

