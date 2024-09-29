


NinjaScript \> Language Reference \> Add On \> Connection \> ConnectionStatusUpdate






















ConnectionStatusUpdate







| \<\< [Click to Display Table of Contents](connectionstatusupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Connection](connection_class-1.md) \> ConnectionStatusUpdate | [Previous page](connect-1.md) [Return to chapter overview](connection_class-1.md) [Next page](disconnect-1.md) |
| --- | --- |











## Definition


ConnectionStatusUpdate can be used for subscribing to connection status update events.


 


Note: Remember to unsubscribe if you are no longer using the subscription.


 


## Syntax


ConnectionStatusUpdate


 


 


## Example




| ns |
| --- |
| /\* Example of subscribing/unsubscribing to connection update events from an Add On. The concept can be carried over to any NinjaScript object you may be working on. \*/ public class MyAddOnTab : NTTabPage {      private Connection connection;      public MyAddOnTab()      {          // Subscribe to connection updates          Connection.ConnectionStatusUpdate \+\= OnConnectionStatusUpdate;      }        // This method is fired on connection status update events      private void OnConnectionStatusUpdate(object sender, ConnectionStatusEventArgs e)      {          /\* For multi\-threading reasons, work with a copy of the ConnectionStatusEventArgs to prevent situations           where the ConnectionStatusEventArgs may already be ahead of us while in the middle processing it. \*/          ConnectionStatusEventArgs eCopy \= e;            // If the Kinetick EOD connection disconnects, do something          if (eCopy.Connection.Options.Name \=\= "Kinetick \- End Of Day (Free)")          {                if (eCopy.Status \=\= ConnectionStatus.Disconnected)                    // Do something          }      }        // Called by TabControl when tab is being removed or window is closed      public override void Cleanup()      {          // Make sure to unsubscribe to the connection status subscription          Connection.ConnectionStatusUpdate \-\= OnConnectionStatusUpdate;      }        // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code. } |









