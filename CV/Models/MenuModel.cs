using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using CV.App_LocalResources;
using Microsoft.Ajax.Utilities;

namespace CV.Models
{
    public class MenuModel
    {
        public MenuItem[] MenuList => new []
        {
            new MenuItem("HomePage", Res.HomePageLabel),
            new MenuItem("AboutPage", Res.AboutPageLabel),
            new MenuItem("CVPage", Res.CVPageLabel),
            new MenuItem("ContactsPage", Res.ContactsPageLabel)
        };
    }

    public class MenuItem
    {
        public MenuItem(string itemName, string itemLabel)
        {
            ItemName = itemName;
            ItemLabel = itemLabel;
        }

        public string ItemName { get; set; }
        public string ItemLabel { get; set; }
    }
}
