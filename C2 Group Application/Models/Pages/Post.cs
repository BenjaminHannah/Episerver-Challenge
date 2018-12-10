using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2_Group_Application.Models.Pages
{
    [ContentType(DisplayName = "Post", GUID = "b29e5404-c7f6-483f-b9a2-2658b8db62fd", Description = "")]
    public class Post : PageData
    {
        [CultureSpecific]
        [Display(
                    Name = "Heading",
                    Description = "The page heading",
                    GroupName = SystemTabNames.Content,
                    Order = 0)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}