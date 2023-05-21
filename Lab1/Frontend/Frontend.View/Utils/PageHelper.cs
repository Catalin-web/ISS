namespace Frontend.Views.Utils
{
    public static class PageHelper
    {
        public static void Navigate(Form formToClose, Form formToOpen)
        {
            formToClose.Hide();
            formToOpen.Show();
        }

        public static void Open(Form formtoOpen)
        {
            formtoOpen.Show();
        }

        public static void Close(Form formToClose)
        {
            formToClose.Hide();
        }
    }
}
