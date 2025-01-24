using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Training.CoalesceApp.Web.Models
{
    public partial class EventDtoGen : GeneratedDto<Training.CoalesceApp.Data.Models.Event>
    {
        public EventDtoGen() { }

        private string _EventId;
        private string _Name;
        private System.DateTimeOffset? _Start;
        private System.DateTimeOffset? _End;
        private string _OrganizationId;
        private Training.CoalesceApp.Web.Models.OrganizationDtoGen _Organization;

        public string EventId
        {
            get => _EventId;
            set { _EventId = value; Changed(nameof(EventId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public System.DateTimeOffset? Start
        {
            get => _Start;
            set { _Start = value; Changed(nameof(Start)); }
        }
        public System.DateTimeOffset? End
        {
            get => _End;
            set { _End = value; Changed(nameof(End)); }
        }
        public string OrganizationId
        {
            get => _OrganizationId;
            set { _OrganizationId = value; Changed(nameof(OrganizationId)); }
        }
        public Training.CoalesceApp.Web.Models.OrganizationDtoGen Organization
        {
            get => _Organization;
            set { _Organization = value; Changed(nameof(Organization)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Training.CoalesceApp.Data.Models.Event obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.EventId = obj.EventId;
            this.Name = obj.Name;
            this.Start = obj.Start;
            this.End = obj.End;
            this.OrganizationId = obj.OrganizationId;
            if (tree == null || tree[nameof(this.Organization)] != null)
                this.Organization = obj.Organization.MapToDto<Training.CoalesceApp.Data.Models.Organization, OrganizationDtoGen>(context, tree?[nameof(this.Organization)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Training.CoalesceApp.Data.Models.Event entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Start))) entity.Start = (Start ?? entity.Start);
            if (ShouldMapTo(nameof(End))) entity.End = (End ?? entity.End);
            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Training.CoalesceApp.Data.Models.Event MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new Training.CoalesceApp.Data.Models.Event()
            {
                Name = Name,
                Start = (Start ?? default),
                End = (End ?? default),
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(EventId))) entity.EventId = EventId;
            if (ShouldMapTo(nameof(OrganizationId))) entity.OrganizationId = OrganizationId;

            return entity;
        }
    }
}
