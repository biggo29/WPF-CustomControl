using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomLibraryWPF
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomLibraryWPF"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomLibraryWPF;assembly=CustomLibraryWPF"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class CustomControl1 : Control
    {
        static CustomControl1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));
        }
        public override void OnApplyTemplate()
        {
            var textString = GetTemplateChild("inputText") as TextBox;
            textString.Text = "Please give input";
            var btn = GetTemplateChild("button") as Button;
            if(btn!=null)
            {
                btn.Click += button_click;
            }
            var textBlock = GetTemplateChild("outputText") as TextBox;
            textBlock.Text = "length of the input?";
        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            var textString = GetTemplateChild("inputText") as TextBox;
            string str = textString.Text;
            int x = str.Length;

            //char[] cArray = str.ToCharArray();
            //string x = cArray.Count();
            var textBlock = GetTemplateChild("outputText") as TextBox;
            textBlock.Text = Convert.ToString(x);
        }
    }
}
