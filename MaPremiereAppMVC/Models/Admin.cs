namespace MaPremiereAppMVC.Models
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void KickUser(int idUser)
        {
            throw new NotImplementedException();
        }
    }
}
