using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Examples.Data;
using Examples.Droid;
using Environment = System.Environment;

[assembly:Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace Examples.Droid
{
    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {
            
        }

        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //string docPath = Android.OS.Environment.DirectoryDocuments;
            //string libFolder = Path.Combine(docPath, "..", "Library", "Databases");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return Path.Combine(path, fileName);

        }
    }
}