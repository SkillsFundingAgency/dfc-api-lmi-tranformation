﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DFC.Api.Lmi.Transformation.Models.JobGroupModels
{
    [ExcludeFromCodeCoverage]
    public class BreakdownModel
    {
        public int Soc { get; set; }

        public string? Note { get; set; }

        public string? Measure { get; set; }

        public IList<BreakdownYearModel>? PredictedEmployment { get; set; }
    }
}