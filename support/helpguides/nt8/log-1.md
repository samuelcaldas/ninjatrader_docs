
NinjaScript \> Language Reference \> Common \> Alert, Debug, Share \> Log()

Log()

| \<\< [Click to Display Table of Contents](log.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Alert, Debug, Share](alert__debugging_and_sharing-1.md) \> Log() | [Previous page](clearoutputwindow-1.md) [Return to chapter overview](alert__debugging_and_sharing-1.md) [Next page](playsound-1.md) |
| --- | --- |
## Definition
Generates a NinjaScript category log event record and associated time stamp which is output to the [Log](log_tab2-1.md) tab of the NinjaTrader Control Center / Account Data windows. The Log() method also writes records to the NinjaTrader log file which can be useful for supporting 3rd party code.  
 

| Notes:   1\.Log events do NOT process to the NinjaScript output window.  For temporary logging, please see the [Print()](print-1.md) method and [Output window](output-1.md).  2\.The Log event time stamp represents the user configured Time zone from the Tools \> Options \> General category.  This setting could be different from the computer system's time zone. |
| --- |

## Method Return Value
This method does not return a value.
 
## Syntax
Log(string message, LogLevel logLevel)
 

| Warning:  Each call to this method creates a log entry which takes memory to keep loaded in the Log tab of the Control Center. Excessive logging can result in huge portions of memory being allocated to display the log messages. Please see the NinjaScript section of the [Performance Tips](performance_tips2-1.md) article for more information. |
| --- |

## Parameters

| message | A string value representing the message to be logged |
| --- | --- |
| logLevel | Sets the message level for the log event.  Different levels are color coded in the NinjaTrader log.   - LogLevel.Alert (also generates a pop\-up notification window with log message)- LogLevel.Error- LogLevel.Information- LogLevel.Warning |
 
## 
## Examples

| ns |
| --- |
| // Generates a log message Log("This is a log message", LogLevel.Information);   // Generates a log message with a notification window Log("This will generate a pop\-up notification window as well", LogLevel.Alert); |
