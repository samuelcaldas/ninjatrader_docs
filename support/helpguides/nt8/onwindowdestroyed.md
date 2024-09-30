
NinjaScript \> Language Reference \> Add On \> OnWindowDestroyed()

OnWindowDestroyed()

| \<\< [Click to Display Table of Contents](onwindowdestroyed.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> OnWindowDestroyed() | [Previous page](onwindowcreated.md) [Return to chapter overview](add_on.md) [Next page](onwindowrestored.md) |
| --- | --- |
## Definition
This method is called whenever a new [NTWindow](ntwindow.md) is destroyed. It will be called in the thread of that window.  A window is destroyed either by the user closing the window, closing a workspace, or on a shut down of NinjaTrader.
 

| Note:  This method will also be called on a recompile of the NinjaTrader.Custom project (e.g., when you compile an indicator, strategy, or add\-on) |
| --- |
## 
## 
## Method Return Value
This method does not return a value
## 
## Syntax
OnWindowDestroyed(Window window)
 
## Parameters

| window | A Window object which is being removed from the workspace |
| --- | --- |
 
## 
## Examples

| ns |
| --- |
| public class MyWindowAddOn : AddOnBase {      private NTMenuItem myMenuItem;      private NTMenuItem existingMenuItem;        protected override void OnStateChange()      {          if (State \=\= State.SetDefaults)           {                Description \= "Our custom MyWindow add on";                Name        \= "MyWindow";           }      }        // Will be called as a new NTWindow is destroyed. It will be called in the thread of that window      protected override void OnWindowDestroyed(Window window)      {           if (myMenuItem !\= null \&\& window is ControlCenter)           {                if (existingMenuItem !\= null \&\& existingMenuItem.Items.Contains(myMenuItem))                    existingMenuItem.Items.Remove(myMenuItem);                  myMenuItem.Click \-\= OnMenuItemClick;                myMenuItem \= null;           }      } } |
