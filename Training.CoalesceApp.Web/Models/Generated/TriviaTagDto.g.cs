using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Training.CoalesceApp.Web.Models
{
    public partial class TriviaTagDtoGen : GeneratedDto<Training.CoalesceApp.Data.Models.TriviaTag>
    {
        public TriviaTagDtoGen() { }

        private int? _TriviaTagId;
        private string _Name;

        public int? TriviaTagId
        {
            get => _TriviaTagId;
            set { _TriviaTagId = value; Changed(nameof(TriviaTagId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Training.CoalesceApp.Data.Models.TriviaTag obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TriviaTagId = obj.TriviaTagId;
            this.Name = obj.Name;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Training.CoalesceApp.Data.Models.TriviaTag entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TriviaTagId))) entity.TriviaTagId = (TriviaTagId ?? entity.TriviaTagId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Training.CoalesceApp.Data.Models.TriviaTag MapToNew(IMappingContext context)
        {
            var entity = new Training.CoalesceApp.Data.Models.TriviaTag();
            MapTo(entity, context);
            return entity;
        }
    }
}