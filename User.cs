namespace my_app
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // public void Output(int times)
        // {
        //     for(int i=0; i<times; i++)
        //     {
        //         Console.WriteLine($"{FirstName} {LastName}");
        //     }
        // }
        
         public string Output(int times)
        {
            string message = "";
            for(int i=0; i<times; i++)
            {
               message += $"{FirstName} {LastName} \n";
            }
            return message;
        }
        
    }
}