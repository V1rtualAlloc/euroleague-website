﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private ClubsService _clubsService;

        public ClubsController(ClubsService clubsService)
        {
            _clubsService = clubsService;
        }

        // GET: api/Clubs
        [HttpGet("get-clubs")]
        public IActionResult GetClubs()
        {
            var clubs = _clubsService.GetClubs();
            return Ok(clubs);
        }

        [HttpPost("add-club")]
        public IActionResult AddClub([FromBody] ClubVM clubVM)
        {
            try
            {
                _clubsService.AddClubWithId(clubVM);
                return Created(nameof(AddClub), clubVM);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update-club-by-id/{id}")]
        public IActionResult UpdateClubById(Guid id, [FromBody] ClubVM clubVM)
        {
            try
            {
                var updatedClub = _clubsService.UpdateClubById(id, clubVM);
                return Ok(updatedClub);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete-club-by-id/{id}")]
        public IActionResult DeleteClubById(Guid id)
        {
            try
            {
                _clubsService.DeleteClubById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get-club-by-id/{id}")]
        public IActionResult GetClubById(Guid id)
        {
            var club = _clubsService.GetClubById(id);
            return Ok(club);
        }

        [HttpGet("get-club-by-code/{code}")]
        public IActionResult GetClubByClubCode(string code)
        {
            var club = _clubsService.GetClubByClubCode(code);
            return Ok(club);
        }

        [HttpGet("get-club-by-name/{name}")]
        public IActionResult GetClubByClubName(string name)
        {
            var club = _clubsService.GetClubByClubName(name);
            return Ok(club);
        }
    }
}
