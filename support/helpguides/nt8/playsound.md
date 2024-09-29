


NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> PlaySound()






















PlaySound()







| \<\< [Click to Display Table of Contents](playsound.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Alert, Debug, Share](alert__debugging_and_sharing.md) \> PlaySound() | [Previous page](log.md) [Return to chapter overview](alert__debugging_and_sharing.md) [Next page](print.md) |
| --- | --- |











## Definition


Plays a .wav file while running on real\-time data. 


 




| Notes:   1\. This method will only execute once the [State](state.md) has reached State.Realtime.  Calls to this method during State.Historical will be ignored (in contrast to the implementation for [AddOns](alert_and_debug_concepts.md))2\.The default behavior is to play the .wav file in an asynchronous manner, which can result in calls to PlaySound() to play over one another.  Sound files can optionally be configured to execute in a synchronous manner by enabling the Tools \> Options \> Sounds \> "Play consecutively" property |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax


PlaySound(string fileName)


 




| Warning:  The underlying framework used to play the sound requires the audio file to be in PCM .wav format.  Using another file format such as will generate an error at runtime. |
| --- |



 


 


## Parameters




| fileName | The absolute file path of the .wav file to play |
| --- | --- |



 


 




| Tip: You can obtain the default NinjaTrader installation directory to access the sounds folder by using NinjaTrader.Core.Globals.InstallDir property.  Please see the example below for usage. |
| --- |



 


 


## Examples




| ns |
| --- |
| // Plays the wav file mySound.wav PlaySound(@"C:\\mySound.wav");   // Plays the default Alert1 sound that comes packaged with NinjaTrader PlaySound(NinjaTrader.Core.Globals.InstallDir \+ @"\\sounds\\Alert1\.wav"); |









