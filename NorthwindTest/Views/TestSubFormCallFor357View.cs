using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Views
{
    /// <summary>TestSubFormCallFor357(P#11)</summary>
    partial class TestSubFormCallFor357View : NorthwindTest.Shared.Theme.Controls.CompatibleForm 
    {
        TestSubFormCallFor357 _controller;
        internal TestSubFormCallFor357View(TestSubFormCallFor357 controller)
        {
            _controller = controller;
            InitializeComponent();
            SubFormDetails.SetController(_controller.details1, _controller.details_SubForm);
        }
    }
}
