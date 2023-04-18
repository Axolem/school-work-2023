namespace LabEx4
{
    internal class Fiction : Book
    {
        // constructor
        public Fiction(string title) : base(title)
        {
            // update book price in init of a new obj
            SetPrice();
        }

        //give the abstract method the body
        public override void SetPrice()
        {
            price = 170.00;
        }
    }
}
