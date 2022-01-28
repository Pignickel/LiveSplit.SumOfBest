using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class SumOfBestFactory : IComponentFactory
    {
        public string ComponentName => "SOBnoCUC";

        public string Description => "Adds 1:35 to SOB";

        public ComponentCategory Category => ComponentCategory.Information; 

        public IComponent Create(LiveSplitState state) => new SumOfBestComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.SumOfBest.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.8.0");
    }
}
