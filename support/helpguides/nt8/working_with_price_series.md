


NinjaScript \> Educational Resources \> Working with Price Series






















Working with Price Series







| \<\< [Click to Display Table of Contents](working_with_price_series.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> Working with Price Series | [Previous page](working_with_pixel_coordinates.md) [Return to chapter overview](educational_resources.md) [Next page](reference_samples.md) |
| --- | --- |











## Price Data Overview


The core objective of developing custom Indicators and Strategies with NinjaScript is to evaluate price data. NinjaScript allows you to reference current and historical price data. There are several categories of price data which include ISeries\<T\>, Indicator and Custom Historical Series.


 


## Definitions




| [ISeries\<T\>](priceseries.md) | Standard bar based price types such as closing, opening, high, low prices and volume |
| --- | --- |
| [Indicator](indicator.md) | Calculated values based on price type values such as a simple moving average |
| Custom Historical [Series\<T\>](seriest.md) | Custom calculated values that you wish to store and associate to each historical bar |



 


 


## Referencing Series




| ISeries\<T\> | Syntax | Editor Shortcut | Definition |
| --- | --- | --- | --- |
| Close | Close\[int barsAgo] | "c" \+ Tab Key | Last traded price of a bar |
| Open | Open\[int barsAgo] | "o" \+ Tab Key | Opening price of a bar |
| High | High\[int barsAgo] | "h" \+ Tab Key | Highest traded price of a bar |
| Low | Low\[int barsAgo] | "l" \+ Tab Key | Lowest traded price of a bar |
| Volume | Volume\[int barsAgo] | "v" \+ Tab Key | Number of shares/contracts traded of a bar |
| Input | Input\[int barsAgo] | "i" \+ Tab Key | Default price type of a bar |



 


You will notice that to reference any price data you need to include a value for \[int barsAgo]. This is a very simple concept; barsAgo represents the number of bars ago to reference and int indicates that barsAgo is an integer value. As an example, we could write a statement to check if the the high price of 1 bar ago is less than the high price of the current bar like this:


 


 High\[1] \< High\[0];


 


You could write a statement to calculate the average closing price of the last three bars like this:


 


 ( Close\[2] \+ Close\[1] \+ Close\[0] ) / 3;


 


As you may have already figured out, referencing the current bar data is accomplished by passing in a value of 0 (zero) to the barsAgo parameter. Basically, we are saying show me the price data of zero bars ago, which means the current bar.  

 




| Note:  In most cases, you will access the historical price series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical price series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, and may result in errors when trying to obtain this information.  In those cases, please use the Bars.Get...() methods with the absolute bar index (e.g., [Bars.GetClose(](getclose.md)), [Bars.GetTime()](gettime.md), etc.) |
| --- |



 


 


## Referencing Indicator Data
NinjaScript includes a library of built in indicators that you can access. Please see the [Indicator Methods](indicators.md) reference section for clear definitions for how to access each indicator.


   

All indicator values can be accessed in the following way:


 


 indicator(parameters)\[int barsAgo]


 


where indicator is the name of the indicator you want to access, parameters is any associated parameters the indicator requires and barsAgo is the number of bars we wish to offset from the current bar.


 


As an example, we could write a statement to check if the current closing price is greater than the 20 period simple moving average like this:


 


 Close\[0] \> SMA(20)\[0];


 


If you wanted to perform the same check but only check against a 20 period simple moving average of high prices you would write it like this:


 


 Close\[0] \> SMA(High, 20)\[0];


 


You could write a statement to see if a 14 period CCI indicator is rising like this:


 


 CCI(14)\[0] \> CCI(14)\[1];


   

Value of a 10 period CCI 1 bar ago \= CCI(10\)\[1]


 


Please review the [Indicator Methods](indicators.md) section for proper syntax for accessing different indicator values.








