using AutoMapper;
using Mapowanie.Dto;
using Mapowanie.Source;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapowanie.Controllers
{
    [ApiController]
    public class MapperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("/api/mapper")]
        public Pars Map(Root request)
        {
            var methodArgs = _mapper.Map<MethodArgs>(request);
            var pars = _mapper.Map<Pars>(request.Dokument);
            return pars;
        }
    }
}
