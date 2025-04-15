//
// Copyright (C) 2018, NinjaTrader LLC <www.ninjatrader.com>.
// NinjaTrader reserves the right to modify or overwrite this NinjaScript component with each release.
//
#region Using declarations
using NinjaTrader.Cbi;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.Data;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui;
using NinjaTrader.NinjaScript.DrawingTools;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using System.Xml.Serialization;
using System;
#endregion

//This namespace holds strategies in this folder and is required. Do not change it.
namespace NinjaTrader.NinjaScript.Indicators
{
    // Notes:
    // Helper classes and type converters are defined below the indicator, separated by use case
    // Property definitions are documented as necessary in the Properties region
    // Debugging issues will likely require compiling NS in debug mode and attaching VS to ninjatrader.exe
    // Setting breakpoints to examine values and seeing debug output that NT creates is helpful

    #region Use Case #5: Display a custom collection/list with user defined values at run time
    // IMPORTANT
    // Structures used in custom PropertyEditor add-ons such as CollectionEditor
    // CANNOT be a nested type of another class
    // and MUST have a default constructor
    //
    // To display a custom collection to the GUI, we will reuse the NinjaTrader GUI Collection PropertyEditor
    // The NinjaTrader GUI Collection editor expects an ICloneable object.
    // Demonstration uses a double reference type, but this implementation can be expanded to more complex objects.
    // Another example of this can be found in the @PriceLevel.cs DrawingTool resource
    [CategoryDefaultExpanded(true)]
    public class PercentWrapper : NotifyPropertyChangedBase, ICloneable
    {
        // Parameterless constructor is needed for Clone and serialization
        public PercentWrapper() : this(0)
        {
        }

        public PercentWrapper(double value)
        {
            PercentageValue = value;
        }

        // Display attributes, XmlIgnore attributes, Browsable attributes, etc can be all applied to the object's properties as well.
        [Display(Name = "Value (in %)", GroupName = "Values")]
        public double PercentageValue
        { get; set; }

        // Cloned instance returned to the Collection editor with user defined value

		public object Clone()
		{
			PercentWrapper p  = new PercentWrapper();
			p.PercentageValue = PercentageValue;
			return p;
		}
		
		//Default value handling
		[Browsable(false)]
		public bool IsDefault { get; set; }
		
        // Customize the displays on the left side of the editor window
        public override string ToString()
        { return PercentageValue.ToString(CultureInfo.InvariantCulture) + " %"; }
		
		// Use Reflection to be able to copy properties to new instance
		public object AssemblyClone(Type t)
		{
			Assembly a 				= t.Assembly;
			object percentWrapper 	= a.CreateInstance(t.FullName);
			
			foreach (PropertyInfo p in t.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
			{
				if (p.CanWrite)
					p.SetValue(percentWrapper, this.GetType().GetProperty(p.Name).GetValue(this), null);
			}
			
			return percentWrapper;
		}
    }
    #endregion

    // Apply the TypeConverter attribute using the fully qualified name of your converter
    [TypeConverter("NinjaTrader.NinjaScript.Indicators.MyConverter")]
    public class SampleIndicatorTypeConverter : Indicator
    {
		private List<PercentWrapper> collectionDefaults = new List<PercentWrapper>()
		{
			new PercentWrapper(50) { IsDefault = true },
			new PercentWrapper(60) { IsDefault = true }
		};
		
		private Collection<PercentWrapper> myListValues;
		
        protected override void OnStateChange()
        {
            if (State == State.SetDefaults)
            {
                Description = "Demonstrating using type converters to customize the Indicator property grid";
                Name = "Sample Indicator TypeConverter";
                IsOverlay = true;

                // Custom Grid properties pushed to UI
                ShowHideToggle 	= true;
                ReadOnlyToggle 	= false;
                ToggleValue1 	= 1;
                ToggleValue2 	= 4;
                ReadOnlyInt 	= 10;
                ReadOnlyDouble 	= .25;
                FriendlyBool 	= true;
                EnumValue 		= MyEnum.MyCustom2;
                myListValues 	= new Collection<PercentWrapper>(collectionDefaults);
            }
        }

        protected override void OnBarUpdate()
        {
            if (FriendlyBool)
            {
            }
        }
		
