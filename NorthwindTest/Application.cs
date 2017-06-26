using Firefly.Box;
using ENV.Data;
using ENV;
namespace NorthwindTest
{
    /// <summary>Main Program(P#1)</summary>
    /// <remark>Last change before Migration: 11/04/2007 20:07:17</remark>
    public class Application : ApplicationControllerBase 
    {
        Views.ApplicationMdi _mdi;
        public Application()
        {
            SetDefaultContextMenu(typeof(Views.DefaultContextMenu));
            Title = "Main Program";
            _applicationPrograms = _staticPrograms;
            _applicationEntities = _staticEntities;
        }
        protected override void OnLoad()
        {
            OnDatabaseErrorRetry = true;
        }
        #region Run Methods
        public static void Run()
        {
            Instance._mdi = new Views.ApplicationMdi();
            Instance.Run(Instance._mdi, () => Instance);
            Context.Current[typeof(Application)] = null;
        }
        protected override void Execute()
        {
            #if DEBUG
            Common.EnableDeveloperTools = true;
            #endif
            ;
            Common.BindStatusBar(_mdi.mainStatusLabel, _mdi.userStatusLabel, _mdi.activityStatusLabel, _mdi.expandStatusLabel, _mdi.expandTextBoxStatusLabel, _mdi.insertOverrideStatusLabel, _mdi.versionStatusLabel);
            _mdi.InitUserBasedMenus();
            base.Execute();
        }
        #endregion
        #region Init Programs and Entities Collection
        static Application()
        {
        }
        protected override string[] GetMenueNames()
        {
            return new []{"Default Pulldown menu", "Default Context menu"};
        }
        protected override ProgramCollection LoadAllProgramsCollection()
        {
            if (_staticPrograms==null)
                _staticPrograms = new ApplicationPrograms();
            return _staticPrograms;
        }
        protected override ApplicationEntityCollection LoadAllEntitiesCollection()
        {
            if (_staticEntities==null)
                _staticEntities = new ApplicationEntities();
            return _staticEntities;
        }
        #endregion
        #region Instance Management
        public static Application Instance 
        {
            get
            {
                var result = Context.Current[typeof(Application)] as Application;
                if (result == null)
                {
                    result = new Application();
                    Context.Current[typeof(Application)] = result;
                }
                return result;
            }
        }
        static ApplicationPrograms _staticPrograms;
        static ApplicationEntities _staticEntities;
        #endregion
    }
}
