


NinjaScript \> Educational Resources \> Reference Samples \> Indicator \> Using custom events to output the current Level II data book






















Using custom events to output the current Level II data book







| \<\< [Click to Display Table of Contents](using_custom_events_to_output_.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Reference Samples](reference_samples-1.md) \> [Indicator](indicator2-1.md) \> Using custom events to output the current Level II data book | [Previous page](using_a_typeconverter_to_custo-1.md) [Return to chapter overview](indicator2-1.md) [Next page](using_streamreader_to_read_fro-1.md) |
| --- | --- |











Custom events allow you the flexibility to access indicator/price information whenever you deem it necessary. You do not need to wait for the next incoming tick or next bar update before you can process some code logic.


## 


## Key concepts in this example


•Creating a custom event from a Timer object

•Printing Level II books whenever you receive a Timer event

 


## Important related documentation


•[List](https://msdn.microsoft.com/en-us/library/6sh2ey19%28v=vs.110%29.aspx)

•[Timer](https://docs.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatchertimer?view=netframework-4.7.2)

•[TriggerCustomEvent()](triggercustomevent-1.md)

•[State.Terminated](dispose-1.md)

•[MarketDepthEventArgs](marketdeptheventargs-1.md)

 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SampleCustomEvents\_NT8\.zip](samples/SampleCustomEvents_NT8.zip)








