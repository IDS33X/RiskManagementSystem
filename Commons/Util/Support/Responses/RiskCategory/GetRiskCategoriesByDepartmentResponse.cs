﻿using System.Collections.Generic;
using Util.Dtos.RiskCategory;
using Util.Support.Response;

namespace Util.Support.Responses.RiskCategory
{
    public class GetRiskCategoriesByDepartmentResponse : PaginationResponse
    {
        public IEnumerable<RiskCategoryDto> RiskCategories { get; set; }
    }
}
