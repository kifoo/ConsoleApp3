//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using MoviesWebApp.Components.DataBase;
//using NuGet.Protocol.Plugins;
//using System.Net;

//namespace MoviesWebApp.Components.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FileController : ControllerBase
//    {
//        private readonly IWebHostEnvironment _env;
//        private readonly MoviesDB _context;
//        public FileController(IWebHostEnvironment env, MoviesDB context)
//        {
//            _env = env;
//            _context = context;
//        }

//        [HttpGet("{fileName}")]
//        public async Task<IActionResult> DownloadFile(string fileName)
//        {
//            var uploadResult = await _context.Images.FirstOrDefaultAsync(u => u.StoredFileName.Equals(fileName));

//            var path = Path.Combine(_env.ContentRootPath, "uploaded_images", fileName);

//            var memory = new MemoryStream();
//            using (var stream = new FileStream(path, FileMode.Open))
//            {
//                await stream.CopyToAsync(memory);
//            }
//            memory.Position = 0;
//            return File(memory, uploadResult.ContentType, Path.GetFileName(path));

//        }

//        [HttpPost]
//        public async Task<ActionResult<List<UploadResult>>> UploadFile(List<IFormFile> files)
//        {
//            List<UploadResult> uploadResultMovie = new List<UploadResult>();
//            foreach(var file in files)
//            {
//                var uploadResult = new UploadResult();
//                string trustedFileNameForFileStorage;
//                var untrustedFileName = file.FileName;
//                uploadResult.FileName = untrustedFileName;
//                var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);

//                trustedFileNameForFileStorage = Path.GetRandomFileName();
//                var path = Path.Combine(_env.ContentRootPath, "uploaded_images", trustedFileNameForFileStorage);

//                await using FileStream fs = new(path, FileMode.Create);
//                await file.CopyToAsync(fs);

//                uploadResult.StoredFileName = trustedFileNameForFileStorage;
//                uploadResult.ContentType = file.ContentType;
//                uploadResultMovie.Add(uploadResult);

//                _context.Images.Add(uploadResult);
//            }
//            await _context.SaveChangesAsync();

//            return Ok(uploadResultMovie);
//        }
//    }
//}
