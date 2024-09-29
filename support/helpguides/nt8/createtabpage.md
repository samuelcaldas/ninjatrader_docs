


NinjaScript \> Language Reference \> Add On \> INTTabFactory Interface \> CreateTabPage()






















CreateTabPage()







| \<\< [Click to Display Table of Contents](createtabpage.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [INTTabFactory Interface](inttabfactory_class.md) \> CreateTabPage() | [Previous page](createparentwindow.md) [Return to chapter overview](inttabfactory_class.md) [Next page](iworkspacepersistence_interface.md) |
| --- | --- |











This determines which [NTTabPage](nttabpage_class.md) is created whenever a new tab is needed in our parent window for our Add On.


 


## 


## Examples




| ns |
| --- |
| // INTTabFactory member. Creates new tab pages whenever the user presses the \+ button public NTTabPage CreateTabPage(string typeName, bool isNewWindow \= false) {    return new MyWindowTabPage(); } |









