using System;
using System.Collections.Generic;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Module10ContactListUsingMVVM.Models;

class Contact
{
    public string ContactName { get; set; }

    public string ContactEmail { get; set; }

    public string ContactPhone { get; set; }

    public string ContactDescription { get; set; }
}
