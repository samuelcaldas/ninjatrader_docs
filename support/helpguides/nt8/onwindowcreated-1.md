﻿
NinjaScript > Language Reference > Add On > OnWindowCreated()

OnWindowCreated()

| << [Click to Display Table of Contents](onwindowcreated.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > OnWindowCreated() | [Previous page](numerictextbox-1.md) [Return to chapter overview](add_on-1.md) [Next page](onwindowdestroyed-1.md) |
| --- | --- |
## Definition
This method is called whenever a new [NTWindow](ntwindow-1.md) is created. It will be called in the thread of that window.  This is where you would install your AddOn to an existing window, or if creating your own custom window, add a Menu item to the NinjaTrader Control Center.
 

| Note:  This method will also be called on a recompile of the NinjaTrader.Custom project (e.g., when you compile an indicator, strategy, or add-on) |
| --- |
## 
## 
## Method Return Value
This method does not return a value
## 
## Syntax
OnWindowCreated(Window window)
 
## Parameters

| window | A Window object which is being added to the workspace |
| --- | --- |
## 
## 
## Examples

| ns |
| --- |
| public class MyWindowAddOn : AddOnBase {      private NTMenuItem myMenuItem;      private NTMenuItem existingMenuItem;        protected override void OnStateChange()      {          if (State == State.SetDefaults)          {                Description = "Our custom MyWindow add on";                Name       = "MyWindow";          }      }        // Will be called as a new NTWindow is created. It will be called in the thread of that window      protected override void OnWindowCreated(Window window)      {          // We want to place our add on in the Control Center's menus          ControlCenter cc = window as ControlCenter;          if (cc == null)                return;            /* Determine we want to place our add on in the Control Center's "New" menu           Other menus can be accessed via the control's Automation ID. For example: toolsMenuItem,             workspacesMenuItem, connectionsMenuItem, helpMenuItem. */          existingMenuItem = cc.FindFirst("ControlCenterMenuItemNew") as NTMenuItem;          if (existingMenuItem == null)                return;            // 'Header' sets the name of our add on seen in the menu structure          myMenuItem = new NTMenuItem { Header = "My Menu Item",                Style = Application.Current.TryFindResource("MainMenuItem") as Style };            // Place our add on into the "New" menu          existingMenuItem.Items.Add(myMenuItem);            // Subscribe to the event for when the user presses our add on's menu item          myMenuItem.Click += OnMenuItemClick;      }        // Open our add on's window when the menu item is clicked on      private void OnMenuItemClick(object sender, RoutedEventArgs e)      {          // Show the NTWindow "MyWindow"          Core.Globals.RandomDispatcher.InvokeAsync(new Action(()=> new MyWindow().Show()));      } } |
