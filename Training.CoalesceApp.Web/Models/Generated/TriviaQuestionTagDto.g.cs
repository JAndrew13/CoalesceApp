using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Training.CoalesceApp.Web.Models
{
    public partial class TriviaQuestionTagDtoGen : GeneratedDto<Training.CoalesceApp.Data.Models.TriviaQuestionTag>
    {
        public TriviaQuestionTagDtoGen() { }

        private int? _TriviaQuestionTagId;
        private int? _TriviaQuestionId;
        private Training.CoalesceApp.Web.Models.TriviaQuestionDtoGen _TriviaQuestion;
        private int? _TriviaTagId;
        private Training.CoalesceApp.Web.Models.TriviaTagDtoGen _TriviaTag;

        public int? TriviaQuestionTagId
        {
            get => _TriviaQuestionTagId;
            set { _TriviaQuestionTagId = value; Changed(nameof(TriviaQuestionTagId)); }
        }
        public int? TriviaQuestionId
        {
            get => _TriviaQuestionId;
            set { _TriviaQuestionId = value; Changed(nameof(TriviaQuestionId)); }
        }
        public Training.CoalesceApp.Web.Models.TriviaQuestionDtoGen TriviaQuestion
        {
            get => _TriviaQuestion;
            set { _TriviaQuestion = value; Changed(nameof(TriviaQuestion)); }
        }
        public int? TriviaTagId
        {
            get => _TriviaTagId;
            set { _TriviaTagId = value; Changed(nameof(TriviaTagId)); }
        }
        public Training.CoalesceApp.Web.Models.TriviaTagDtoGen TriviaTag
        {
            get => _TriviaTag;
            set { _TriviaTag = value; Changed(nameof(TriviaTag)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Training.CoalesceApp.Data.Models.TriviaQuestionTag obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TriviaQuestionTagId = obj.TriviaQuestionTagId;
            this.TriviaQuestionId = obj.TriviaQuestionId;
            this.TriviaTagId = obj.TriviaTagId;
            if (tree == null || tree[nameof(this.TriviaQuestion)] != null)
                this.TriviaQuestion = obj.TriviaQuestion.MapToDto<Training.CoalesceApp.Data.Models.TriviaQuestion, TriviaQuestionDtoGen>(context, tree?[nameof(this.TriviaQuestion)]);

            if (tree == null || tree[nameof(this.TriviaTag)] != null)
                this.TriviaTag = obj.TriviaTag.MapToDto<Training.CoalesceApp.Data.Models.TriviaTag, TriviaTagDtoGen>(context, tree?[nameof(this.TriviaTag)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Training.CoalesceApp.Data.Models.TriviaQuestionTag entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TriviaQuestionTagId))) entity.TriviaQuestionTagId = (TriviaQuestionTagId ?? entity.TriviaQuestionTagId);
            if (ShouldMapTo(nameof(TriviaQuestionId))) entity.TriviaQuestionId = (TriviaQuestionId ?? entity.TriviaQuestionId);
            if (ShouldMapTo(nameof(TriviaTagId))) entity.TriviaTagId = (TriviaTagId ?? entity.TriviaTagId);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Training.CoalesceApp.Data.Models.TriviaQuestionTag MapToNew(IMappingContext context)
        {
            var entity = new Training.CoalesceApp.Data.Models.TriviaQuestionTag();
            MapTo(entity, context);
            return entity;
        }
    }
}
