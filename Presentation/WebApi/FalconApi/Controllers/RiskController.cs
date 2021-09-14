﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Util.Exceptions;
using Util.Support.Requests.Risk;

namespace FalconApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskController : ControllerBase
    {
        private readonly IRiskService _riskService;
        public RiskController(IRiskService riskService)
        {
            _riskService = riskService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddRiskRequest request)
        {
            var response = await _riskService.Add(request);

            return Ok(response);
        }

        [HttpGet("GetRiskByCategory")]
        public async Task<IActionResult> GetRiskByCategory([FromQuery] GetRiskByCategoryRequest request)
        {
            var response = await _riskService.GetRiskByCategory(request);

            return Ok(response);
        }

        [HttpGet("GetRiskByCategoryAndCode")]
        public async Task<IActionResult> GetRiskByCategoryAndCode([FromQuery] GetRiskByCategoryAndCodeRequest request)
        {
            var response = await _riskService.GetRiskByCategoryAndCode(request);

            return Ok(response);
        }  
        
        [HttpGet("GetRiskByCategoryAndDescription")]
        public async Task<IActionResult> GetRiskByCategoryAndDescription([FromQuery] GetRiskByCategoryAndDescriptionRequest request)
        {
            var response = await _riskService.GetRiskByCategoryAndDescription(request);

            return Ok(response);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EditRiskRequest request)
        {
            try
            {
                var response = await _riskService.Update(request);

                return Ok(response);
            }
            catch (DoesNotExistException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
