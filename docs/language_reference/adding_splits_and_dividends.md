# Adding Splits and Dividends

You can automatically update an instrument with historical split adjustment data from within the Instrument window. You can choose to update split information from the following connections:

1. IQFeed

2. Kinetick (you must have a subscription - the free Kinetick EOD does NOT provide splits and dividend information)

## Adding Splits via the instruments window

To automatically update an instrument with historical split data follow the steps below. If you have already defined one of the connections above then you may skip step 1.

NinjaTrader will now request historical splits information from your provider and populate the information in your local database.

> **Notes:** The Update Splits menu item is only enabled when you are connected to one of the providers mentioned above.  At this time, no supported connections provider dividends. Dividends must be manually added.

## Adding Splits for a predefined instrument list

You can perform the same steps above on a predefined instrument list by going to the NinjaTrader Update Splits.