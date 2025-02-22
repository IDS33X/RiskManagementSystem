﻿using System.Collections.Generic;
using Util.Dtos.Risk;
using Util.Support.Response;

namespace Util.Support.Responses.Risk
{
    public class GetRiskByCategoryAndCodeResponse : PaginationResponse
    {
        public IEnumerable<RiskDto> Risks { get; set; }
    }
}
