﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PMS_API.Helpers
{
    public static class Utilities
    {
        public static string saveFile(HttpPostedFileBase file, string Directory)
        {
            string path = String.Empty;
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                string Root = System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data/" + Directory);
                if (!System.IO.Directory.Exists(Root))
                {
                    System.IO.Directory.CreateDirectory(Root);
                }
                path = Path.Combine(Root, fileName);
                file.SaveAs(path);
            }
            return path;
        }
    }
}