
NinjaScript \> Language Reference \> Add On \> MarketData

MarketData

| \<\< [Click to Display Table of Contents](marketdata.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> MarketData | [Previous page](fundamentaldata-1.md) [Return to chapter overview](add_on-1.md) [Next page](marketdepth-1.md) |
| --- | --- |
## Definition
MarketData can be used to access snapshot market data and for subscribing to market data events.
 

| Notes:  1\.Remember to unsubscribe if you are no longer using the subscription.2\.You should only unsubscribe to a market data event if you are actually subscribed. |
| --- |

## Properties

| Ask | A [MarketDataEventArgs](marketdataeventargs-1.md) representing the ask price |
| --- | --- |
| Bid | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the bid price |
| DailyHigh | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the daily high |
| DailyLow | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the daily low |
| DailyVolume | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the daily volume |
| Instrument | An [Instrument](instrument-1.md) representing the instrument |
| Last | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the last price |
| LastClose | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the last close |
| Opening | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the opening price |
| OpenInterest | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the open interest |
| Settlement | A [MarketDataEventArgs](marketdataeventargs-1.md)  representing the settlement price |
| Update | Event handler for subscribing/unsubscribing to market depth events   Note:  Attempting to unsubscribe to this event before there is a subscription will generate errors. |
 
## Syntax
MarketData

## Example

| ns |
| --- |
| /\* Example of subscribing/unsubscribing to market data from an Add On. The concept can be carried over to any NinjaScript object you may be working on. \*/ public class MyAddOnTab : NTTabPage {  private Instrument instrument;    public MyAddOnTab()  {          instrument \= Instrument.GetInstrument("AAPL");          if (instrument \=\= null)                  return;            // Subscribe to market data. Snapshot data is provided right on subscription          // Note: "instrument" is a placeholder in this example, you will need to replace           // with a valid Instrument object through various methods or properties available depending          // on the NinjaScript type you are working with (e.g., Bars.Instrument or Instrument.GetInstrument()          if (!instrument.Dispatcher.HasShutdownStarted)                  instrument.Dispatcher.InvokeAsync(() \=\> instrument.MarketData.Update \+\= OnMarketData);            // Printing snapshot market data for the last price and time          NinjaTrader.Code.Output.Process(instrument.MarketData.Last.Price.ToString() \+ " " \+ instrument.MarketData.Last.Time.ToString(),                  PrintTo.OutputTab1\);  }    // This method is fired on market data events  private void OnMarketData(object sender, MarketDataEventArgs e)  {          // Do something with market data events  }    // Called by TabControl when tab is being removed or window is closed  public override void Cleanup()  {          // Make sure to unsubscribe to the market data subscription          if (instrument !\= null)                  instrument.MarketData.Update \-\= OnMarketData;  }    // Other required NTTabPage members left out for demonstration purposes. Be sure to add them in your own code. } |
