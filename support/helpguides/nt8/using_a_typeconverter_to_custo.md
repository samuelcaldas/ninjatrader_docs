
NinjaScript > Educational Resources > Reference Samples > Indicator > Using a TypeConverter to Customize Property Grid Behavior
Using a TypeConverter to Customize Property Grid Behavior

| << [Click to Display Table of Contents](using_a_typeconverter_to_custo.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Educational Resources](educational_resources.md) > [Reference Samples](reference_samples.md) > [Indicator](indicator2.md) > Using a TypeConverter to Customize Property Grid Behavior | [Previous page](using_a_series_or_dataseries_o.md) [Return to chapter overview](indicator2.md) [Next page](using_custom_events_to_output_.md) |
| --- | --- |

The default behavior of the NinjaTrader property grid is designed to handle the most basic display of your custom Indicator and Strategy properties. However, there are special cases where you may want to control how unique properties display to other users. Since using a TypeConverter is more of a general C# concept used to convert values between data types (a string to an enum for example), so the possibilities of what you can do are within the bounds of the .NET Framework. This NinjaScript sample was produced to help NinjaScript developers understand how to leverage the IndicatorBaseConverter and StrategyBaseConverter helper classes to customize property grid behavior without affecting general NinjaTrader property behavior.
 
## Note
- NinjaTrader expects custom properties to be of value type or type which implements ICloneable interface

- This reference sample assumes you are familiar with basic C# TypeConverter practices and is intended as a starting point. There are extensive 3rd party guides available online which can help you implement a particular type converter goal not covered in this sample

 
## Key concepts in this example
There are 5 use cases demonstrated in this sample which fall into two different categories:
 
1. Dynamically manipulate what is displayed on the UI Property Grid
a.Show / hide properties based on secondary input

b.Disable / enable properties based on secondary input

 
2. Customizing how a property is displayed
a.Display "Friendly" enum values

b.Re-implement a "bool" CheckBox as "Friendly" a ComboBox

c.Display a custom collection / list with user defined values at run time

 
## Important related documentation
C#
- [ICloneable Interface](https://msdn.microsoft.com/en-us/library/system.icloneable%28v=vs.110%29.aspx)

- [PropertyDescriptor Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.propertydescriptor%28v=vs.110%29.aspx)

- [RefreshPropertiesAttribute](https://msdn.microsoft.com/en-us/library/system.componentmodel.refreshpropertiesattribute(v=vs.110).aspx)

- [TypeConverter Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.typeconverter%28v=vs.110%29.aspx)

- [DisplayAttribute Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.displayattribute(v=vs.110).aspx)

NinjaTrader
- [IndicatorBaseConverter Class](indicatorbaseconverter.md)

- [StrategyBaseConverter Class](strategybaseconverter.md)

- [TypeConverterAttribute](typeconverterattribute.md)

| Note: The reference sample files on this page are written for an indicator using the IndicatorBaseConverter class, but the same key concepts are available to strategies by replacing the StrategyBaseConverter where noted in the sample code. |
| --- |

## 
## Import instructions
1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

 
## Additional resources
MSDN - How to: [Implement a Type Converter](https://msdn.microsoft.com/en-us/library/ayybcxe5.aspx)
 
[SampleIndicatorTypeConverter_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleIndicatorTypeConverter_NT8.zip)
