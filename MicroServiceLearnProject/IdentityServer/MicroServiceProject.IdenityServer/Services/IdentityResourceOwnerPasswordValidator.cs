﻿using IdentityServer4.Validation;
using MicroServiceProject.IdenityServer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel;

namespace MicroServiceProject.IdenityServer.Services
{
    public class IdentityResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityResourceOwnerPasswordValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var existUser = await _userManager.FindByEmailAsync(context.UserName);

            if(existUser == null)
            {
                var errors = new Dictionary<string, Object>();
                errors.Add("errors", new List<string> { "Email veya şifreniz yanlış" });

                context.Result.CustomResponse = errors;

                return;
            }

            var passwordCheck = await _userManager.CheckPasswordAsync(existUser, context.Password);

            if(!passwordCheck)
            {
                var errors = new Dictionary<string, Object>();
                errors.Add("errors", new List<string> { "Email veya şifreniz yanlış" });

                context.Result.CustomResponse = errors;

                return;
            }

            context.Result = new GrantValidationResult(existUser.Id.ToString(), OidcConstants.AuthenticationMethods.Password);
        }
    }
}
