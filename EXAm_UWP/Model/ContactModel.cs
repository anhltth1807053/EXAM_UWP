using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using EXAm_UWP.Utils;
using Contact = EXAm_UWP.Entity.Contact;

namespace EXAm_UWP.Model
{
    class ContactModel
    {
        public bool Insert(Contact contact)
        {
            try
            {
                using (var stt = SQLiteUtils.GetIntances().Connection.Prepare("INSERT INTO Contact (Name, Phone) VALUES (?, ?)"))
                {
                    stt.Bind(1, contact.name);
                    stt.Bind(2, contact.phone);
                    stt.Step();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
