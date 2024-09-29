


NinjaScript \> Educational Resources \> Tips \> Parameter sequencing






















Parameter sequencing







| \<\< [Click to Display Table of Contents](parameter_sequencing.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Tips](tips-1.md) \> Parameter sequencing | [Previous page](order_types-1.md) [Return to chapter overview](tips-1.md) [Next page](referencing_the_correct_bar-1.md) |
| --- | --- |











Indicator and strategy parameters (user defined inputs) will always be displayed in an order that the user specifies in the NinjaScript file.


 


In the NinjaScript Editor, expand the "Properties" region of your code where all of your parameters are defined. In this example, this will be our Properties section:




| ns |
| --- |
| \[Range(1, int.MaxValue), NinjaScriptProperty] \[Display(ResourceType \= typeof(Custom.Resource), Name \= "Fast", GroupName \= "NinjaScriptStrategyParameters", Order \= 0)] public int Fast { get; set; } \[Range(1, int.MaxValue), NinjaScriptProperty] \[Display(ResourceType \= typeof(Custom.Resource), Name \= "Slow", GroupName \= "NinjaScriptStrategyParameters", Order \= 1)] public int Slow { get; set; } |



 


In this case, the Fast parameter will show up as the first parameter with the Slow parameter showing as the second.


 


To switch the order around, we could modify Order. If we change Slow's Order to 0 and Fast's Order to 1 as shown below ...




| ns |
| --- |
| \[Range(1, int.MaxValue), NinjaScriptProperty] \[Display(ResourceType \= typeof(Custom.Resource), Name \= "Fast", GroupName \= "NinjaScriptStrategyParameters", Order \= 1)] public int Fast { get; set; } \[Range(1, int.MaxValue), NinjaScriptProperty] \[Display(ResourceType \= typeof(Custom.Resource), Name \= "Slow", GroupName \= "NinjaScriptStrategyParameters", Order \= 0)] public int Slow { get; set; } |



 


... the Slow property will show first and the Fast property second.








