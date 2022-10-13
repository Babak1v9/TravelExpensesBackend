using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelExpensesAPI.Data;
using TravelExpensesAPI.Models;
using TravelExpensesAPI.Services;

namespace TravelExpensesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly ApplicationsService _applicationsService;
        public ApplicationsController(ApplicationsService service)
        {
            _applicationsService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetApplications()
        {
            var applications = await _applicationsService.GetApplications();

            if (applications == null)
                return NotFound();

            return Ok(applications);
        }
    }
}
