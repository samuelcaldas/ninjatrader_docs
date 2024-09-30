
NinjaScript > Language Reference > Add On > Alert and Debug Concepts
Alert and Debug Concepts
| << [Click to Display Table of Contents](alert_and_debug_concepts.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > Alert and Debug Concepts | [Previous page](nttabpage_save.md) [Return to chapter overview](add_on.md) [Next page](alertcallback.md) |
| --- | --- |
In most scenarios you can use the NinjaScript provided methods for triggering alerts and debugging functionality. However, when building your own custom objects, you may find yourself wanting to use this functionality outside the NinjaScript scope (e.g. when building a [NTTabPage](nttabpage_class.md) for Add Ons).
 
## Using the NinjaScript Output
Instead of [Print()](print.md), use Output.Process() to write a message.
Instead of [ClearOutputWindow()](clearoutputwindow.md), use Output.Reset() to clear the output window.
 
## Example
| ns |
| --- |
| // Instead of Print() NinjaTrader.Code.Output.Process("my message", PrintTo.OutputTab1);   // Instead of ClearOutputWindow() NinjaTrader.Code.Output.Reset() |

## Using Alerts
Instead of [Alert()](alert.md), use [NinjaTrader.NinjaScript.Alert.AlertCallback()](alertcallback.md) for sending an alert.
Instead of [ResetAlert()](rearmalert.md), use [NinjaTrader.NinjaScript.Alert.RearmAlert()](alert.md)
 
## Example
| ns |
| --- |
| // Instead of Alert() NinjaTrader.NinjaScript.Alert.AlertCallback(NinjaTrader.Cbi.Instrument.GetInstrument("MSFT"), this, "someId", NinjaTrader.Core.Globals.Now, Priority.High, "message", null, Brushes.Blue, Brushes.White, 0);   // Instead of ResetAlert() NinjaTrader.NinjaScript.Alert.ResetAlert("someId"); |

## Miscellaneous
Instead of [Log()](log.md), use NinjaScript.Log() to send a message to the NinjaTrader logs.
Instead of [PlaySound()](playsound.md), use Globals.PlaySound() to play a sound.
Instead of [SendMail()](sendmail.md), use Globals.SendMail() to send a mail.
 
| Tip: Both the Globals.PlaySound() and .SendMail() above could be used in a regular NinjaScript objects as well, however this is not recommended practice since those would not ignore the calls outside State.Realtime which could yield unexpected results. |
| --- |

## Examples
| ns |
| --- |
| // Instead of Log() NinjaScript.Log("My log message", LogLevel.Error);   // Instead of PlaySound() NinjaTrader.Core.Globals.PlaySound(@"C:\\mySound.wav");   // Instead of SendMail() NinjaTrader.Core.Globals.SendMail("[[email protected]](/cdn-cgi/l/email-protection)", "[[email protected]](/cdn-cgi/l/email-protection)", "Subject", "Mail body", null); |

## Error Codes in Log Files
The ErrorCode enumeration can be found in NinjaTrader logs from time to time when an error occurs, and these can provide further clues into the cause of unexpected behavior during your debugging. These error codes are not necessarily related to your code, but they can provide an indication of an issue to address outside of the scope of your code, saving you time in trying to find the source of errors in your code. Below is a list of ErrorCode enum values and their meanings:
 
| NoError | No errors were thrown |
| --- | --- |
| LogOnFailed | Failed to log on due to invalid credentials |
| OrderRejected | Broker rejected the current order |
| UnableToCancelOrder | Order cannot be canceled now, but may be successfully canceled later |
| UnableToChangeOrder | Either the exchange or broker does not support order updates for the instrument in question, or the order has not yet been submitted |
| UserAbort | The operation was aborted by the user |
| Panic | An unspecified error was thrown |
