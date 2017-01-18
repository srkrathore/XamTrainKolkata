
using Xamarin.Forms;

namespace XamTrainKolkata
{
    public partial class TabbedEx : TabbedPage
    {
        public TabbedEx()
        {
            InitializeComponent();
            Children.Add(new FourthPage() { Title="Fourth"});
        }
    }
}
