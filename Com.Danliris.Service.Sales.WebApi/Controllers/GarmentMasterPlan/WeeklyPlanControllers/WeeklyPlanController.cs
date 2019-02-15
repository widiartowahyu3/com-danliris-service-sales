﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Com.Danliris.Service.Sales.Lib.BusinessLogic.Interface.Garment.WeeklyPlanInterfaces;
using Com.Danliris.Service.Sales.Lib.Models.GarmentMasterPlan.WeeklyPlanModels;
using Com.Danliris.Service.Sales.Lib.Services;
using Com.Danliris.Service.Sales.Lib.ViewModels.Garment.WeeklyPlanViewModels;
using Com.Danliris.Service.Sales.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.Danliris.Service.Sales.WebApi.Controllers.GarmentMasterPlan.WeeklyPlanControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/garment-master-plan/weekly-plans")]
    [Authorize]
    public class WeeklyPlanController : BaseController<WeeklyPlan, WeeklyPlanViewModel, IWeeklyPlanFacade>
    {
        private readonly static string apiVersion = "1.0";

        public WeeklyPlanController(IIdentityService identityService, IValidateService validateService, IWeeklyPlanFacade facade, IMapper mapper) : base(identityService, validateService, facade, mapper, apiVersion)
        {
        }
    }
}