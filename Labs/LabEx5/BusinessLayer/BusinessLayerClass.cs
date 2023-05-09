using LabEx5;

namespace BusinessLayer
{
    public class BusinessLayerClass
    {
        private string operators = "";

        private readonly WebService1 webServiceClass = new WebService1();

        public string CalculateTotal()
        {

            string total = "0";

            switch (operators)
            {
                case "-":
                    total = webServiceClass.Subtract(ValueA, ValueB);
                    break;
                case "+":
                    total = webServiceClass.Add(ValueA, ValueB);
                    break;
                case "*":
                    total = webServiceClass.Multiply(ValueA, ValueB);
                    break;
                case "/":
                    total = webServiceClass.Divide(ValueA, ValueB);
                    break;
            }
            return total;
        }

        //Returns the string value of the currently clicked button
        public string Get_The_Clicked_BTN_Value(object sender)
        {
            return sender.ToString().Substring(sender.ToString().Length - 1, 1);
        }

        public decimal ValueA { get; set; } = 0.0m;
        public decimal ValueB { get; set; } = 0.0m;
        public string Operator { set => operators = value; }
    }
}
