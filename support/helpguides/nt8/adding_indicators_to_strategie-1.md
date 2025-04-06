



Adding Indicators to Strategies

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\adding_indicators_to_strategie.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Tips](tips-1.md) >  Adding Indicators to Strategies | [Previous page](tips-1.md) [Return to chapter overview](tips-1.md) [Next page](checking_for_null_references-1.md) |

When backtesting strategies it can be useful to add the indicators you use for calculations onto the chart to make it easier to check your strategy for accuracy. Instead of doing this step manually every time you run the strategy you can program it to automatically load the indicators for you.

For example:

To add a volume indicator to your charts you need to add this code snippet into the [OnStateChange](onstatechange-1.md) section of your code for the State: State.DataLoaded

|  |
| --- |
| OnStateChange()  {  State.DataLoaded)  {  AddChartIndicator(VOL());  }  } |

To choose which panel you want your indicator plotted on you can use this code snippet into the State.DataLoaded state:

|  |
| --- |
| VOL().Panel;  AddChartIndicator(VOL()); |

To customize plot colors:

|  |
| --- |
| VOL().Plots[// Plots the VOL with a red plot |

To customize plot width:

|  |
| --- |
| VOL().Plots[// Plots the VOL bars with a width of 4 |

To customize the plot dash style:

|  |
| --- |
| VOL().Plots[DashStyleHelper.Dash; |

To customize the plot style:

|  |
| --- |
| VOL().Plots[PlotStyle.Bar;  VOL().Plots[true; |

To customize lines you can do it the same way as above.

|  |
| --- |
| RSI(;  RSI(Brushes.Green; |

Remember, you need to use the [AddChartIndicator()](addchartindicator-1.md) method to add your indicator if you wish to use any of the plot / line indicator customization examples.