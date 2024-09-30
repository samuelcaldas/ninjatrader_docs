
NinjaScript \> Language Reference \> SuperDOM Column \> MarketDepth
MarketDepth
| \<\< [Click to Display Table of Contents](superdomcolumn_marketdepth.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [SuperDOM Column](superdom_column-1.md) \> MarketDepth | [Previous page](superdom_column-1.md) [Return to chapter overview](superdom_column-1.md) [Next page](superdomcolumn_onmarketdata-1.md) |
| --- | --- |
## Definition
## Provides Level 2 information for a SuperDOMColumn
 
| Note:  In order to ensure you are using the same exact MarketDepth subscription that the SuperDOM's main price ladder is using, it is required that you create your own MarketDepth handler.  The NinjaScript Code Wizard was designed to automatically complete this process for you, and an example is outlined at the bottom of this page |
| --- |

 
## Property Value
| SuperDom.MarketDepth | A collection of MarketDepthRows |
| --- | --- |
| SuperDom.MarketDepth.Asks | A collection of orders on the ask side of the market |
| SuperDom.MarketDepth.Bids | A collection of orders on the bid side of the market |
| SuperDom.MarketDepth.Instrument | The instrument which is being updated |

## Syntax
SuperDom.MarketDepth  

SuperDom.MarketDepth.Asks\[int idx];  

SuperDom.MarketDepth.Bids\[int idx];  

SuperDom.MarketDepth.Instrument
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {          if (State \=\= State.Active)    {      // subscribe to the same market depth events as the primary SuperDOM Price Ladder      if (SuperDom.MarketDepth !\= null)      {          WeakEventManager\<Data.MarketDepth\<LadderRow\>, Data.MarketDepthEventArgs\>.AddHandler(SuperDom.MarketDepth, "Update", OnMarketDepthUpdate);      }    }    else if (State \=\= State.Terminated)    {      // unsubscribe to the same market depth events as the primary SuperDOM Price Ladder      if (SuperDom \=\= null) return;        if (SuperDom.MarketDepth !\= null)      {          WeakEventManager\<Data.MarketDepth\<LadderRow\>, Data.MarketDepthEventArgs\>.RemoveHandler(SuperDom.MarketDepth, "Update", OnMarketDepthUpdate);                  }    } }   // custom market depth handler   private void OnMarketDepthUpdate(object sender, Data.MarketDepthEventArgs e) {    // Print some data to the Output window    if (e.MarketDataType \=\= MarketDataType.Ask \&\& e.Operation \=\= Operation.Update)      Print(string.Format("The most recent ask change is {0} {1}", e.Price, e.Volume)); } |
