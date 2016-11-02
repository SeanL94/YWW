using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using YWW.core.Interfaces;
using healthJourney.droid.Database;
using MvvmCross.Platform;
using YWW.core.Database;

namespace healthJourney.droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISqlite, SqliteDroid>();
            Mvx.LazyConstructAndRegisterSingleton<IPostDatabase, PostDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IGoalDatabase, GoalDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IThoughtDatabase, ThoughtDatabase>();
            base.InitializeFirstChance();
        }

        protected override IMvxApplication CreateApp()
        {
            return new YWW.core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
