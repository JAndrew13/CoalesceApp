
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
    [Route("api/TriviaAnswer")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TriviaAnswerController
        : BaseApiController<Training.CoalesceApp.Data.Models.TriviaAnswer, TriviaAnswerDtoGen, Training.CoalesceApp.Data.AppDbContext>
    {
        public TriviaAnswerController(CrudContext<Training.CoalesceApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<Training.CoalesceApp.Data.Models.TriviaAnswer>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.TriviaAnswer> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<TriviaAnswerDtoGen>> List(
            ListParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.TriviaAnswer> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.TriviaAnswer> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Save(
            [FromForm] TriviaAnswerDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Training.CoalesceApp.Data.Models.TriviaAnswer> dataSource,
            IBehaviors<Training.CoalesceApp.Data.Models.TriviaAnswer> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TriviaAnswerDtoGen>> Delete(
            int id,
            IBehaviors<Training.CoalesceApp.Data.Models.TriviaAnswer> behaviors,
            IDataSource<Training.CoalesceApp.Data.Models.TriviaAnswer> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
