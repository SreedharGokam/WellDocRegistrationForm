using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Data;

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellDocController : ControllerBase
    {
        private UserManager<WellDocUser> _userManager;
        public WellDocController(UserManager<WellDocUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<object> PostWellDocUser(WellDocRegister wellDocRegister)
        {
            var welldocuser = new WellDocUser()
            {
               UserName = wellDocRegister.UserName,
               FirstName = wellDocRegister.FirstName,
               LastName = wellDocRegister.LastName,
               Email = wellDocRegister.Email,
               Password = wellDocRegister.Password,
               ConfirmPassword = wellDocRegister.ConfirmPassword
            };
            try
            {
                var result = await _userManager.CreateAsync(welldocuser, wellDocRegister.Password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
