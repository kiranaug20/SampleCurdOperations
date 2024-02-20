using Microsoft.AspNetCore.Mvc;
using SampleCurdOperations.Models;
using System.Diagnostics;

namespace SampleCurdOperations.Controllers
{
    public class HomeController : Controller
    {
        
        private UserDetialsContext _userDetialsContext;

        public HomeController(UserDetialsContext user)
        {
            _userDetialsContext = user;
        }

        #region GET USERS
        public IActionResult Index()
        {
            return View(_userDetialsContext.mUsers);
        }
        #endregion

        #region CREATE USER
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MUser mUser)
        {
            if (ModelState.IsValid)
            {
                _userDetialsContext.mUsers.Add(mUser);
                _userDetialsContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        #endregion

        #region UPDATE USER
        public IActionResult Update(int id)
        {
            return View(_userDetialsContext.mUsers.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update_Post(MUser mUser)
        {
            _userDetialsContext.mUsers.Update(mUser);
            _userDetialsContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region DELETE USER
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var userobj = _userDetialsContext.mUsers.Where(a => a.Id == id).FirstOrDefault();
            _userDetialsContext.mUsers.Remove(userobj);
            _userDetialsContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
