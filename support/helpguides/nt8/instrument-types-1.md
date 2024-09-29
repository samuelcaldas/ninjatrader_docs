


Operations \> Instruments \> Instrument Types






















Instrument Types







| \<\< [Click to Display Table of Contents](instrument-types.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Instruments](instruments-1.md) \> Instrument Types | [Previous page](instruments-1.md) [Return to chapter overview](instruments-1.md) [Next page](searching_for_instruments-1.md) |
| --- | --- |











NinjaTrader supports the following Instrument types, although what your individual connected to provider can support will vary. Please consult [this link](data_by_provider-1.md) for more info.


 


## CFD (Contract for Difference)


 


•CFD instruments can be charted and traded

•Master instrument prefaced with a @ sign.

•The PnL will be currency converted to the account base denomination (execution tab "Rate" can be used to see conversion rate details), NinjaTrader uses the corresponding CFD FX instruments to make the conversion.

 


## Cryptocurrency


## 


•Cryptocurrencies can be charted but not traded.

•They have a dedicated [Depth Chart](depth_chart-1.md) window for analysis

 


## Forex


## 


•Forex instruments can be charted and traded

•These instruments do not trade on a centralized ("exchange") market, thus pricing differences between providers are to be expected.

•The PnL will be currency converted to the account base denomination (execution tab "Rate" can be used to see conversion rate details), NinjaTrader uses the corresponding Forex instruments to make the conversion.

 


## Future


## 


•Futures contracts can be charted and traded

•They need to be requested with the specific desired expiry

•Per default NinjaTrader will built continuous 'merged' contracts, for more info please consult [this link](mergepolicy-1.md).

•The PnL will be currency converted to the account base denomination, NinjaTrader uses the CME FX futures (6A, 6B, 6E, etc) to make the conversion.

 


## Index


 


•Indices can be charted but not traded.

•Master instrument prefaced with a ^ sign.

 


## Stock


 


•Stocks can be charted and traded.

 


## Option


 


•Options can be charted (real\-time only) and traded

•Options master instruments and properties are dynamically injected into the database and therefore are not search\-able. Also they are removed as the database file is [reset](database_operations-1.md) or deleted.

•Options are requested through the dedicated [Options Chain window](option-chain-1.md) 

•Options can be less liquid than futures, especially before major economic data releases or in less popular expiration's or strikes. Using market orders including use of [Close](closing_a_position_or_atm_stra-1.md) or [Flatten all](flatten-1.md) could result in a fill worse than using limit orders.

•Options are not supported for NinjaScript usage








