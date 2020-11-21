﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jt808TerminalEmulator.Core;
using Jt808TerminalEmulator.Interface;
using Jt808TerminalEmulator.Model.Dtos;
using Jt808TerminalEmulator.Model.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Jt808TerminalEmulator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        readonly ILineService lineService;

        public LineController(ILineService lineService)
        {
            this.lineService = lineService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(LineDto dto)
        {
            var result = await lineService.Add(dto) > 0;
            return Ok(new JsonResultDto<bool>
            {
                Data = result,
                Message = result ? null : "操作失败"
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await lineService.Delete(new string[] { id }) > 0;
            return Ok(new JsonResultDto<bool>
            {
                Data = result,
                Message = result ? null : "操作失败"
            });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] string[] ids)
        {
            var result = await lineService.Delete(ids) > 0;
            return Ok(new JsonResultDto<bool>
            {
                Data = result,
                Message = result ? null : "操作失败"
            });
        }

        [HttpPut]
        public async Task<IActionResult> Update(LineDto dto)
        {
            await lineService.Update(dto);
            return Ok(new JsonResultDto<LineDto>
            {
                Data = dto
            });
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Search([FromQuery] LineFilter filter)
        {
            return Ok(await lineService.Search(filter));
        }
    }
}
