namespace Altkom._10_12._04._2024.SOLID.S
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class EmailValidation
    {
        public static bool ValidateEmail(string email)
        {
            try
            {
                System.Net.Mail.MailAddress addr = new(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }

    //public class User
    //{
    //    public string UserName { get; set; }
    //    public string Password { get; set; }
    //    public string Email { get; set; }

    //    public bool ValidateEmail()
    //    {
    //        try
    //        {
    //            var addr = new System.Net.Mail.MailAddress(Email);
    //            return addr.Address == Email;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }
    //}
}
