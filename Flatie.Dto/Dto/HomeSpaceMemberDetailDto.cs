using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flatie.Dto.Dto
{
    public class HomeSpaceMemberDetailDto
    {
        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public DateTime JoinedAt { get; set; }
        public int HomeSpaceId { get; set; }
        public int UserId { get; set; }

        // Navigation Properties
        public HomeSpaceDto? HomeSpace { get; set; }
        public UserDto? User { get; set; }
    }
}