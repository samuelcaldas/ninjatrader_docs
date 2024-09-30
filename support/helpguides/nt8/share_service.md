
NinjaScript > Language Reference > Share Service

Share Service

| << [Click to Display Table of Contents](share_service.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > Share Service | [Previous page](performancemetric_values.md) [Return to chapter overview](language_reference_wip.md) [Next page](characterlimit.md) |
| --- | --- |
Custom Share Services can be developed in order to enable users to share content from the NinjaTrader application to various websites and social media networks via the [Sharing Services](sharing_content.md) dialog. NinjaTrader comes pre-configured with Share Services for an Email adapter and Test message via email adapter, however a custom adapter can be developed for any website, forum, or social media network by following their public API documentation and guidelines.  
 
## In this section

| [CharacterLimit](characterlimit.md) | Determines the maximum number of characters the social network allows. |
| --- | --- |
| [CharactersReservedPerMedia](charactersreservedpermedia.md) | Sets the number of characters allowed when attaching an image to ensure that character count is properly calculated. |
| [Icon](icon.md) | The shape which displays within the Share window when sharing content. |
| [UseOAuth](isauthorizationrequired.md) | If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount.md) when the user clicks it. |
| [IsConfigured](isconfigured.md) | Sets when the Share Service is correctly configured. |
| [IsDefault](isdefault.md) | Sets the default Share Service used when the type of sharing service is selected (email for example). |
| [IsImageAttachmentSupported](isimageattachmentsupported.md) | Determines if the Share Service will allow for images as attachments. |
| [OnAuthorizeAccount()](onauthorizeaccount.md) | If the [UseOAuth](isauthorizationrequired.md) property is set to true, this method will be called when the user clicks the Connect button in the Share Services dialogue under Tools -> [Options](options.md). |
| [OnShare()](onshare.md) | This method is called when the user clicks OK on the Share window in NinjaTrader. This method can also be called by Alerts and general NinjaScript objects. |
| [Signature](signature.md) | Sets the text appended to the end of the user's message. |
