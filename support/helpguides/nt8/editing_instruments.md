


Operations \> Instruments \> Editing Instruments






















Editing Instruments







| \<\< [Click to Display Table of Contents](editing_instruments.md) \>\> **Navigation:**     [Operations](operations.md) \> [Instruments](instruments.md) \> Editing Instruments | [Previous page](manage_database.md) [Return to chapter overview](instruments.md) [Next page](rolling_over_a_futures_contrac.md) |
| --- | --- |














The Instrument window displays all parameters that define an instrument including symbol mappings to your connectivity provider and symbol level commission values. The editor allows you to change or add parameters to an instrument's profile. In general, instruments that are predefined in NinjaTrader do not require any parameter modification. However, you may want to override your global commission settings if a particular symbol has a unique commission structure.


 


In the Instruments window, once an instrument is selected in the instrument grid, you can double left mouse click or press the edit button to open the Instrument window.


![tog_minus](tog_minus.gif)




| General Section The General Section in the Instrument window displays parameters that uniquely define an instrument.   Instruments_InstrumentWindow     | Master instrument | The NinjaTrader master name of the instrument | | --- | --- | | Instrument type | The instrument type (asset class) | | Currency | The currency the instrument trades in | | Exchanges | Click to select what exchanges the instrument trades on | | Point value | The currency value of 1 point of movement for the instrument | | Merge policy | The merge settings applied to historical data. (See the [Data Tab](options_marketdata.md) section of the Help Guide for more information on merge policies and to set the global merge policy) | | Sim feed start price | The starting price for the internally generated data feed (Simulated Data Feed connection). The price is automatically set by NinjaTrader using the last seen price from a live data feed connection. | | Trading hours | Sets the default trading hours for the instrument. (See the [Session Manager](trading_hours.md) section of the Help Guide for more information) | | Tick size | The increment value the instrument trades in | | Description | Description of the instrument | | URL | The website address of the instrument definition | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)




| Symbol Mapping If you add a new instrument that is not already in the NinjaTrader instrument database, you will need to map the new instrument to the symbol used for the connectivity provider (broker or data feed) that you will be requesting data from. Most instruments in the database are already mapped.   Instruments_InstrumentSymbolMap |
| --- |



![tog_minus](tog_minus.gif)        [Understanding Splits \& Dividends section](javascript:HMToggle('toggle','UnderstandingSplitsDividendsSection','UnderstandingSplitsDividendsSection_ICON'))




| Splits \& Dividends With an equity instrument selected, the Splits \& Dividends section will be available for editing. NinjaTrader will split and dividend adjust historical chart data based on the information defined per instrument and if [options are enabled](options_marketdata.md) to do so. Some market data providers provide already adjusted data while others do not. Please see the [Adding Splits and Dividends](adding_splits_and_dividends.md) page of the help guide for more information on adding split and dividend data to an instrument.   Clicking the Update button will attempt to download Split \& Dividend data directly from your provider so that manual entry is not necessary.   Instruments_InstrumentSplitsAndDividends |
| --- |



![tog_minus](tog_minus.gif)        [Understanding the Contract months section](javascript:HMToggle('toggle','UnderstandingTheContractMonthsSection','UnderstandingTheContractMonthsSection_ICON'))




| Contract Months The Contract months section shows the contract months with associated rollover dates. This information is automatically downloaded from the NinjaTrader server whenever you are connected to your live data feed or the [Simulated Data Feed](simulated_data_feed_connection.md).    Instruments_InstrumentContractMonths     You can open up the defined contract months by left mouse clicking in the Contract months field.    Instruments_ContractMonths   You can add and remove contract months by selecting the add and remove buttons in the bottom of the Configured section. You can also copy contract months that are defined in another instrument by right clicking in the Configured section then selecting Load rollovers from instrument...   Instruments_ContractMonths2   Contract Month Properties Once a contract is selected in the Configured section you may edit it properties. The Contract month, Offset value, and Rollover date are used when NinjaTrader automatically merges historical data.   The Offset value is used to connect the last value of a contract month with the next one.    Although NinjaTrader will attempt to download the Offset values from the data server, if they do not exist on the data server, they will be calculated locally. Offsets are only downloaded when the "Offset" field is left blank and the rollover date matches the date defined on the server.   When NinjaTrader will calculate the Offset value locally:   •The Offset field in the Contract Months window is blank•Historical data exists in the database for both the new and old contract near the rollover date•The Merge Back Adjusted policy must be selected in the Market data category of the [Options](options.md) menu•You must be connected to your data provider and requesting data for the instrument  How NinjaTrader will calculate the Offset value locally:   •Request the old and new expiry’s daily price data for calculations•If daily data is not offered by the data provider, use minute data•If minute data is not offered by the data provider, default Offset value will be 0•One day prior to the rollover date, calculate the difference between the close price of the new expiry and the close price of the old expiry. This is the Offset value.•If you wish to overwrite the calculated Offset value you can input in your own•When using minute data, the close price at the ending time as defined in the default session template for the instrument will be used    | Notes:  1\.If you inputted your own Offset value, it will be overwritten by values downloaded from the data server if it exists there. To prevent this you will need to ensure that your rollover date is not the same as the ones coming from the data server.2\.The rollover date is the date to roll into the selected contract month and NOT out of. | | --- | |
| --- | --- |










