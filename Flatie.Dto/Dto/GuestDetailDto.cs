using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flatie.Dto.Dto
{
    public class GuestDetailDto
    {
        public int Id { get; set; }
        public int HomeSpaceId { get; set; }
        public int InvitedByUserId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        // Navigation Properties
        public HomeSpaceDto? HomeSpace { get; set; }
        public UserDto? InvitedByUser { get; set; }
    }
}