
NinjaScript > Educational Resources > Developing Indicators > Intermediate - Your own SMA > Entering Calculation Logic

Entering Calculation Logic
| << [Click to Display Table of Contents](entering_calculation_logic3.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Developing Indicators](developing_indicators-1.md) > [Intermediate - Your own SMA](intermediate_-_your_own_sma-1.md) > Entering Calculation Logic | [Previous page](set_up6-1.md) [Return to chapter overview](intermediate_-_your_own_sma-1.md) [Next page](compiling3-1.md) |
| --- | --- |
The [OnBarUpdate()](onbarupdate-1.md) method is called for each incoming tick, or on the close of a bar (if enabled) when performing real-time calculations, and is called on each bar of a [Bars](bars-1.md) object when re-calculating the indicator (For example, an indicator would be re-calculated when adding it to an existing chart that has existing price data displayed).. Therefore, this is the main method called for indicator calculation and we will use this method to enter the script that will calculate a simple moving average.
 
## Are there enough bars?
Enter the following code into the OnBarUpdate() method in the NinjaScript Editor:
 
| ns |
| --- |
| // Do not calculate if we don't have enough bars  if (CurrentBar < Period) return; |

 
To calculate a 20 period moving average you will need a minimum of 20 bars of data. The first statement in our OnBarUpdate() method checks to see if there are enough bars of data to perform the moving average calculation. "CurrentBar" returns the index number of the current bar and this is checked against the user defined parameter "Period". If the current bar number is less than the user defined period we "return" which skips calculating the moving average.
 
## Getting a sum of closing prices
Enter the following code into the OnBarUpdate() method and below the code snippet you entered above:
 
| ns |
| --- |
| // Get a sum of prices over the specified period double sum = 0;  for (int barsAgo = 0; barsAgo < Period; barsAgo++)  {     sum = sum + Input[barsAgo];  } |

   

First we must declare a variable that will store our sum total.
 
| ns |
| --- |
| double sum = 0; |

 
The variable "sum" whose value is of type "double" will serve as temporary storage.
 
| ns |
| --- |
| for (int barsAgo = 0; barsAgo < Period; barsAgo++)  {     sum = sum + Input[barsAgo];  } |

 
Next we must calculate the sum. We use a standard "for" loop to skip through prices and add them to the "sum" variable. Although the command that represents the loop may look intimidating, its really quite simple. Let's look at it in English....
 
What the loop is saying is:
 
1. the number of bars ago is now zero
2. as long as the number of bars ago is less than the moving average period, then go to line 3 otherwise this loop is finished
3. get the price Input[number of bars ago] and add it to the running sum total
4. add one to the number of bars ago (if number of bars ago was zero it will now be one)
5. go to to line 2
 
You can find more information on [how loops work here](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements). Once the loop has finished, it will have calculated the total sum of closing prices for the period of our moving average.
 
* We use the value of Input[barsAgo] to get a price to use for our calculation. We could have substituted Close[barsAgo] to use closing prices or High[barsAgo] to use high prices. The reason we use Input[barsAgo] is since this allows flexibility for what the indicator is calculated based off of. Remember users have the option to select a price type (High, Open, Close etc...) from the Indicator Dialog window.
 
## The final calculation
Enter the following code into the OnBarUpdate() method and below the code snippet you entered above:
 
| ns |
| --- |
| // Calculate and set the average value to the 'MyPlot' property MyPlot[0] = sum / Period; |

 
We can now calculate the final moving average value and assign it's value to the property that represents the plot data. We have just finished coding our simple moving average. The class code in your editor should look identical to the image below. You are now ready to [compile the indicator](compiling3-1.md) and configure it on a chart.
 
| ns |
| --- |
| public class MySMA : Indicator {    protected override void OnStateChange()    {      if (State == State.SetDefaults)      {          Description                           = @"Simple Moving Average";          Name                                 = "MySMA";          Calculate                             = Calculate.OnBarClose;          IsOverlay                             = true;          DisplayInDataBox                     = true;          DrawOnPricePanel                     = true;          DrawHorizontalGridLines               = true;          DrawVerticalGridLines                 = true;          PaintPriceMarkers                     = true;          ScaleJustification                   = NinjaTrader.Gui.Chart.ScaleJustification.Right;          //Disable this property if your indicator requires custom values that cumulate with each new market data event.           //See Help Guide for additional information.          IsSuspendedWhileInactive             = true;          Period                               = 20;          AddPlot(Brushes.Orange, "MyPlot");      }      else if (State == State.Configure)      {      }    }      protected override void OnBarUpdate()    {      // Do not calculate if we don't have enough bars       if (CurrentBar < Period) return;             // Get a sum of prices over the specified period      double sum = 0;       for (int barsAgo = 0; barsAgo < Period; barsAgo++)       {           sum = sum + Input[barsAgo];       }             // Calculate and set the average value to the 'MyPlot' property      MyPlot[0] = sum / Period;    }      #region Properties    [NinjaScriptProperty]    [Range(1, int.MaxValue)]    [Display(Name="Period", Description="Number of Periods", Order=1, GroupName="Parameters")]    public int Period    { get; set; }      [Browsable(false)]    [XmlIgnore]    public Series<double> MyPlot    {      get { return Values[0]; }    }    #endregion   } |

 
## Alternate Implementation
In this tutorial we are using a "for" loop to iterate through a collection of prices and accumulate a sum value. We chose this approach to demonstrate the use of a loop. A simple moving average can actually be expressed in a more efficient manner using the built in [SUM](summation_sum-1.md) indicator as show below.
 
| ns |
| --- |
| // Do not calculate if we don't have enough bars if (CurrentBar < Period) return;   // Calculate and set the 'average' value to the 'MyPlot' property MyPlot[0] = SUM(Input, Period)[0] / Period; |

 
