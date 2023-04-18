namespace LabEx4
{
    internal class NonFiction : Book
    {
        // constructor
        public NonFiction(string title) : base(title)
        {
            // update book price in init of a new obj
            SetPrice();
        }
        //give the abstract method the body
        public override void SetPrice()
        {
            price = 230.00;
        }
    }
}
