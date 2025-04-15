



AccountSelector

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](accountselector.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [NinjaTrader Controls](controls.md) >  AccountSelector | [Previous page](controls.md) [Return to chapter overview](controls.md) [Next page](atmstrategyselector.md) |

Definition
----------

AccountSelector can be used as an UI element users can interact with for selecting accounts.

Events and Properties
---------------------

|  |  |
| --- | --- |
| Cleanup() | NTTabPage base.Cleanup() is sufficient to clean up this control) |
| SelectedAccount | Account representing the selected account |
| SelectionChanged | Event handler for when the selected account has changed |

Examples
--------

| C# |
| --- |
| /\* Example of subscribing/unsubscribing to market data from an Add On. The concept can be carried over  to any NinjaScript object you may be working on. \*/  public class MyAddOnTab : NTTabPage  {      private AccountSelector accountSelector         public MyAddOnTab()      {           // Note: pageContent (not demonstrated in this example) is the page content of the XAML           // Find account selector           accountSelector = LogicalTreeHelper.FindLogicalNode(pageContent, "accountSelector") as AccountSelector;              // When the account selector's selection changes, unsubscribe and resubscribe           accountSelector.SelectionChanged += (o, args) =>           {                if (accountSelector.SelectedAccount != null)                {                     // Unsubscribe to any prior account subscriptions                    accountSelector.SelectedAccount.AccountItemUpdate -= OnAccountItemUpdate;                     accountSelector.SelectedAccount.ExecutionUpdate -= OnExecutionUpdate;                    accountSelector.SelectedAccount.OrderUpdate -= OnOrderUpdate;                     accountSelector.SelectedAccount.PositionUpdate -= OnPositionUpdate;                        // Subscribe to new account subscriptions                    accountSelector.SelectedAccount.AccountItemUpdate   += OnAccountItemUpdate;                     accountSelector.SelectedAccount.ExecutionUpdate     += OnExecutionUpdate;                     accountSelector.SelectedAccount.OrderUpdate         += OnOrderUpdate;                     accountSelector.SelectedAccount.PositionUpdate      += OnPositionUpdate;                }           };      }         // Called by TabControl when tab is being removed or window is closed      public override void Cleanup()      {           // Clean up our resources  .Cleanup();      }         // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.  } |

| XAML |
| --- |
| <Pagexmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  xmlns:Tools="clr-namespace:NinjaTrader.Gui.Tools;assembly=NinjaTrader.Gui"        xmlns:AtmStrategy="clr-namespace:NinjaTrader.Gui.NinjaScript.AtmStrategy;assembly=NinjaTrader.Gui">     <Grid>  VerticalAlignment="Top"/>  </Grid> |