﻿using System;
using Nop.Plugin.Misc.WebApi.Framework.Dto;

namespace Nop.Plugin.Misc.WebApi.Frontend.Dto.ReturnRequests
{
    public partial class PrivateMessageModelDto : ModelWithIdDto
    {
        public int FromCustomerId { get; set; }

        public string CustomerFromName { get; set; }

        public bool AllowViewingFromProfile { get; set; }

        public int ToCustomerId { get; set; }

        public string CustomerToName { get; set; }

        public bool AllowViewingToProfile { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsRead { get; set; }
    }
}
