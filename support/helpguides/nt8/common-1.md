
NinjaScript > Language Reference > Common
Common
| << [Click to Display Table of Contents](common.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > Common | [Previous page](alphabetical_reference-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](adddataseries-1.md) |
| --- | --- |
The following section documents methods and properties available to every NinjaScript type that access various forms of data including bar data, price data, and statistical forms of data. The Common section is broken into several categories pertaining to distinct NinjaScript objects or concepts. An index of topics under the Common section can be found below:
 
| [Attributes](attributes-1.md) | Documents both .NET native and NinjaScript custom [attributes](https://msdn.microsoft.com/en-us/library/5x6cd29c(v=vs.110).aspx) which are commonly used to define the behavior of a NinjaScript property or object |
| --- | --- |
| [Alert, Debug, Share](alert__debugging_and_sharing-1.md) | Documents methods for triggering alerts, printing debug messages, and using Share Services |
| [Analytical](market_data-1.md) | Documents methods and properties useful for analyzing and identifying specific conditions within [Series<T>](seriest-1.md) collections |
| [Bars](bars-1.md) | Represents the data returned from the historical data repository |
| [Charts](chart-1.md) | Covers information related to accessing chart related data |
| [Drawing](drawing-1.md) | Documents the drawing of custom shapes, lines, text and colors on your price and indicator panels from both [Indicators](indicator-1.md) and [Strategies](strategy-1.md) |
| [Instrument](instrument-1.md) | Represents an instance of a [Master Instrument](masterinstrument-1.md) |
| [ISeries<T>](iseriest-1.md) | Documents the interface that is implemented by all NinjaScript classes that manage historical data as an ISeries<double> used for indicator input, and other object data |
| [OnBarUpdate()](onbarupdate-1.md) | An event driven method which is called whenever a bar is updated |
| [OnFundamentalData()](onfundamentaldata-1.md) | An event driven method which is called for every change in fundamental data |
| [OnMarketDepth()](onmarketdepth-1.md) | An event driven method which is called and guaranteed to be in the correct sequence for every change in level two market data |
| [OnStateChange()](onstatechange-1.md) | An event driven method which is called whenever the script enters a new [State](state-1.md) |
| [SessionIterator](sessioniterator-1.md) | An interface which allows you to traverse through various trading hours data elements which apply to a segment of bars |
| [System Indicator Methods](indicators-1.md) | Documents syntax and return values for system indicator methods |
| [TradingHours](tradinghours-1.md) | Represents the Trading Hours information returned from the current bars series |
| [Name](name-1.md) | Determines the listed name of the NinjaScript object |
| [IsVisible](isvisible-1.md) | Determines if the current NinjaScript object should be visible on the chart |
| [DisplayName](indicator_displayname-1.md) | Determines the text display on the chart panel |
| [Description](description-1.md) | Text which is used on the UI's information box to be display to a user when configuration a NinjaScript object |
| [Clone()](clone-1.md) | Used to override the default NinjaScript Clone() method which is called any time an instance of a NinjaScript object is created |
| [TriggerCustomEvent()](triggercustomevent-1.md) | Provides a way to use your own custom events (such as a Timer object) so that internal NinjaScript indexes and pointers are correctly set prior to processing user code triggered by your custom event |

