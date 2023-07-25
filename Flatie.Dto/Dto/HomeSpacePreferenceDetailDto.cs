using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flatie.Dto.Dto
{
    public class HomeSpacePreferenceDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int UserId { get; set; }
        public int HomeSpaceId { get; set; }

        // Navigation Properties
        public UserDto? User { get; set; }
        public HomeSpaceDto? HomeSpace { get; set; }
    }
}