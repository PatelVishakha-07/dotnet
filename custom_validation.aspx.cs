using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration
{
    public partial class custom_validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string s = args.Value;

            int d = 0, up = 0, l = 0, sp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsWhiteSpace(s[i]))
                {
                    args.IsValid = false;
                    return;
                }
                if (Char.IsDigit(s[i]))
                    d = 1;
                else if (Char.IsUpper(s[i]))
                    up = 1;
                else if (Char.IsLower(s[i]))
                    l = 1;
                else if (Char.IsSymbol(s[i]) || Char.IsPunctuation(s[i]))
                    sp = 1;
            }
            if (d == 1 && up == 1 && l == 1 && sp == 1)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}