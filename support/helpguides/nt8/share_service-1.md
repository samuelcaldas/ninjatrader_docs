
NinjaScript > Language Reference > Share Service

Share Service

| << [Click to Display Table of Contents](share_service.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > Share Service | [Previous page](performancemetric_values-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](characterlimit-1.md) |
| --- | --- |
Custom Share Services can be developed in order to enable users to share content from the NinjaTrader application to various websites and social media networks via the [Sharing Services](sharing_content-1.md) dialog. NinjaTrader comes pre-configured with Share Services for an Email adapter and Test message via email adapter, however a custom adapter can be developed for any website, forum, or social media network by following their public API documentation and guidelines.  
 
## In this section

| [CharacterLimit](characterlimit-1.md) | Determines the maximum number of characters the social network allows. |
| --- | --- |
| [CharactersReservedPerMedia](charactersreservedpermedia-1.md) | Sets the number of characters allowed when attaching an image to ensure that character count is properly calculated. |
| [Icon](icon-1.md) | The shape which displays within the Share window when sharing content. |
| [UseOAuth](isauthorizationrequired-1.md) | If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount-1.md) when the user clicks it. |
| [IsConfigured](isconfigured-1.md) | Sets when the Share Service is correctly configured. |
| [IsDefault](isdefault-1.md) | Sets the default Share Service used when the type of sharing service is selected (email for example). |
| [IsImageAttachmentSupported](isimageattachmentsupported-1.md) | Determines if the Share Service will allow for images as attachments. |
| [OnAuthorizeAccount()](onauthorizeaccount-1.md) | If the [UseOAuth](isauthorizationrequired-1.md) property is set to true, this method will be called when the user clicks the Connect button in the Share Services dialogue under Tools -> [Options](options-1.md). |
| [OnShare()](onshare-1.md) | This method is called when the user clicks OK on the Share window in NinjaTrader. This method can also be called by Alerts and general NinjaScript objects. |
| [Signature](signature-1.md) | Sets the text appended to the end of the user's message. |
