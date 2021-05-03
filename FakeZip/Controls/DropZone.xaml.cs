using System;
using System.Windows;
using System.Windows.Controls;

namespace FakeZip.Controls
{
    /// <summary>
    /// Interaction logic for DropZone.xaml
    /// </summary>
    public partial class DropZone : UserControl
    {
        public DropZone()
        {
            InitializeComponent();
        }

        private void DropZone_OnDrop(object sender, DragEventArgs e)
        {
            Console.Write("drop");
        }
    }
}
