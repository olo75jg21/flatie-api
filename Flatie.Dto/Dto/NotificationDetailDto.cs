using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flatie.Dto.Dto
{
    public class NotificationDetailDto
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public bool Read { get; set; }
        public int? UserId { get; set; }
        public int? HomeSpaceId { get; set; }
        public int? NotificationTypeId { get; set; }

        // Navigation Properties
        public NotificationTypeDto? Type { get; set; }
        public UserDto? User { get; set; }
        public HomeSpaceDto? HomeSpace { get; set; }
    }
}