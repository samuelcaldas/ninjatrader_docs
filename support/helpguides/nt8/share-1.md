
NinjaScript > Language Reference > Common > Alert, Debug, Share > Share()

Share()

| << [Click to Display Table of Contents](share.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Alert, Debug, Share](alert__debugging_and_sharing-1.md) > Share() | [Previous page](sendmail-1.md) [Return to chapter overview](alert__debugging_and_sharing-1.md) [Next page](market_data-1.md) |
| --- | --- |
## Definition
Sends a message or screen shot to a social network or Share Service.  
 

| Notes:   1.This method can only be called once the [State](state-1.md) has reached State.Realtime.  Calls to this method in any other State will be silently ignored.2.You MUST configure an account with a Share Service provider from the [General Options](general_section-1.md) |
| --- |

## Method Return Value
This method does not return a value.
## 
## Syntax
Share(string serviceName, string message)  

Share(string serviceName, string message, object[] args)  

Share(string serviceName, string message, string screenshotPath)  

Share(string serviceName, string message, string screenshotPath, object[] args)
 
## Parameters

| serviceName | A string value representing the share service to be used |
| --- | --- |
| message | A string value representing the text body sent to the social network or other Share providers. Note:  The message is what appears in the text box of the Share window |
| screenshotPath | Optional string path to screenshot or other images sent to the social network or other Share providers |
| args | A generic object[]  array used to designate additional information sent to the share service |

| Tips: 1.The "args" parameter differs for each share service used.  If you are using a custom developed share adapter, you need to work with the developer of that adapter to understand what the "args" parameter represents for that adapter.2.For the default NinjaTrader share adapters, the "args" array represents the following:  ▪Mail share service:- args[0] = A string representing the email "To" field,- args[1] = A string representing the email "Subject" field  ▪StockTwits share service: - args[0] = An enum representing the "StockTwitsSentiment" parameter |
| --- |

## Examples

| ns |
| --- |
| // using "args" as the Mail "To" and "Subject" parameters Share("Gmail", "Test Message", new object[]{ "[[email protected]](/cdn-cgi/l/email-protection)", "Test Subject Line" }); |
