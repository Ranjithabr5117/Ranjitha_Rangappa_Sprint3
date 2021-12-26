using Microsoft.AspNetCore.Mvc;
using Ranjitha_Rangappa_Sprint1.Models;

namespace Ranjitha_Rangappa_Sprint1.Controllers
{
    public class LoginController : Controller
    {

        [HttpPost]
        public string Login(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.EmailId) || string.IsNullOrEmpty(userModel.Password))
            {
                return "UserId and password cannot be null";
            }
            else
            {

                List<User> list = new List<User>();
                list.Add(new User() { UserId = 1, FirstName = "Ranjitha", LastName = "Rangappa", EmailId = "r@gmail.com", Password = "1234" });
                var display = list.Where(a => a.UserId == userModel.UserId && a.Password == userModel.Password).FirstOrDefault();
                if (display == null)
                {
                    return "InCorrect UserName and Password";
                }
                return "Correct UserName and Password,Welcome";
            }
        }
    }
}
