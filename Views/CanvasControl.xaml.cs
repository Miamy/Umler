using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Umler.Views
{ 
    /// <summary>
    /// Interaction logic for CanvasControl
    /// </summary>
    public partial class CanvasControl : UserControl
    {
        public CanvasControl()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void Rectangle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point pt = Mouse.GetPosition(grid);
        }
    }
}
