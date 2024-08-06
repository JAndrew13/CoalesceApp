
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
    [Route("api/Event")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class EventController
        : BaseApiController<Training.CoalesceApp.Data.Models.Event, EventDtoGen, Training.CoalesceApp.Data.AppDbContext>
    {
        public EventController(CrudContext<Training.CoalesceApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<Training.CoalesceApp.Data.Models.Event>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<EventDtoGen>> Get(
            string id,
            DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Event> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<EventDtoGen>> List(
            ListParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Event> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Event> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<EventDtoGen>> Save(
            [FromForm] EventDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.Event> dataSource,
            IBehaviors<Training.CoalesceApp.Data.Models.Event> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<EventDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<EventDtoGen>> Delete(
            string id,
            IBehaviors<Training.CoalesceApp.Data.Models.Event> behaviors,
            IDataSource<Training.CoalesceApp.Data.Models.Event> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
