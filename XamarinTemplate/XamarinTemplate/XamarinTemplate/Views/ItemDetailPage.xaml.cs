using System.ComponentModel;
using Xamarin.Forms;
using XamarinTemplate.ViewModels;

namespace XamarinTemplate.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}