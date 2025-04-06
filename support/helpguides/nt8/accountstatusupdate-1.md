



AccountStatusUpdate

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\accountstatusupdate.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Account](account_class-1.htm) >  AccountStatusUpdate | [Previous page](accountitemupdate-1.htm) [Return to chapter overview](account_class-1.htm) [Next page](all-1.htm) |

Definition
----------

AccountStatusUpdate can be used for subscribing to account status events from all accounts.

|  |
| --- |
| Note: Remember to unsubscribe if you are no longer using the subscription. |

Syntax
------

AccountStatusUpdate

 

Examples
--------

|  |
| --- |
| /\* Example of subscribing/unsubscribing to account status update events from an Add On. The concept can be carried over  to any NinjaScript object you may be working on. \*/  public class MyAddOnTab : NTTabPage  {      public MyAddOnTab()      {           // Subscribe to account status updates           Account.AccountStatusUpdate += OnAccountStatusUpdate;      }         // This method is fired on any status change of any account      private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)      {           // Output the account name and status           NinjaTrader.Code.Output.Process(string.Format("Account: {0} Status: {1}",                e.Account.Name, e.Status), PrintTo.OutputTab1);      }         // Called by TabControl when tab is being removed or window is closed      public override void Cleanup()      {           // Make sure to unsubscribe to the account status subscription          Account.AccountStatusUpdate -= OnAccountStatusUpdate;      }         // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code.  } |