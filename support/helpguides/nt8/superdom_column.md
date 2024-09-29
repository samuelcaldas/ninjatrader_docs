


NinjaScript \> Language Reference \> SuperDOM Column






















SuperDOM Column







| \<\< [Click to Display Table of Contents](superdom_column.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> SuperDOM Column | [Previous page](waitforococlosingbracket.md) [Return to chapter overview](language_reference_wip.md) [Next page](superdomcolumn_marketdepth.md) |
| --- | --- |











Custom SuperDOM Columns can be used to add additional functionality to the [SuperDOM](superdom.md) window. The methods and properties covered in this section are unique to custom SuperDOM column development.


 




| Tip:  The system SuperDOM Columns which ship with NinjaTrader are open source and you can review their implementation from the [NinjaScript Editor](ns_explorer.md) SuperDOMColumn folder, or by using the text editor of your choice by reviewing the source code located in Documents\\NinjaTrader 8\\bin\\Custom\\SuperDomColumns |
| --- |



 


## 


## In this section




| [MarketDepth](superdom_marketdepth.md) | Provides Level 2 information for a SuperDOMColumn. |
| --- | --- |
| [OnMarketData()](superdomcolumn_onmarketdata.md) | Called and guaranteed to be in the correct sequence for every change in level one market data for the underlying instrument. The OnMarketData() method updates can include but is not limited to the bid, ask, last price and volume. |
| [OnOrderUpdate()](superdomcolumn_onorderupdate.md) | Called every time an [order](order.md) changes state. An order will change state when a change in order quantity, price or state (e.g. working to filled) occurs. |
| [OnPositionUpdate()](superdomcolumn_onpositionupdate.md) | Called every time a [position](position.md) changes state. |
| [OnPropertyChanged()](onpropertychanged.md) | This method should be used any time you wish to repaint the column instead of calling [OnRender()](superdomcolumn_onrender.md) directly. |
| [OnRender()](superdomcolumn_onrender.md) | Used to draw custom content to the SuperDOM Column, such as a Grid. |
| [OnRestoreValues()](onrestorevalues.md) | Called when the column is restored (e.g. from a workspace). |









