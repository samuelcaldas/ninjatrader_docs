
NinjaScript \> Language Reference \> Add On \> INTTabFactory Interface \> CreateTabPage()
CreateTabPage()
| \<\< [Click to Display Table of Contents](createtabpage.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [INTTabFactory Interface](inttabfactory_class-1.md) \> CreateTabPage() | [Previous page](createparentwindow-1.md) [Return to chapter overview](inttabfactory_class-1.md) [Next page](iworkspacepersistence_interface-1.md) |
| --- | --- |
This determines which [NTTabPage](nttabpage_class-1.md) is created whenever a new tab is needed in our parent window for our Add On.
 
## 
## Examples
| ns |
| --- |
| // INTTabFactory member. Creates new tab pages whenever the user presses the \+ button public NTTabPage CreateTabPage(string typeName, bool isNewWindow \= false) {    return new MyWindowTabPage(); } |

