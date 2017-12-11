namespace SWApp
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Voornaam { get; set; }
        //public string Achternaam { get; set; }

        public override string ToString()
        {
            return Voornaam;
        }
    }
}