		// Reflection to copy Collection to new assembly
		public override void CopyTo(NinjaScript ninjaScript)
		{
			base.CopyTo(ninjaScript);

			Type			newInstType					= ninjaScript.GetType();
			PropertyInfo	myListValuesPropertyInfo	= newInstType.GetProperty("MyListValues");
			
			if (myListValuesPropertyInfo == null)
				return;

			IList newInstMyListValues = myListValuesPropertyInfo.GetValue(ninjaScript) as IList;
			
			if (newInstMyListValues == null)
				return;

			// Since new instance could be past set defaults, clear any existing
			newInstMyListValues.Clear();
			
			foreach (PercentWrapper oldPercentWrapper in MyListValues)
			{
				try
				{
					object newInstance = oldPercentWrapper.AssemblyClone(Core.Globals.AssemblyRegistry.GetType(typeof(PercentWrapper).FullName));
					if (newInstance == null)
						continue;
					
					newInstMyListValues.Add(newInstance);
				}
				catch { }
			}
		}

        // Custom Grid properties which will implement custom behavior
        #region Use Case #1: Show/hide properties based on secondary input

        [RefreshProperties(RefreshProperties.All)] // Needed to refresh the property grid when the value changes
        [Display(Name = "Toggle show/hide", Order = 1, GroupName = "Use Case #1")]
        public bool ShowHideToggle
        { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Toggle value #1", Order = 2, GroupName = "Use Case #1")]
        public int ToggleValue1
        { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Toggle value #2", Order = 3, GroupName = "Use Case #1")]
        public int ToggleValue2
        { get; set; }

        #endregion

        #region Use Case #2: Disable/enable properties based on secondary input
        [RefreshProperties(RefreshProperties.All)] // Needed to refresh the property grid when the value changes
        [Display(Name = "Toggle read only", Order = 1, GroupName = "Use Case #2")]
        public bool ReadOnlyToggle
        { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Read only int", Order = 2, GroupName = "Use Case #2")]
        public int ReadOnlyInt
        { get; set; }

        [Range(0, double.MaxValue)]
        [Display(Name = "Read only double", Order = 3, GroupName = "Use Case #2")]
        public double ReadOnlyDouble
        { get; set; }

        #endregion

        #region Use Case #3: Re-implement a "bool" checkbox as a combobox

        [TypeConverter(typeof(FriendlyBoolConverter))] // Converts the bool to string values
        [PropertyEditor("NinjaTrader.Gui.Tools.StringStandardValuesEditorKey")] // Create the combo box on the property grid
        [Display(Name = "Friendly bool", Order = 1, GroupName = "Use Case #3")]
        public bool FriendlyBool
        { get; set; }

        #endregion

        #region Use Case #4: Display "Friendly" enum values

        [TypeConverter(typeof(FriendlyEnumConverter))] // Converts the enum to string values
        [PropertyEditor("NinjaTrader.Gui.Tools.StringStandardValuesEditorKey")] // Enums normally automatically get a combo box, but we need to apply this specific editor so default value is automatically selected
        [Display(Name = "Friendly Enum", Order = 8, GroupName = "Use Case #4")]
        public MyEnum EnumValue
        { get; set; }

        #endregion

        #region Use Case #5: Display a custom collection/list with user defined values at run time

        // Note: All these DisplayAttribute properties are required
        // Prompt is used to set what displays in the property grid and during mouseover
		[XmlIgnore]
        [Display(Name = "List values", GroupName = "Use Case #5", Order = 9, Prompt = "1 value|{0} values|Add value...|Edit value...|Edit values...")]
        [PropertyEditor("NinjaTrader.Gui.Tools.CollectionEditor")] // Allows a pop-up to be used to add values to the collection, similar to Price Levels in Drawing Tools
		[SkipOnCopyTo(true)]
        public Collection<PercentWrapper> MyListValues
        {
			get 
			{
				return myListValues;
			}
			set
			{
				myListValues = new Collection<PercentWrapper>(value.ToList());
			}
		}

        // Serializer for the PercentWrappers Collection
        [Browsable(false)]
        public Collection<PercentWrapper> MyListValuesSerialize
        {
			get
			{
				//Remove actual defaults
				foreach(PercentWrapper pw in collectionDefaults.ToList())
				{
					PercentWrapper temp = MyListValues.FirstOrDefault(p => p.PercentageValue == pw.PercentageValue && p.IsDefault == true);
					
					if(temp != null)
						collectionDefaults.Remove(temp);
				}
				
				//Force user added values to not be defaults
				MyListValues.All(p => p.IsDefault = false);
				
				return MyListValues;
			}
			set
			{
				MyListValues = value;
			}
        }

        #endregion
    }

    // TypeConverter/Property Descriptor logic to define how properties behave for each of defined use cases

    #region Use Case #1/#2: Show/hide properties based on secondary input & Disable/enable properties based on secondary input

    // This custom TypeConverter is applied ot the entire indicator object and handles two of our use cases
    // IMPORTANT: Inherit from IndicatorBaseConverter so we get default NinjaTrader property handling logic
    // IMPORTANT: Not doing this will completely break the property grids!
    // If targeting a "Strategy", use the "StrategyBaseConverter" base type instead
    public class MyConverter : IndicatorBaseConverter // or StrategyBaseConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attrs)
        {
            // we need the indicator instance which actually exists on the grid
            SampleIndicatorTypeConverter indicator = component as SampleIndicatorTypeConverter;

            // base.GetProperties ensures we have all the properties (and associated property grid editors)
            // NinjaTrader internal logic determines for a given indicator
            PropertyDescriptorCollection propertyDescriptorCollection = base.GetPropertiesSupported(context)
                                                                        ? base.GetProperties(context, component, attrs)
                                                                        : TypeDescriptor.GetProperties(component, attrs);

            if (indicator == null || propertyDescriptorCollection == null)
                return propertyDescriptorCollection;


            #region Use Case #1: Show/hide properties based on secondary input

            // These two values are will be shown/hidden (toggled) based on "ShowHideToggle" bool value
            PropertyDescriptor toggleValue1 = propertyDescriptorCollection["ToggleValue1"];
            PropertyDescriptor toggleValue2 = propertyDescriptorCollection["ToggleValue2"];

            // This removes the following properties from the grid to start off with
            propertyDescriptorCollection.Remove(toggleValue1);
            propertyDescriptorCollection.Remove(toggleValue2);

            // Now that We've removed the default property descriptors, we can decide if they need to be re-added
            // If "ShowHideToggle" is set to true, re-add these values to the property collection
            if (indicator.ShowHideToggle)
            {
                propertyDescriptorCollection.Add(toggleValue1);
                propertyDescriptorCollection.Add(toggleValue2);
            }

            // otherwise, nothing else to do since they were already removed

            #endregion

            #region Use Case #2: Disable/enable properties based on secondary input

            // These two values are will be disabled/enabled (grayed out) based on the indicator's "ShowHideToggle" bool value
            // The PropertyDescriptor type does not contain our desired custom behavior, so we must implement that ourselves
            PropertyDescriptor readOnlyInt = propertyDescriptorCollection["ReadOnlyInt"];
            PropertyDescriptor readOnlyDouble = propertyDescriptorCollection["ReadOnlyDouble"];

            // We must first remove the default implentation of the property (which does not yet contain our custom behavior)
            // Otherwise we would have two versions of the same property on the grid which is not desired
            propertyDescriptorCollection.Remove(readOnlyInt);
            propertyDescriptorCollection.Remove(readOnlyDouble);

            // This custom "ReadOnlyDescriptor" property descriptor (defined in the class below) toggles read-only mode based on a property in the indicator
            // So re-assign them from a "PropertyDescriptor" to new "ReadOnlyDescriptor" which handles our custom action
            readOnlyInt = new ReadOnlyDescriptor(indicator, readOnlyInt);
            readOnlyDouble = new ReadOnlyDoubleDescriptor(indicator, readOnlyDouble);

            // This re-adds the properties to the grid under their new "ReadOnlyDescriptor" type behavior
            propertyDescriptorCollection.Add(readOnlyInt);
            propertyDescriptorCollection.Add(readOnlyDouble);

            #endregion

            return propertyDescriptorCollection;
        }

        // Important: This must return true otherwise the type convetor will not be called
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        { return true; }
    }

    // This is a custom PropertyDescriptor class which will handle setting our desired properties to read only
    public class ReadOnlyDescriptor : PropertyDescriptor
    {
        // Need the instance on the property grid to check the show/hide toggle value
        private SampleIndicatorTypeConverter indicatorInstance;

        private PropertyDescriptor property;

        // The base instance constructor helps store the default Name and Attributes (Such as DisplayAttribute.Name, .GroupName, .Order)
        // Otherwise those details would be lost when we converted the PropertyDescriptor to the new custom ReadOnlyDescriptor
        public ReadOnlyDescriptor(SampleIndicatorTypeConverter indicator, PropertyDescriptor propertyDescriptor) : base(propertyDescriptor.Name, propertyDescriptor.Attributes.OfType<Attribute>().ToArray())
        {
            indicatorInstance = indicator;
            property = propertyDescriptor;
        }

        // Stores the current value of the property on the indicator
        public override object GetValue(object component)
        {
            SampleIndicatorTypeConverter targetInstance = component as SampleIndicatorTypeConverter;
            
			if (targetInstance == null)
                return null;
			
            switch (property.Name)
            {
                case "ReadOnlyInt":
                	return targetInstance.ReadOnlyInt;
            }
            return null;
        }

        // Updates the current value of the property on the indicator
        public override void SetValue(object component, object value)
        {
            SampleIndicatorTypeConverter targetInstance = component as SampleIndicatorTypeConverter;
            
			if (targetInstance == null)
                return;

            switch (property.Name)
            {
                case "ReadOnlyInt":
                    targetInstance.ReadOnlyInt = (int) value;
                    break;
            }
        }

        // set the PropertyDescriptor to "read only" based on the indicator instance input
        public override bool IsReadOnly
        { get { return indicatorInstance.ReadOnlyToggle; } }

        // IsReadOnly is the relevant interface member we need to use to obtain our desired custom behavior
        // but applying a custom property descriptor requires having to handle a bunch of other operations as well.
        // I.e., the below methods and properties are required to be implemented, otherwise it won't compile.
        public override bool CanResetValue(object component)
        { return true; }

        public override Type ComponentType
        { get { return typeof(SampleIndicatorTypeConverter); } }

        public override Type PropertyType
        { get { return typeof(int); } }

        public override void ResetValue(object component)
        { }

        public override bool ShouldSerializeValue(object component)
        { return true; }
    }

    // This is a custom PropertyDescriptor class which will handle setting our desired properties to read only
    public class ReadOnlyDoubleDescriptor : PropertyDescriptor
    {
        // Need the instance on the property grid to check the show/hide toggle value
        private SampleIndicatorTypeConverter indicatorInstance;

        private PropertyDescriptor property;

        // The base instance constructor helps store the default Name and Attributes (Such as DisplayAttribute.Name, .GroupName, .Order)
        // Otherwise those details would be lost when we converted the PropertyDescriptor to the new custom ReadOnlyDescriptor
        public ReadOnlyDoubleDescriptor(SampleIndicatorTypeConverter indicator, PropertyDescriptor propertyDescriptor) : base(propertyDescriptor.Name, propertyDescriptor.Attributes.OfType<Attribute>().ToArray())
        {
            indicatorInstance = indicator;
            property = propertyDescriptor;
        }

        // Stores the current value of the property on the indicator
        public override object GetValue(object component)
        {
            SampleIndicatorTypeConverter targetInstance = component as SampleIndicatorTypeConverter;
            
			if (targetInstance == null)
                return null;
			
            switch (property.Name)
            {
                case "ReadOnlyDouble":
                    return targetInstance.ReadOnlyDouble;
            }
            return null;
        }

        // Updates the current value of the property on the indicator
        public override void SetValue(object component, object value)
        {
            SampleIndicatorTypeConverter targetInstance = component as SampleIndicatorTypeConverter;
            
			if (targetInstance == null)
                return;

            switch (property.Name)
            {
                case "ReadOnlyDouble":
                    targetInstance.ReadOnlyDouble = (double)value;
                    break;
            }
        }

        // set the PropertyDescriptor to "read only" based on the indicator instance input
        public override bool IsReadOnly
        { get { return indicatorInstance.ReadOnlyToggle; } }

        // IsReadOnly is the relevant interface member we need to use to obtain our desired custom behavior
        // but applying a custom property descriptor requires having to handle a bunch of other operations as well.
        // I.e., the below methods and properties are required to be implemented, otherwise it won't compile.
        public override bool CanResetValue(object component)
        { return true; }

        public override Type ComponentType
        { get { return typeof(SampleIndicatorTypeConverter); } }

        public override Type PropertyType
        { get { return typeof(double); } }

        public override void ResetValue(object component)
        { }

        public override bool ShouldSerializeValue(object component)
        { return true; }
    }
    #endregion

    #region Use Case #3: Re-implement a "bool" checkbox as a combobox
    // Since this is only being applied to a specific property rather than the whole class,
    // we don't need to inherit from IndicatorBaseConverter and can just use a generic TypeConverter
    public class FriendlyBoolConverter : TypeConverter
    {
        // Set the values to appear in the combo box
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<string> values = new List<string>() { "Turn on", "Turn off" };

            return new StandardValuesCollection(values);
        }

        // map the value from "Friendly" string to bool type
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return value.ToString() == "Turn on" ? true : false;
        }

