﻿


NinjaScript \> Educational Resources \> Tips \> User Definable Color Inputs






















User Definable Color Inputs







| \<\< [Click to Display Table of Contents](user_definable_color_inputs.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Tips](tips-1.md) \> User Definable Color Inputs | [Previous page](traceorders2-1.md) [Return to chapter overview](tips-1.md) [Next page](using__brackets-1.md) |
| --- | --- |











User definable inputs do not need to be limited to numeric values. You can have brushes as an input as well. To do this you will need to make a public property for a Brush object instead of an int or double.


 


In the "Properties" region of your code, there is only a slight change in the code snippet you would normally use to create user definable inputs.


 




| ns |
| --- |
| \[XmlIgnore()] \[Display(Name \= "BorderBrush", GroupName \= "NinjaScriptParameters", Order \= 0)] |



 


The second difference is in the next line of code:




| ns |
| --- |
| public Brush BorderBrush { get; set; } |



 


This creates a brush input for use in the dialog window when we try to add the NinjaScript to a chart.


 


Some additional extra code that is required for creating a color input is to serialize the brush. Serialization is necessary for NinjaTrader to use the brush input throughout the program. Please note that serialization is a general concept not exclusive to brush inputs. There may be other struct/classes (for a TimeSpan example, please cross reference [this page](ninjascriptpropertyattribute-1.md)) that you could use in your code that would also need to have their "value" properties serialized.




| ns |
| --- |
| \[Browsable(false)] public string BorderBrushSerialize {  get { return Serialize.BrushToString(BorderBrush); }    set { BorderBrush \= Serialize.StringToBrush(value); } } |



 


Attached is a NinjaScript indicator sample that uses two user definable brush inputs to determine the color of a drawn rectangle.


[SampleBrushInput.zip](samples/SampleBrushInput.zip)








