# Resetting values at the beginning of new trading sessions

Normally calculated values are carried over between trading sessions, but sometimes you may want to reset these values to begin a trading session fresh. The technique demonstrated in this reference sample can be useful to do things like resetting counters you may be running or clearing bool flags you may have set.

## Key concepts in this example

- Resetting a variable at the beginning of a new trading session

- Limiting the number of trades a strategy can make per trading session

## Important related documentation

- [IsFirstBarOfSession](../language_reference/isfirstbarofsession.md)

- [IsFirstTickOfBar](../language_reference/isfirsttickofbar.md)

- [EnterLong()](enterlong.md)

- [ExitLong()](exitlong.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

<https://ninjatrader.com/support/helpGuides/nt8/samples/SampleTradeLimiter_NT8.zip>