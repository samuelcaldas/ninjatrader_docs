



INTTabFactory Interface

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](inttabfactory_class.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) >  INTTabFactory Interface | [Previous page](iintervalprovider_barsperiod.htm) [Return to chapter overview](add_on.htm) [Next page](createparentwindow.htm) |

If you wish to have tab page functionality like adding, removing, moving, duplicating tabs you must create a class which implements the INTTabFactory interface.

This interface contains two methods which must be hidden:

NTWindow CreateParentWindow();
------------------------------

NTTabPage CreateTabPage(string typeName, bool isNewWindow = false);
-------------------------------------------------------------------

Examples
--------

| ns |
| --- |
| public class MyWindowFactory : INTTabFactory  {      // INTTabFactory member. Creates the parent window that contains tabs      public NTWindow CreateParentWindow()      {          return new MyWindow();      }         // INTTabFactory member. Creates new tab pages whenever the user presses the + button      public NTTabPage CreateTabPage(string typeName)      {          return new MyWindowTabPage();      }  } |