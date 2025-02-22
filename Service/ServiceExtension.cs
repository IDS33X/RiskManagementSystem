﻿using Microsoft.Extensions.DependencyInjection;
using Service.Service;
using Service.ServiceImpl;
using Service.Service.ServiceImpl;

namespace Repository
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services)
        {
            services.AddTransient<ISessionService,SessionService>();
            services.AddTransient<IAreaService, AreaService>();
            services.AddTransient<IDivisionService, DivisionService>();
            services.AddTransient<IDepartmentService, DeparmentService>();
            services.AddTransient<IMRoleService, MRoleService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRiskCategoryService, RiskCategoryService>();
            services.AddTransient<IRiskImpactService, RiskImpactService >();
            services.AddTransient<IRiskService, RiskService>();
            services.AddTransient<IControlService, ControlService>();
            services.AddTransient<IRiskControlService, RiskControlService>();
            services.AddTransient<IUserControlService, UserControlService>();
            services.AddTransient<IMAutomationLevelService, MAutomationLevelService>();
            services.AddTransient<IMControlStateService, MControlStateService>();
            services.AddTransient<IMControlTypeService, MControlTypeService>();
            return services;
        }
    }
}
