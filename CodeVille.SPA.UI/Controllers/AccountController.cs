using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CodeVille.SPA.UI.Core;
using CodeVille.SPA.UI.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace CodeVille.SPA.UI.Controllers
{
    public class AccountController : ApiController
    {
        private AuthRepository _auth;

        public AccountController()
        {
            _auth = new AuthRepository();
        }

        // POST: api/Account/Register
        [ResponseType(typeof(UserModel))]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IdentityResult result = await _auth.RegisterUser(userModel);
            IHttpActionResult errorResult = GetErrorResult(result);
            if (errorResult != null)
            {
                return errorResult;
            }
            return Ok();
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    return BadRequest();
                }
                return BadRequest(ModelState);
            }
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _auth.Dispose();
            }
            base.Dispose(disposing);
        }

        [Route("api/Account/get")]
        // GET: api/Account
        public List<UserModel> GetUserModels()
        {
            return new List<UserModel> { new UserModel { Password = "asda"} };
        }

        //// GET: api/Account/5
        //[ResponseType(typeof(UserModel))]
        //public IHttpActionResult GetUserModel(int id)
        //{
        //    UserModel userModel = db.UserModels.Find(id);
        //    if (userModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(userModel);
        //}

        //// PUT: api/Account/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutUserModel(int id, UserModel userModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != userModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(userModel).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}



        //// DELETE: api/Account/5
        //[ResponseType(typeof(UserModel))]
        //public IHttpActionResult DeleteUserModel(int id)
        //{
        //    UserModel userModel = db.UserModels.Find(id);
        //    if (userModel == null)
        //    {
        //        return NotFound();
        //    }

        //    db.UserModels.Remove(userModel);
        //    db.SaveChanges();

        //    return Ok(userModel);
        //}



        //private bool UserModelExists(int id)
        //{
        //    return db.UserModels.Count(e => e.Id == id) > 0;
        //}
    }
}