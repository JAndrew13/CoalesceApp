
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Training.CoalesceApp.Web.Models;

namespace Training.CoalesceApp.Web.Api
{
    [Route("api/Organization")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class OrganizationController
        : BaseApiController<Training.CoalesceApp.Data.Models.Organization, OrganizationDtoGen, Training.CoalesceApp.Data.AppDbContext>
    {
        public OrganizationController(CrudContext<Training.CoalesceApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<Training.CoalesceApp.Data.Models.Organization>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<OrganizationDtoGen>> Get(
            string id,
            DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Organization> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<OrganizationDtoGen>> List(
            ListParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Organization> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Organization> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<OrganizationDtoGen>> Save(
            [FromForm] OrganizationDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Organization> dataSource,
            IBehaviors<Training.CoalesceApp.Data.Models.Organization> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<OrganizationDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<OrganizationDtoGen>> Delete(
            string id,
            IBehaviors<Training.CoalesceApp.Data.Models.Organization> behaviors,
            IDataSource<Training.CoalesceApp.Data.Models.Organization> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
