﻿using ChatApp.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ContactsController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly ChatAppContext _context;

        public ContactsController(ILogger<UserController> logger, ChatAppContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpGet("getcontacts")]
        public List<User> GetContacts()
        {
            return _context.Users.ToList();
        }

        [HttpGet("getallcontacts")]
        public List<User> GetAllContacts()
        {
            List<User> users = new();
            users.AddRange(Enumerable.Range(0, 20001).Select(x => new User { UserId = x, FirstName = $"First{x}", LastName = $"Last{x}" }));

            return users;

        }

        [HttpGet("getonlyvisiblecontacts")]
        public List<User> GetOnlyVisibleContacts(int startIndex, int count)
        {
            List<User> users = new();
            users.AddRange(Enumerable.Range(startIndex, count).Select(x => new User { UserId = x, FirstName = $"First{x}", LastName = $"Last{x}" }));

            return users;
        }

        [HttpGet("getcontactscount")]
        public async Task<int> GetContactsCount()
        {
            //throw new IndexOutOfRangeException();
            return await _context.Users.CountAsync();
        }

        [HttpGet("getvisiblecontacts")]
        public async Task<List<User>> GetVisibleContacts(int startIndex, int count)
        {
            return await _context.Users.Skip(startIndex).Take(count).ToListAsync();
        }
    }
}
