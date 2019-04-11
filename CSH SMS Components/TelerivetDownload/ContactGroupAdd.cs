using System;
using System.Collections.Generic;
using System.Text;
using Telerivet.Client;

namespace TelerivetDownload
{
    public class ContactGroupAdd
    {
        public static void AddContactsToGroups(TelerivetApiConfig conf, IEnumerable<string> contactIds, string groupId)
        {
            TelerivetAPI tr = new TelerivetAPI(conf.TelerivetAPIKey);
            Project project = tr.InitProjectById("PJedf9c2a646a87abc");
            var group = project.GetGroupByIdAsync(groupId).Result;
            foreach(var contactId in contactIds)
            {
                project.GetContactByIdAsync(contactId).ContinueWith(t => t.Result.AddToGroupAsync(group));
            }
        }
    }
}
