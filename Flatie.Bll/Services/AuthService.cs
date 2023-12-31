using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using Flatie.Bll.Services.Interfaces;
using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db.Entities;
using Flatie.Dto.Dto;
using Flatie.Dto.Fvo;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Flatie.Bll.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;

        public AuthService(IMapper mapper, IConfiguration configuration, IUserRepository userRepository)
        {
            _mapper = mapper;
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public async Task<UserLoginDto> Login(UserLoginFvo userLoginFvo)
        {
            var userTbl = await _userRepository
                .FirstOrDefaultAsync(u => u.Username.ToLower() == userLoginFvo.Username.ToLower());

            if (userTbl is null || !VerifyPasswordHash(userLoginFvo.Password, userTbl.PasswordHash, userTbl.PasswordSalt))
            {
                throw new KeyNotFoundException("Wrong credentials");
            }

            var userLoginDto = _mapper.Map<UserLoginDto>(userTbl);
            userLoginDto.Token = CreateToken(userTbl);

            return userLoginDto;
        }

        public async Task<bool> Register(UserRegisterFvo userRegisterFvo)
        {
            CreatePasswordHash(userRegisterFvo.Password, out byte[] passwordHash, out byte[] passwordSalt);

            if (await UserExists(userRegisterFvo.Username))
            {
                throw new Exception("User already exists");
            }

            var userRegisterDto = _mapper.Map<UserRegisterDto>(userRegisterFvo);

            userRegisterDto.PasswordHash = passwordHash;
            userRegisterDto.PasswordSalt = passwordSalt;

            var userTbl = _mapper.Map<User>(userRegisterDto);
            _userRepository.Add(userTbl);
            await _userRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _userRepository.AnyAsync(u => u.Username.ToLower() == username.ToLower()))
            {
                return true;
            }

            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(User userTbl)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userTbl.Id.ToString()),
                new Claim(ClaimTypes.Name, userTbl.Username)
            };

            var appSettingsToken = _configuration.GetSection("AppSettings:Token").Value;

            if (appSettingsToken is null)
            {
                throw new Exception("AppSettings Token is null");
            }

            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(appSettingsToken));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptior);

            return tokenHandler.WriteToken(token);
        }
    }
}