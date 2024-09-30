
MarketDepth
MarketDepth

| \<\< [Click to Display Table of Contents](superdom_marketdepth.md) \>\> **Navigation:**   »No topics above this level«   MarketDepth | [Return to chapter overview](sharpdx_directwrite_textlayout-1.md) |
| --- | --- |

## Definition
The OnMarketDepth() method is called and guaranteed to be in the correct sequence for every change in level two market data (market depth) for the underlying instrument.
 
## Method Return Value
This method does not return a value.
 
## Method Parameters

## Syntax

 
## 
## Examples
| ns | |
| --- | --- |
|  | protected override void OnMarketDepth(Data.MarketDepthEventArgs marketDepthUpdate) {      if (marketDepthUpdate.MarketDataType \=\= MarketDataType.Ask \&\& marketDepthUpdate.Operation \=\= Operation.Update)           // Do something } |

