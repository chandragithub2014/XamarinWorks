using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPractice.XamTabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracticeTabbedPage : TabbedPage
    {
        public PracticeTabbedPage()
        {
            InitializeComponent();
        }
    }
}
