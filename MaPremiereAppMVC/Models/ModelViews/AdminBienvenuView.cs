namespace MaPremiereAppMVC.Models.ModelViews
{
    public class AdminBienvenuView
    {
        private List<Admin> _admins;
        public string Message { get => "Bienvenue"; }
        public Admin[] Admins { get => _admins.ToArray() ?? new Admin[0]; }
        public string AdminContactMail { get; set; }

        public void AddAdmin(Admin newAdmin)
        {
            if(newAdmin == null) throw new ArgumentNullException(nameof(newAdmin));
            if(_admins == null) _admins = new List<Admin>();
            if(!_admins.Contains(newAdmin)) _admins.Add(newAdmin);
        }
    }
}
