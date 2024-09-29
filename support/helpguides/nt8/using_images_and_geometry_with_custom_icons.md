


NinjaScript \> Educational Resources \> Using Images and Geometry with Custom Icons






















Using Images and Geometry with Custom Icons







| \<\< [Click to Display Table of Contents](using_images_and_geometry_with_custom_icons.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> Using Images and Geometry with Custom Icons | [Previous page](using_historical_bid_ask_serie.md) [Return to chapter overview](educational_resources.md) [Next page](using_sharpdx_for_custom_chart_rendering.md) |
| --- | --- |














## Custom Icon Overview


When overriding the Icon method in a [Share Service](share_service.md), [Drawing Object](drawing_tools.md), or [Chart Style](chart_style.md), you can use a variety of inputs to specify what will be displayed on the icon, including UniCode characters (if they exist in the icon pack for the font family used in NinjaTrader), custom Geometry Paths from the System.Windows.Shapes namespace, or image files. Using an image file for a custom icon can allow the flexibility of creating your icon's visuals outside of your code via image editing software. For more information about adding custom Icons, see the "Icon" page under the topics for each of the NinjaScript object types listed above.


 


![tog_minus](tog_minus.gif)




| Using an Image as an Icon The process for using an image as an icon is fairly straightforward using WPF objects, and is the same for different NinjaScript objects.   1\.Instantiate a new BitmapImage object2\.Assign a Uri to the BitmapImage, pointing to an image file3\.Instantiate a Grid of the same dimensions as the icon4\.Instantiate an Image object5\.Assign the BitmapImage as the Image's Source6\.Add the Image to the Grid7\.Return the Grid by overriding the Icon property    | Note: Be careful to instantiate the Grid to be same size as the needed icon. Some icon sizes differ from others. For example, the icon for Share Services is substantially larger than the icon for a Chart Style in the Chart Toolbar. | | --- |        | ns | | --- | | // Add the following Using statements using System.Windows.Controls; using System.Windows.Media; using System.Windows.Media.Imaging;   BitmapImage iconBitmapImage \= new BitmapImage();   protected override void OnStateChange() {    if (State \=\= State.Configure)    {      // Set the BitmapImage's UriSource to the location of an image file        iconBitmapImage.BeginInit();        iconBitmapImage.UriSource \= new Uri(NinjaTrader.Core.Globals.InstallDir \+ "icon.jpg");        iconBitmapImage.EndInit();    } }   // Override Icon (read\-only) to return the custom Grid and Image public override object Icon {    get    {        // Instantiate a Grid on which to place the image        Grid myCanvas \= new Grid { Height \= 16, Width \= 16 };          // Instantiate an Image to place on the Grid        Image image \= new Image        {            Height \= 16,            Width \= 16,            Source \= iconBitmapImage        };          // Add the image to the Grid        myCanvas.Children.Add(image);          return myCanvas;    } } | |
| --- | --- | --- | --- |



![tog_minus](tog_minus.gif)




| Using Geometry on an Icon Custom geometry Paths can be used to draw and fill custom shapes, which can then be applied directly to a Canvas returned for use in an Icon. The process for using a Path is similar to that for using an Image:   1\.Instantiate a new Path object2\.Instantiate a Grid of the same dimensions as the icon3\.Define the visual properties of the Path4\.Add the Path to the Grid5\.Return the Grid by overriding the Icon property    | ns | | --- | | // Add the following namespace to use Path objects using System.Windows.Shapes; using System.Windows.Controls;   public override object Icon {    get    {        // Instantiate a Grid on which to place the Path        Grid myCanvas \= new Grid { Height \= 16, Width \= 16 };          // Instantiate a Path object on which to draw geometry        System.Windows.Shapes.Path myPath \= new System.Windows.Shapes.Path();          // Define the Path's visual properties        myPath.Fill \= Brushes.Red;        myPath.Data \= System.Windows.Media.Geometry.Parse("M 0 0 L 5 0 L 5 5 L 10 5 L 10 0 L 15 0 L 15 5 L 10 5 L 10 10 L 5 10 L 5 5 L 0 5 Z");          // Add the Path to the Canvas, then return the Canvas        myCanvas.Children.Add(myPath);        return myCanvas;    } } | |
| --- | --- | --- |



 









