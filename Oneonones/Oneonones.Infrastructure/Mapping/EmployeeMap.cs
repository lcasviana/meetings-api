﻿using Oneonones.Domain.Entities;
using Oneonones.Infrastructure.ViewModel;

namespace Oneonones.Infrastructure.Mapping
{
    public static class EmployeeMap
    {
        public static EmployeeEntity ToEntity(this EmployeeViewModel viewModel)
        {
            var entity = new EmployeeEntity
            {
                Email = viewModel.Email,
                Name = viewModel.Name,
            };
            return entity;
        }

        public static EmployeeViewModel ToViewModel(this EmployeeEntity entity)
        {
            var viewModel = new EmployeeViewModel
            {
                Name = entity.Name,
                Email = entity.Email,
            };
            return viewModel;
        }
    }
}