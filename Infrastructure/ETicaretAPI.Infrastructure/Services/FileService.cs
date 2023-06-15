using ETicaretAPI.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure.Services
{
    public class FileService
    {
        
        async Task<string> FileRenameAsync(string path, string fileName)
        {
            await Task.Run(async () =>
            {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string newFileName = $"{NameOperation.CharacterRegulatory(oldName)}{extension}";

                if (File.Exists($"{path}\\{newFileName}"))
                    await FileRenameAsync(path, newFileName);
            });

            return "";
        }

    }
}
