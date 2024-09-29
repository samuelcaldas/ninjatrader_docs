


NinjaScript \> Language Reference \> Share Service \> OnAuthorizeAccount()






















OnAuthorizeAccount()







| \<\< [Click to Display Table of Contents](onauthorizeaccount.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Share Service](share_service.md) \> OnAuthorizeAccount() | [Previous page](isimageattachmentsupported.md) [Return to chapter overview](share_service.md) [Next page](onshare.md) |
| --- | --- |











## Definition


If the [IsAuthorizationRequired](isauthorizationrequired.md) property is set to true, this method will be called when the user clicks the Connect button in the Share Services dialogue under Tools \-\> [Options](options.md).  When this method is called, it will allow you go through the handshake process for authorizing the account to a sharing service.  For example, you can obtain user tokens for posting on their behalf to social networks using OAuth authentication.   


 


Documentation on the OAuth handshake process can be found from the official OAuth website: <http://oauth.net/code/> 


 


Specific documentation for the authorization process for a particular sharing service can be found on it's public API resources located on their website.  


## 


## Method Return Value


An asynchronous [Task](https://msdn.microsoft.com/en-us/library/system.threading.tasks.task.aspx)


 


## Parameters


This method does not require any parameters


## 


## Syntax


This method is not required to be overridden.  You may override the method in your Share Service with the following syntax if needed:


 


public override async Task OnAuthorizeAccount()  

{  

   

}


 


## Examples




| ns |
| --- |
| public override async Task OnAuthorizeAccount() {    //MyShareServicesToken() is a place holder for an actual API's token method    string result \= await MyShareServicesToken("myToken");        // result is also a place holder    if(result \=\= "APIErrorCode123")    {      Print("Unable to authorize token");      return;    }        // please see the your API's OUATH documenation for proper handshake usage    else Print("Success!"); } |









