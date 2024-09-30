
Operations \> Instruments \> Adding Splits and Dividends

Adding Splits and Dividends
| \<\< [Click to Display Table of Contents](adding_splits_and_dividends.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Instruments](instruments-1.md) \> Adding Splits and Dividends | [Previous page](rolling_over_a_futures_contrac-1.md) [Return to chapter overview](instruments-1.md) [Next page](tradestation_symbol_mapping-1.md) |
| --- | --- |
You can automatically update an instrument with historical split adjustment data from within the Instrument window. You can choose to update split information from the following connections:
 
1\. IQFeed
2\. Kinetick (you must have a subscription \- the free Kinetick EOD does NOT provide splits and dividend information)
 
## Adding Splits via the instruments window
To automatically update an instrument with historical split data follow the steps below. If you have already defined one of the connections above then you may skip step 1\.
 
1\.Create a connection to one of the providers above, see the [Connection Guide](%3C%25CONNECTIONGUIDE%25%3E) for more information

2\.Connect to the provider by left mouse clicking on the menu Connect and selecting your connection.

3\.Open the Instruments window by left mouse clicking on the menu Tools and select the menu item Instruments.

4\.Select a single stock or select multiple stock that you wish to update with historical split data Note: Hold down CTRL to individually toggle instrument selection or SHIFT to toggle selecting a group of instruments.

5\.Right click on one of the selected stocks and left mouse click the menu Update Splits.

 
NinjaTrader will now request historical splits information from your provider and populate the information in your local database.
 
| Notes: The Update Splits menu item is only enabled when you are connected to one of the providers mentioned above.  At this time, no supported connections provider dividends. Dividends must be manually added. |
| --- |

 
## Adding Splits for a predefined instrument list
You can perform the same steps above on a predefined instrument list by going to the NinjaTrader Control Center Tools menu and selecting Instrument Lists. Here you can right click on the instrument list name and select Update Splits.
