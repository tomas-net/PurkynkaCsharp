namespace Purkynka.DAL.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => String.Format("{0} {1}", LastName.ToUpper(), FirstName); }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}