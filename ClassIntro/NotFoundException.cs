namespace ClassIntro
{
    public class NotFoundException
    {
        public string Message { get; set; }
        public int? ErrorCount { get; set; }
        public NotFoundException()
        {
            Message = "Nothing found";
        }

        public NotFoundException(string Message)
        {
            this.Message = Message;
        }

        public NotFoundException(int errorCount, string message)
        {
            Message = message;
            ErrorCount = errorCount;
        }

        ~NotFoundException() //kohne texnologiyadi
        {
            Console.WriteLine("Destructor called");
        }
    }
}
