using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/photos")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;

        public PhotosController(IDatingRepository repo, IMapper mapper, 
        IOptions<CloudinarySettings> cloudinaryConfig){
            _repo = repo;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;
    
            // Account acc = new Account{
            //     _cloudinaryConfig.Value.CloudName,
            //     _cloudinaryConfig.Value.ApiKey,
            //     _cloudinaryConfig.Value.ApiSecret
            // };

            // _cloudinary = new Cloudinary(acc);
        }

        // [HttpPost]
        // public async Task<IActionResult> AddPhotoForUser(int userId, PhotoForCreationDto photoForCreationDto)
        // {
        //     if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
        //         return Unauthorized();

        //     var userFromRepo = await _repo.GetUser(userId);

        //     var file = photoForCreationDto.File;
        //     var uploadResult = new ImageUploadResult();

        //     if(file.Length > 0)
        //     {
        //         using (var stream = file.OpenReadStream())
        //         {
        //             var uploadParams = new ImageUploadParams()
        //             {
        //                 File = new FileDescription(file.Name, stream)
        //             };

        //             uploadResult = _cloudinary.Upload(uploadParams);
        //         }
        //     }
        // }
    }
}