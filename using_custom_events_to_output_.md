# Using custom events to output the current Level II data book

Custom events allow you the flexibility to access indicator/price information whenever you deem it necessary. You do not need to wait for the next incoming tick or next bar update before you can process some code logic.

## Key concepts in this example

- Creating a custom event from a Timer object

- Printing Level II books whenever you receive a Timer event

## Important related documentation

- [List](https://msdn.microsoft.com/en-us/library/6sh2ey19%28v=vs.110%29.aspx)

- [Timer](https://docs.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatchertimer?view=netframework-4.7.2)

- [TriggerCustomEvent()](triggercustomevent.md)

- [State.Terminated](dispose.md)

- [MarketDepthEventArgs](marketdeptheventargs.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleCustomEvents\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleCustomEvents_NT8.zip)
