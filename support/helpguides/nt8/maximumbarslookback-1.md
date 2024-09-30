
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> MaximumBarsLookBack

MaximumBarsLookBack

| \<\< [Click to Display Table of Contents](maximumbarslookback.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> MaximumBarsLookBack | [Previous page](isvaliddatapointat-1.md) [Return to chapter overview](iseriest-1.md) [Next page](onbarupdate-1.md) |
| --- | --- |
## Definition
Determines memory performance of custom [Series\<T\>](seriest-1.md) objects (such as Series\<double\>, Series\<long\>, etc.).  When using MaximumBarsLookBack.TwoHundredFiftySix, only the last 256 values of the series object will be stored in memory and be accessible for reference. This results in significant memory savings when using multiple series objects. In the rare case should you need older values you can use MaximumBarsLookBack.Infinite to allow full access of the series.
 

| Notes:   - ISeries\<T\> objects that hold bar data (such as Close, High, Volume, Time, etc) always use MaximumBarsLookBack.Infinite which ensures all data points are always accessible during the lifetime of your NinjaScript indicator or strategy.- Series\<double\> objects that hold indicator [plot values](values-1.md) always use MaximumBarsLookBack.Infinite which ensures that charts always display the entire indicator's calculated values. |
| --- |
## 
## 
## Property Value
A MaximumBarsLookBack enum value. Default value is MaximumBarsLookBack.TwoHundredFiftySix
 
 Possible values are:

| MaximumBarsLookBack.TwoHundredFiftySix | Only the last 256 values of the series object will be stored in memory and accessible for reference (improves memory performance) |
| --- | --- |
| MaximumBarsLookBack.Infinite | Allow full access of the series, but you will then not be able to utilize the benefits of memory optimization |

| Tip:  A MaximumBarsLookBack.TwoHundredFiftySix series works as a circular ring buffer, which will "loop" when the series reaches full capacity.  Specifically, once there are 256 entries in the series, new data added to the series overwrite the oldest data. |
| --- |

## Syntax
MaximumBarsLookBack
 
## Examples

| ns Setting all custom series to use the default MaximumBarsLookBack |
| --- |
| Series\<double\> myDoubleSeries \= null; Series\<string\> myStringSeries \= null;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name \= "Example Indicator";      // Store all series values instead of only the last 256 values      MaximumBarsLookBack \= MaximumBarsLookBack.Infinite;    }    else if (State \=\= State.DataLoaded)    {      // The custom Series\<t\> below are all constructed using only the NinjaScriptBase object (i.e., "this")      // therefore, the Series\<T\> MaximumBarsLookBack is taken from the NinjaScript's configured MaximumBarsLookBack property      myDoubleSeries \= new Series\<double\>(this);      myStringSeries \= new Series\<string\>(this);    } } |

| ns Optimizing custom series to use unique MaximumBarsLookBack behavior |
| --- |
| Series\<double\> myDoubleSeries \= null; Series\<string\> myStringSeries \= null;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name \= "Example Indicator";    }    else if (State \=\= State.DataLoaded)    {      // The custom Series\<t\> below are constructed using MaximumBarsLookBack parameter      // therefore, each Series\<t\> will use their uniquely specified MaximumBarsLookBack properites      myDoubleSeries \= new Series\<double\>(this, MaximumBarsLookBack.Infinite); // stores all values      myStringSeries \= new Series\<string\>(this, MaximumBarsLookBack.TwoHundredFiftySix); // only the last 256 values (better performance)    } } |
