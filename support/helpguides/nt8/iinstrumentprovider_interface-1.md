
NinjaScript > Language Reference > Add On > IInstrumentProvider Interface

IInstrumentProvider Interface
| << [Click to Display Table of Contents](iinstrumentprovider_interface.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > IInstrumentProvider Interface | [Previous page](playbackconnection-1.md) [Return to chapter overview](add_on-1.md) [Next page](iinstrumentprovider_instrument-1.md) |
| --- | --- |
When creating your [NTTabPage](nttabpage_class-1.md), if you wish to use the [instrument link](linking_windows-1.md), be sure to implement the IInstrumentProvider interface.
 
## 
## Examples
| ns |
| --- |
| public class MyWindowTabPage : NTTabPage, IInstrumentProvider {      private Instrument instrument;        public MyWindowTabPage()      {          /* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts          if we so choose here as well.             Note: XAML with event handlers defined inside WILL FAIL when attempted to load.           Note: XAML with "inline code" WILL FAIL when attempted to load */      }        // IInstrumentProvider member      public Instrument Instrument      {          get { return instrument; }          set           {                if (instrument != null)                {                     // Unsubscribe to subscriptions to previously selected instrument                }                                if (value != null)                {                     // Create subscriptions for the newly selected instrument                }                  instrument = value;                  // Send instrument to other windows linked to the same color                PropagateInstrumentChange(value);                  // Update the tab header name                RefreshHeader();           }      }        // Be sure to include all the required NTTabPage members as well } |
