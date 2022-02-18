using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal.Helpers
{
    public class Functional
    {
        public async Task<List<string>> UploadMultipleFile(List<IFormFile> files, IHostingEnvironment env, string uploadFolder)
        {
            var result = new List<string>();

            var webRoot = env.WebRootPath;
            var uploads = System.IO.Path.Combine(webRoot, uploadFolder);
            var extension = "";
            var filePath = "";
            var fileName = "";


            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    extension = System.IO.Path.GetExtension(formFile.FileName);
                    fileName = Guid.NewGuid().ToString() + extension;
                    filePath = System.IO.Path.Combine(uploads, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    result.Add(uploadFolder+fileName);
                }
            }

            return result;
        }

        public async Task<string> UploadSingleFile(IFormFile file, IHostingEnvironment env, string uploadFolder)
        {
            var result = "";
            if (file == null)
            {
                return result;
            }

            var webRoot = env.WebRootPath;
            var uploads = System.IO.Path.Combine(webRoot, uploadFolder);
            var extension = "";
            var filePath = "";
            var fileName = "";


            if (file.Length > 0)
            {
                extension = System.IO.Path.GetExtension(file.FileName);
                fileName = Guid.NewGuid().ToString() + extension;
                filePath = System.IO.Path.Combine(uploads, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                result = fileName;

            }

            return result;
        }

    }
}
