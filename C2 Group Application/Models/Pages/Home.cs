using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;


namespace C2_Group_Application.Models.Pages
{
    [ContentType(DisplayName = "Home", GUID = "30bb11db-4810-4998-84ff-5244d6819efe", Description = "")]
    public class Home : PageData
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