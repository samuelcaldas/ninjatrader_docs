
NinjaScript > Educational Resources > Reference Samples > Indicator > Using a Series or DataSeries object to store calculations
Using a Series or DataSeries object to store calculations
| << [Click to Display Table of Contents](using_a_series_or_dataseries_o.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Educational Resources](educational_resources.md) > [Reference Samples](reference_samples.md) > [Indicator](indicator2.md) > Using a Series or DataSeries object to store calculations | [Previous page](using_a_secondary_series_as_an.md) [Return to chapter overview](indicator2.md) [Next page](using_a_typeconverter_to_custo.md) |
| --- | --- |
When creating Indicators or Strategies you may find that you need to store values in a way that is similar to the way price data is stored in NinjaTrader.
 
Series<T> objects are useful for storing various types of values.
 
Since they are linked to your historical bars object, you can store and link a value to each bar. This allows you the flexibility of accessing the values at any point in the future for further calculations or plotting.

## Key concepts in this example
- Creating objects that store data

- Storing and retrieving values from these objects

 
## Important related documentation
- [Series<T>](seriest.md)

## 
## Import instructions
1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

 
[SampleCustomSeries_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleCustomSeries_NT8.zip)
