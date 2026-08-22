# SendMail()

## Definition

Sends an email message through the default email sharing service.

> **Notes:** 1.This method can only be called once the [State](state.md) has reached State.Realtime.  Calls to this method in any other State will be silently ignored (in contrast to the implementation for [AddOns](../addons/alert_and_debug_concepts.md))  2.You MUST configure an email account as a default "Mail" Share Service from the [General Options](../getting_started/general_section.md)

## Method Return Value

This method does not return a value.

## Syntax

SendMail(string to, string subject, string text)

 

> **Warning:** If mail is not received, please check the [Log](../operations/log_tab2.md) tab of the control center for any specific errors which could be related to delivering the message.

## Parameters

| Name / Option | Description |
| --- | --- |
| to | The email recipient |
| subject | Subject line of email |
| text | Message body of email |

## Examples

![Ns](../images/ns.png)

```csharp
// Generates an email message
SendMail("[email protected](mailto:platformsupport@ninjatrader.com)", "Trade Alert", "Buy ES");
```