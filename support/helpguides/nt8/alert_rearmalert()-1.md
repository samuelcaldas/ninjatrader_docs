



RearmAlert()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\alert_rearmalert().htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Alert and Debug Concepts](alert_and_debug_concepts-1.htm) >  RearmAlert() | [Previous page](alertcallback-1.htm) [Return to chapter overview](alert_and_debug_concepts-1.htm) [Next page](atmstrategy-1.htm) |

Definition
----------

Rearms an existing alert event by the string "id" parameter created via the [AlertCallback()](alertcallback-1.htm) method.  A NinjaScript generated alert by may need to be rearmed after the alert is triggered depending on the Alert()'s rearmSeconds parameter.

|  |
| --- |
| Note:  The NinjaScriptBase has a non-static method implemented with the same name.  Please see the [RearmAlert()](rearmalert-1.htm) method for Indicator or Strategies. |

Method Return Value
-------------------

This method does not return a value.

Syntax
------

NinjaTrader.NinjaScript.Alert.RearmAlert(string id)

 

Parameters
----------

|  |  |
| --- | --- |
| id | A unique string id representing an alert id to reset |

Examples
--------

| ns |
| --- |
| if (resetCondition)   {     NinjaTrader.NinjaScript.Alert.ResetAlertRearmById("someId");     resetCondition = false;  } |