using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrouwerWebApp.Repositories;

namespace BrouwerWebApp.Controllers
{
    public class BrouwerController : Controller
    {
        private readonly IBrouwerRepository repository;
        public BrouwerController(IBrouwerRepository repository) =>
        this.repository = repository;
        [HttpGet("{id}")]
        public async Task<ActionResult> FindById(int id)
        {
            var brouwer = await repository.FindByIdAsync(id);
            return brouwer == null ? base.NotFound() : base.Ok(brouwer);
        }
    }
}
