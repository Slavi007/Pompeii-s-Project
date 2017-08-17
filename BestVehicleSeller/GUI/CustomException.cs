namespace VehicleShop.Core
{
    using System.Windows.Forms;

    public static class CustomException
    {
        public static void AddException()
        {
            MessageBox.Show("Please fill all mandatory fields starting with * ",
                "Error",
                MessageBoxButtons.OK);
        }
        public static void SellException()
        {
            MessageBox.Show("Please choose vehicle.",
                "Error",
                MessageBoxButtons.OK);
        }
        public static void TuningException()
        {
            MessageBox.Show("This vehicle alraedy have tuning.",
                "Error",
                MessageBoxButtons.OK);
        }
    }
}
