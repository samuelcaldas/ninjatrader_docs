
NinjaScript \> Language Reference \> SuperDOM Column
SuperDOM Column

| \<\< [Click to Display Table of Contents](superdom_column.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> SuperDOM Column | [Previous page](waitforococlosingbracket-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](superdomcolumn_marketdepth-1.md) |
| --- | --- |

Custom SuperDOM Columns can be used to add additional functionality to the [SuperDOM](superdom-1.md) window. The methods and properties covered in this section are unique to custom SuperDOM column development.
 
| Tip:  The system SuperDOM Columns which ship with NinjaTrader are open source and you can review their implementation from the [NinjaScript Editor](ns_explorer-1.md) SuperDOMColumn folder, or by using the text editor of your choice by reviewing the source code located in Documents\\NinjaTrader 8\\bin\\Custom\\SuperDomColumns |
| --- |

 
## 
## In this section
| [MarketDepth](superdom_marketdepth.md) | Provides Level 2 information for a SuperDOMColumn. |
| --- | --- |
| [OnMarketData()](superdomcolumn_onmarketdata-1.md) | Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The OnMarketData() method updates can include but is not limited to the bid, ask, last price and volume. |
| [OnOrderUpdate()](superdomcolumn_onorderupdate-1.md) | Called every time an [order](order-1.md) changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs. |
| [OnPositionUpdate()](superdomcolumn_onpositionupdate-1.md) | Called every time a [position](position-1.md) changes state. |
| [OnPropertyChanged()](onpropertychanged-1.md) | This method should be used any time you wish to repaint the column instead of calling [OnRender()](superdomcolumn_onrender-1.md) directly. |
| [OnRender()](superdomcolumn_onrender-1.md) | Used to draw custom content to the SuperDOM Column, such as a Grid. |
| [OnRestoreValues()](onrestorevalues-1.md) | Called when the column is restored (e.g. from a workspace). |

