﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace C2_Group_Application.Models.Pages
{
    [ContentType(DisplayName = "Contact", GUID = "4f7045c1-e274-46cb-8937-aef30a310aee", Description = "")]
    public class Contact : PageData
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