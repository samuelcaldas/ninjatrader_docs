



IInstrumentProvider Interface

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\iinstrumentprovider_interface.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) >  IInstrumentProvider Interface | [Previous page](playbackconnection-1.htm) [Return to chapter overview](add_on-1.htm) [Next page](iinstrumentprovider_instrument-1.htm) |

When creating your [NTTabPage](nttabpage_class-1.htm), if you wish to use the [instrument link](linking_windows-1.htm), be sure to implement the IInstrumentProvider interface.

Examples
--------

| ns |
| --- |
| public class MyWindowTabPage : NTTabPage, IInstrumentProvider  {      private Instrument instrument;         public MyWindowTabPage()      {          /\* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts          if we so choose here as well.              Note: XAML with event handlers defined inside WILL FAIL when attempted to load.           Note: XAML with "inline code" WILL FAIL when attempted to load \*/      }         // IInstrumentProvider member      public Instrument Instrument      {          get { return instrument; }          set           {                if (instrument != null)                {                     // Unsubscribe to subscriptions to previously selected instrument                }                               if (value != null)                {                     // Create subscriptions for the newly selected instrument                }                   instrument = value;                   // Send instrument to other windows linked to the same color                PropagateInstrumentChange(value);                   // Update the tab header name                RefreshHeader();           }      }         // Be sure to include all the required NTTabPage members as well  } |