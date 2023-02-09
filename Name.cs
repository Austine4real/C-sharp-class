namespace my_app
{
    public class Name
    {
        public string? FirstName;
        public string? LastName;

        public string fullName
        {
            get
            {
                 return $"{FirstName} {LastName}".ToLower();
            }
            set
            {
                // _firstName = value.ToLower();
                // _lastName = value.ToLower();
            }
        }

        // public string GetFullName()
        // {
        //     return $"{FirstName} {LastName}".ToLower();
        // }
    }
}