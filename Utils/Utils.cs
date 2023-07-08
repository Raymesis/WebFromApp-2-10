using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Net;

namespace WebApplication2.Utilities
{
    public class Utils
    {
        //محاسبه مدت زمان گذشته از تاریخ پست
        internal static string CalculateTime(DateTime time)
        {
            TimeSpan t = DateTime.Now - time;

            if (t.Days >= 1)
                return t.Days + " روز پیش";
            else if (t.Days > 7)
                return t.Days % 7 + " هفته پیش";
            else if (t.Days < 1 && t.Hours >= 1)
                return t.Hours + " ساعت پیش";
            else if (t.Hours < 1)
                return t.Minutes + " دقیقه پیش";
            else
                return t.TotalMinutes.ToString();


        }
        //دریافت ایدی عددی ذخیره شده یک کاربر در دیتابیس
        internal static string GetUserId(System.Security.Principal.IIdentity identity)
        {
            return IdentityExtensions.GetUserId(identity);
        }
        //ذخیره تصویر آپلود شده 
        internal static string SaveImage(System.Web.UI.WebControls.FileUpload ProductImage, string path)
        {
            bool fileOK = false;
            String fileExtension;
            if (ProductImage.HasFile)
            {
                fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            else
            {
                return "error";
            }

            if (fileOK)
            {
                try
                {
                    string fileName = new Utils().GenerateRandomName(fileExtension);
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + fileName);
                    
                    WebClient client = new WebClient();
                    client.Credentials = new NetworkCredential("raymesis", "13571");
                    var url = "ftp://localhost/"+fileName;
                    client.UploadFile(url,path + fileName);

                    return "http://localhost/"+fileName;
                }
                catch (Exception ex)
                {
                     
                     System.Diagnostics.Debug.WriteLine(ex.Message);
                    return ex.Message;
                }
            }
            else
            {
                return "error";
            }
        }

        internal string GenerateRandomName(string ext)
        {
            Random res = new Random();

            // String that contain both alphabets and numbers
            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 8;

            // Initializing the empty string
            String randomstring = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(str.Length);

                // Appending the character at the 
                // index to the random alphanumeric string.
                randomstring += str[x];
            }
            DateTime time =System.DateTime.Now;
            randomstring += time.DayOfYear+ time.Year;
            randomstring += ext;
            return randomstring;
        }

        public static bool HasColumn(System.Data.SqlClient.SqlDataReader dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

    }
}