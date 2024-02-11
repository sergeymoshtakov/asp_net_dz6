namespace dz6.Helpers
{
    public class ColorHelper
    {
        public static string GetColor(decimal totalPrice)
        {
            if (totalPrice < 10)
            {
                return "red";
            }
            else if (totalPrice < 50)
            {
                return "green";
            }
            else if (totalPrice < 100)
            {
                return "orange";
            }
            else
            {
                return "blue";
            }
        }
    }
}
