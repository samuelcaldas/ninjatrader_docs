



CreateTabPage()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\createtabpage.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [INTTabFactory Interface](inttabfactory_class-1.htm) >  CreateTabPage() | [Previous page](createparentwindow-1.htm) [Return to chapter overview](inttabfactory_class-1.htm) [Next page](iworkspacepersistence_interface-1.htm) |

This determines which [NTTabPage](nttabpage_class-1.htm) is created whenever a new tab is needed in our parent window for our Add On.

Examples
--------

| ns |
| --- |
| // INTTabFactory member. Creates new tab pages whenever the user presses the + button  public NTTabPage CreateTabPage(string typeName, bool isNewWindow = false)  {     return new MyWindowTabPage();  } |