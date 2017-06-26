using System;
using ENV;
namespace NorthwindTest.Views
{
    internal partial class DefaultContextMenu : System.Windows.Forms.ContextMenuStrip,IHaveAMenu 
    {
        MenuManager _menuManager;
        public void InitUserBasedMenus()
        {
        }
        public DefaultContextMenu(System.ComponentModel.IContainer container) : base(container)
        {
            InitializeComponent();
            InitUserBasedMenus();
            _menuManager = new MenuManager(this);
            _menuManager.SetCurrentStateAsDefault();
        }
        public void DoOnMenu(Action<MenuManager> action)
        {
            action(_menuManager);
        }
        protected override void OnOpened(EventArgs e)
        {
            MenuManager.ApplyToContextMenu(this, this);
        }
        protected T Create<T>()
        {
            return AbstractFactory.Create<T>();
        }
    }
}
