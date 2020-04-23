using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WoWChatLogWebParser.Models
{
    public class UploadFileModel
    { 
       
        [BindProperty]
        public IFormFile Upload { get; set; }


        public async Task OnPostAsync()
        {

            Debug.WriteLine("File has been posted!");
        }
    }
}