        // map the bool type to "Friendly" string
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            return (bool) value ? "Turn on" : "Turn off";
        }

        // required interface members needed to compile
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        { return true; }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        { return true; }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        { return true; }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        { return true; }
    }
    #endregion

    #region Use Case #4: Display "friendly" enum values
    public enum MyEnum
    {
        MyCustom1,
        MyCustom2,
        MyCustom3
    }

    // Since this is only being applied to a specific property rather than the whole class,
    // we don't need to inherit from IndicatorBaseConverter and we can just use a generic TypeConverter
    public class FriendlyEnumConverter : TypeConverter
    {
        // Set the values to appear in the combo box
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<string> values = new List<string>() { "My custom one", "My custom two", "My custom three" };

            return new StandardValuesCollection(values);
        }

        // map the value from "Friendly" string to MyEnum type
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string stringVal = value.ToString();
			
            switch (stringVal)
            {
                case "My custom one":
                return MyEnum.MyCustom1;
                case "My custom two":
                return MyEnum.MyCustom2;
                case "My custom three":
                return MyEnum.MyCustom3;
            }
            return MyEnum.MyCustom1;
        }

        // map the MyEnum type to "Friendly" string
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            MyEnum stringVal = (MyEnum) Enum.Parse(typeof(MyEnum), value.ToString());
			
            switch (stringVal)
            {
                case MyEnum.MyCustom1:
                return "My custom one";
                case MyEnum.MyCustom2:
                return "My custom two";
                case MyEnum.MyCustom3:
                return "My custom three";
            }
            return string.Empty;
        }

        // required interface members needed to compile
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        { return true; }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        { return true; }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        { return true; }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        { return true; }
    }
    #endregion
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private SampleIndicatorTypeConverter[] cacheSampleIndicatorTypeConverter;
		public SampleIndicatorTypeConverter SampleIndicatorTypeConverter()
		{
			return SampleIndicatorTypeConverter(Input);
		}

		public SampleIndicatorTypeConverter SampleIndicatorTypeConverter(ISeries<double> input)
		{
			if (cacheSampleIndicatorTypeConverter != null)
				for (int idx = 0; idx < cacheSampleIndicatorTypeConverter.Length; idx++)
					if (cacheSampleIndicatorTypeConverter[idx] != null &&  cacheSampleIndicatorTypeConverter[idx].EqualsInput(input))
						return cacheSampleIndicatorTypeConverter[idx];
			return CacheIndicator<SampleIndicatorTypeConverter>(new SampleIndicatorTypeConverter(), input, ref cacheSampleIndicatorTypeConverter);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.SampleIndicatorTypeConverter SampleIndicatorTypeConverter()
		{
			return indicator.SampleIndicatorTypeConverter(Input);
		}

		public Indicators.SampleIndicatorTypeConverter SampleIndicatorTypeConverter(ISeries<double> input )
		{
			return indicator.SampleIndicatorTypeConverter(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.SampleIndicatorTypeConverter SampleIndicatorTypeConverter()
		{
			return indicator.SampleIndicatorTypeConverter(Input);
		}

		public Indicators.SampleIndicatorTypeConverter SampleIndicatorTypeConverter(ISeries<double> input )
		{
			return indicator.SampleIndicatorTypeConverter(input);
		}
	}
}

#endregion
