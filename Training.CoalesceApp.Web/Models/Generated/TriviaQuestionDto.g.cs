using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Training.CoalesceApp.Web.Models
{
    public partial class TriviaQuestionDtoGen : GeneratedDto<Training.CoalesceApp.Data.Models.TriviaQuestion>
    {
        public TriviaQuestionDtoGen() { }

        private int? _TriviaQuestionId;
        private string _Text;
        private System.Collections.Generic.ICollection<Training.CoalesceApp.Web.Models.TriviaAnswerDtoGen> _Answers;
        private System.Collections.Generic.ICollection<Training.CoalesceApp.Web.Models.TriviaQuestionTagDtoGen> _Tags;
        private string _EventId;
        private Training.CoalesceApp.Web.Models.EventDtoGen _Event;

        public int? TriviaQuestionId
        {
            get => _TriviaQuestionId;
            set { _TriviaQuestionId = value; Changed(nameof(TriviaQuestionId)); }
        }
        public string Text
        {
            get => _Text;
            set { _Text = value; Changed(nameof(Text)); }
        }
        public System.Collections.Generic.ICollection<Training.CoalesceApp.Web.Models.TriviaAnswerDtoGen> Answers
        {
            get => _Answers;
            set { _Answers = value; Changed(nameof(Answers)); }
        }
        public System.Collections.Generic.ICollection<Training.CoalesceApp.Web.Models.TriviaQuestionTagDtoGen> Tags
        {
            get => _Tags;
            set { _Tags = value; Changed(nameof(Tags)); }
        }
        public string EventId
        {
            get => _EventId;
            set { _EventId = value; Changed(nameof(EventId)); }
        }
        public Training.CoalesceApp.Web.Models.EventDtoGen Event
        {
            get => _Event;
            set { _Event = value; Changed(nameof(Event)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Training.CoalesceApp.Data.Models.TriviaQuestion obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TriviaQuestionId = obj.TriviaQuestionId;
            this.Text = obj.Text;
            this.EventId = obj.EventId;
            var propValAnswers = obj.Answers;
            if (propValAnswers != null && (tree == null || tree[nameof(this.Answers)] != null))
            {
                this.Answers = propValAnswers
                    .OrderBy(f => f.TriviaAnswerId)
                    .Select(f => f.MapToDto<Training.CoalesceApp.Data.Models.TriviaAnswer, TriviaAnswerDtoGen>(context, tree?[nameof(this.Answers)])).ToList();
            }
            else if (propValAnswers == null && tree?[nameof(this.Answers)] != null)
            {
                this.Answers = new TriviaAnswerDtoGen[0];
            }

            var propValTags = obj.Tags;
            if (propValTags != null && (tree == null || tree[nameof(this.Tags)] != null))
            {
                this.Tags = propValTags
                    .OrderBy(f => f.TriviaQuestionTagId)
                    .Select(f => f.MapToDto<Training.CoalesceApp.Data.Models.TriviaQuestionTag, TriviaQuestionTagDtoGen>(context, tree?[nameof(this.Tags)])).ToList();
            }
            else if (propValTags == null && tree?[nameof(this.Tags)] != null)
            {
                this.Tags = new TriviaQuestionTagDtoGen[0];
            }

            if (tree == null || tree[nameof(this.Event)] != null)
                this.Event = obj.Event.MapToDto<Training.CoalesceApp.Data.Models.Event, EventDtoGen>(context, tree?[nameof(this.Event)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Training.CoalesceApp.Data.Models.TriviaQuestion entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TriviaQuestionId))) entity.TriviaQuestionId = (TriviaQuestionId ?? entity.TriviaQuestionId);
            if (ShouldMapTo(nameof(Text))) entity.Text = Text;
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Training.CoalesceApp.Data.Models.TriviaQuestion MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new Training.CoalesceApp.Data.Models.TriviaQuestion()
            {
                Text = Text,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(TriviaQuestionId))) entity.TriviaQuestionId = (TriviaQuestionId ?? entity.TriviaQuestionId);
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;

            return entity;
        }
    }
}
