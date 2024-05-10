using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.One.SingleResponsabilityPrinciple.CReport
{
    public class FileStorageService
    {
        public void Save(string directoryPath, string filename, string content){
            if(!Directory.Exists(directoryPath)){
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, filename), content);
        }
    }
}