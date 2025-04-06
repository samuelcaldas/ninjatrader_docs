



SendMail()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\sendmail.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Alert, Debug, Share](alert__debugging_and_sharing-1.htm) >  SendMail() | [Previous page](rearmalert-1.htm) [Return to chapter overview](alert__debugging_and_sharing-1.htm) [Next page](share-1.htm) |

Definition
----------

Sends an email message through the default email sharing service.

|  |
| --- |
| Notes:  1.This method can only be called once the [State](state-1.htm) has reached State.Realtime.  Calls to this method in any other State will be silently ignored (in contrast to the implementation for [AddOns](alert_and_debug_concepts-1.htm))  2.You MUST configure an email account as a default "Mail" Share Service from the [General Options](general_section-1.htm) |

Method Return Value
-------------------

This method does not return a value.

Syntax
------

SendMail(string to, string subject, string text)

 

|  |
| --- |
| Warning:  If mail is not received, please check the [Log](log_tab2-1.htm) tab of the control center for any specific errors which could be related to delivering the message. |

Parameters
----------

|  |  |
| --- | --- |
| to | The email recipient |
| subject | Subject line of email |
| text | Message body of email |

Examples
--------

| ns |
| --- |
| // Generates an email message  SendMail("[[email protected]](/cdn-cgi/l/email-protection)", "Trade Alert", "Buy ES"); |