using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNetPrivNupkgCiCdTest;

namespace DotNetGitPackageTest
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }

        [RelayCommand]
        protected void RunTest()
        {
            var mh = new MathHelper();
            var result = mh.Add(2, 3);
        }
    }
}
