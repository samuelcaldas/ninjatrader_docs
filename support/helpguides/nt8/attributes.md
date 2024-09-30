
NinjaScript > Language Reference > Common > Attributes
Attributes
| << [Click to Display Table of Contents](attributes.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Attributes | [Previous page](totime.md) [Return to chapter overview](common.md) [Next page](browsableattribute.md) |
| --- | --- |
The following section documents both .NET native and NinjaScript custom [attributes](https://msdn.microsoft.com/en-us/library/5x6cd29c(v=vs.110).aspx) which are commonly used to define the behavior of a NinjaScript property or object.  The attributes outlined in the section are primarily used to customize how properties display on the UI, but may also control or how the object is compiled and executed at run time.  
 
| Notes:   1.The .NET Framework supplies many other pre-defined [system attributes](https://msdn.microsoft.com/en-us/library/2e39z096.aspx) which can technically be used for custom NinjaScript programming, but are NOT covered in this section and therefore are considered unsupported.  3rd party developers are encourage to explore additional usage, but the resulting behavior CANNOT be guaranteed.2.Not all attributes can be applied to all object types.  For example, applying an attribute that is defined to target an class will NOT compile should you attempt to apply this attribute to a type of property. |
| --- |

## Common Attributes
| [BrowsableAttribute](browsableattribute.md) | Determines if a property should be displays in the NinjaTrader UI's property grid |
| --- | --- |
| [CategoryOrderAttribute](categoryorderattribute.md) | Determines the sequence in which a NinjaScript object's [Display.GroupName](displayattribute.md) categories are arranged in relation to other categories in the UI. |
| [DisplayAttribute](displayattribute.md) | Determines how a property is displays on the NinjaTrader UI's property grid. |
| [NinjaScriptPropertyAttribute](ninjascriptpropertyattribute.md) | Determines if a property should be included in the NinjaScript object's constructor as a parameter |
| [RangeAttribute](rangeattribute.md) | Determines if the value of a property is valid within a specified range |
| [XmlIgnoreAttribute](xmlignoreattribute.md) | Determines if a property participates in the XML serialization routines (saving workspaces or templates) |
 
## 
## Applying Attributes
Attributes are applied directly before the property, method, or class, and are identified by wrapping brackets:
 
| ns |
| --- |
| [AnExampleAttribute] // a pseudo-attribute demonstrating how to target an object public object AnExampleProperty // the property that is being targeted { get; set; } |

| Tip:   Conventionally, the suffix "attribute" is provided to the object's name to help determine that is an attribute, however C# does not require you to specify the full name of an attribute.  For example DisplayAttribute() will compile the same as Display(). |
| --- |

