
NinjaScript \> Language Reference \> Add On \> INTTabFactory Interface
INTTabFactory Interface
| \<\< [Click to Display Table of Contents](inttabfactory_class.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> INTTabFactory Interface | [Previous page](iintervalprovider_barsperiod.md) [Return to chapter overview](add_on.md) [Next page](createparentwindow.md) |
| --- | --- |
If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the INTTabFactory interface. 

 
This interface contains two methods which must be hidden:
 
## NTWindow CreateParentWindow();
## NTTabPage CreateTabPage(string typeName, bool isNewWindow \= false);
## 
## Examples
| ns |
| --- |
| public class MyWindowFactory : INTTabFactory {      // INTTabFactory member. Creates the parent window that contains tabs      public NTWindow CreateParentWindow()      {          return new MyWindow();      }        // INTTabFactory member. Creates new tab pages whenever the user presses the \+ button      public NTTabPage CreateTabPage(string typeName)      {          return new MyWindowTabPage();      } } |
