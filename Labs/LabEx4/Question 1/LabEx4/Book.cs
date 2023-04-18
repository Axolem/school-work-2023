namespace LabEx4
{
    internal abstract class Book
    {
        //Variables
        protected string title;
        protected double price;

        //Constructor
        public Book(string title)
        {
            this.title = title;
        }

        //getters
        public string Title => title;

        public double Price => price;

        //Setter function that is abstract to be given body on the child classes
        public abstract void SetPrice();
    }
}
