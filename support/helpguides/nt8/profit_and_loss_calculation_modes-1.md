
Operations \> Trade Performance \> Profit and Loss Calculation Modes

Profit and Loss Calculation Modes

| \<\< [Click to Display Table of Contents](profit_and_loss_calculation_modes.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Trade Performance](trade_performance-1.md) \> Profit and Loss Calculation Modes | [Previous page](statistics_definitions-1.md) [Return to chapter overview](trade_performance-1.md) [Next page](trade_performance_properties-1.md) |
| --- | --- |
Trade Performance statistics are based on core PnL calculations, which differ for each selected Display Units (currency, percent, points, pips or ticks) calculation mode. Below is a list of the formulas used for each calculation mode.
## 
## Calculation Modes

| Currency | Rate of Exit \* Profit in Points \* Lot Size of Exit \* Point Value of Exit |
| --- | --- |
| Percent | (Profit in Points \* Lot Size of Entry) / (Quantity \* Higher of .01 or Absolute Value of Entry Price) |
| Points | (1 for Long position, or \-1 for short position) \* Quantity \* (Exit Price \- Entry Price \- Entry Commission \- Exit Commission) / (Exit Rate \* Point Value) / Lot Size |
| Pips | Forex Instruments: Profit in Ticks \* Tick Size Other Instruments: Profit in Ticks |
| Ticks | Profit in Points / Tick Size |
 

| Note:  - Since execution quantity is factored into the PnL calculation in Points, and since other calculations rely on Profit in Points, each calculation mode takes execution quantity into account by extension.-  It is possible to have trades which are technically profitable in percent, but are not profitable based on their point value (or vice versa) |
| --- |
 
## Terms used

| Entry | The last Entry execution |
| --- | --- |
| Exit | The last Exit execution |
| Rate | The currency conversation rate used back to the account demonstration (E.g.,  A rate of 1 means no conversion took place) |
| Lot Size | Default Forex Lot Size for the account.  1 for non\-forex accounts. |
| Point Value | Instrument value per point define in the [Instruments](instruments-1.md) window |
