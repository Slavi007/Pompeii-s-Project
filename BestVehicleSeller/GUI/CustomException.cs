namespace VehicleShop.Core
{
    using System.Windows.Forms;

    public static class CustomException
    {
        public static void AddException()
        {
            MessageBox.Show("Please fill all mandatory fields starting with * ");
        }
        public static void SellException()
        {
            MessageBox.Show("Please choose vehicle.");
        }
        public static void TuningException()
        {
            MessageBox.Show("This vehicle alraedy have tuning.");
        }
    }
}
