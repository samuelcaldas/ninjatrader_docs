
NinjaScript > Educational Resources > Developing Indicators
Developing Indicators
| << [Click to Display Table of Contents](developing_indicators.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > Developing Indicators | [Previous page](developing_for__tick_replay-1.md) [Return to chapter overview](educational_resources-1.md) [Next page](advanced_-_custom_drawing-1.md) |
| --- | --- |
Indicators are the building blocks of any automated trading system. NinjaScript allows you to develop custom indicators quickly. A few key points are:
 
- Custom indicators are compiled and run natively within the NinjaTrader application, providing the highest performance possible

- Indicator values are calculated at the current bar, which ensures that you do not accidentally include future data in your calculations

- You can retain calculations between bar updates

- You can retain and share calculation values between bar updates and across indicators

 
Custom indicator development follows a logical progression.
 
## Wizard 
The wizard allows you to define your overall indicator parameters which include name, properties, inputs, plots and oscillator lines. The wizard will then generate the necessary NinjaScript code and open up the NinjaScript [Editor](editor-1.md).
 
## OnStateChange() Method
The [OnStateChange()](onstatechange-1.md) method is called once before any initial calculation triggered by an update bar event. This method is used to configure the indicators plots, lines and properties. The wizard will generate the required NinjaScript code for this method for most cases.
 
## OnBarUpdate() Method
The [OnBarUpdate()](onbarupdate-1.md) method is called with either with each incoming tick or on the close of each bar, depending on how you deploy the indicator at run time. Your core indicator calculation logic is contained within this method.
 
## Debug
The NinjaScript Editor will perform both syntax and semantic checks and list any errors at the bottom of the window. If there are logic problems with your indicator, they will be listed in the [Log tab](log_tab2-1.md) of the NinjaScript [Control Center](control_center-1.md) during run time. You can use the [Print()](print-1.md) method within your script to help debug your code. Output will be sent to the NinjaScript Output window.
## 
## Compilation
Once the coding effort is completed, you must then compile the indicator (several second process) directly from the NinjaScript Editor.
 
## Usage
The completed indicator is now available through any window that can use an indicator, such as a [Chart](charts-1.md).
 
## Tutorial Descriptions
All internal NinjaTrader indicators come with full source code and can be viewed within the NinjaScript Editor. Please review the tutorials within this section for detailed walk throughs of custom indicator development.
 
| ›[Level 1](beginner_-_using_price_variabl-1.md) - Demonstrating the use of price variables›[Level 2](beginner_-_indicator_on_indica-1.md) - Demonstrating the use of indicator on indicator›[Level 3](intermediate_-_your_own_sma-1.md) - Demonstrating the use of a "for" loop to build a simple moving average indicator›[Level 4](intermediate_-_historical_cust-1.md) - Demonstrating the use of Indicator Series objects to retain historical custom calculations data series›[Level 5](advanced_-_custom_plot_colors_-1.md) - Demonstrating the use of custom plot coloring based on threshold values›[Level 6](advanced_-_custom_drawing-1.md) - Demonstrating the use of custom of drawing using bar color, back color and line colors |
| --- |

