


NinjaScript \> Language Reference \> Drawing Tool \> Icon






















Icon







| \<\< [Click to Display Table of Contents](icon_drawingtool.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> Icon | [Previous page](getselectionpoints-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](ignoressnapping-1.md) |
| --- | --- |











## Definition


The shape which displays next to the Drawing Tool menu item.  Since this is a standard object, any type of icon can be used (unicode characters, custom image file resource, geometry path, etc). For more information on using images to create icons, see the [Using Images with Custom Icons](using_images_and_geometry_with_custom_icons-1.md) page.


 




| Note: When using UniCode characters, first ensure that the desired characters exist in the icon pack for the font family used in NinjaTrader. |
| --- |



 


 


## Property Value


A generic virtual object representing the drawing tools menu icon.  This property is read\-only.


 


## Syntax


You must override this property using the following syntax:


public override object Icon


 


## Examples




| ns |
| --- |
| public override object Icon {             get     {      //use a unicode character as our string which will render an arrow      string uniCodeArrow \= "\\u279A";                  return uniCodeArrow;     }    } |









