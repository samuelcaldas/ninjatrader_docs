
NinjaScript \> Language Reference \> Add On \> INTTabFactory Interface \> CreateParentWindow()
CreateParentWindow()
| \<\< [Click to Display Table of Contents](createparentwindow.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [INTTabFactory Interface](inttabfactory_class-1.md) \> CreateParentWindow() | [Previous page](inttabfactory_class-1.md) [Return to chapter overview](inttabfactory_class-1.md) [Next page](createtabpage-1.md) |
| --- | --- |
This determines which [NTWindow](ntwindow-1.md) is created as the parent window for our Add On.
 
## 
## Examples
| ns |
| --- |
| // INTTabFactory member. Creates the parent window that contains tabs public NTWindow CreateParentWindow() {      return new MyWindow(); } |

