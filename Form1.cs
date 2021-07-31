using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            if (!string.IsNullOrEmpty(tbx_Name.Text) && !string.IsNullOrWhiteSpace(tbx_Name.Text)
                && !string.IsNullOrWhiteSpace(tbx_Surname.Text) && !string.IsNullOrEmpty(tbx_Surname.Text)
                && !string.IsNullOrWhiteSpace(tbx_Email.Text) && !string.IsNullOrEmpty(tbx_Email.Text)
                && !string.IsNullOrEmpty(mtb_Phone.Text) && !string.IsNullOrEmpty(mtb_Phone.Text)
                && tbx_Name.Text.Length > 4 && tbx_Surname.Text.Length > 4
                && tbx_Email.Text.Length > 10 && mtb_Phone.Text.Length == 15) 
            {
                if (tbx_Email.Text.EndsWith("@gmail.com") 
                    || tbx_Email.Text.EndsWith("@hotmail.com")
                    || tbx_Email.Text.EndsWith("@outlook.com") 
                    || tbx_Email.Text.EndsWith("@yahoo.com")
                    || tbx_Email.Text.EndsWith("@mail.ru") 
                    || tbx_Email.Text.EndsWith("@yandex.ru")) btn_Add.Enabled = true;
            }
            else btn_Add.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(btn_Add.Text == "Add")
            {
                bool check = false;
                foreach (var item in lbx_Display.Items)
                {
                    if ((item as User).Name == tbx_Name.Text
                        && (item as User).Surname == tbx_Surname.Text
                        || (item as User).Email == tbx_Email.Text
                        || (item as User).Phone == mtb_Phone.Text)
                    {
                        check = true;
                        break;
                    }
                }
                if(!check)
                {
                    lbx_Display.Items.Add(new User
                    {
                        ObjectID = ++User.ID,
                        Name = tbx_Name.Text,
                        Surname = tbx_Surname.Text,
                        Email = tbx_Email.Text,
                        Phone = mtb_Phone.Text,
                        DateOfBirth = dtp_DateOfBirth.Value.ToString(),
                    });
                }
            }
            else
            {
                foreach (var item in lbx_Display.Items)
                {
                    if(lbx_Display.SelectedIndex + 1 == (item as User).ObjectID)
                    {
                        (item as User).Name = tbx_Name.Text;
                        (item as User).Surname = tbx_Surname.Text;
                        (item as User).Email = tbx_Email.Text;
                        (item as User).Phone = mtb_Phone.Text;
                        (item as User).DateOfBirth = dtp_DateOfBirth.Text;
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(tbx_FileName.Text, JsonConvert.SerializeObject(lbx_Display.Items, Newtonsoft.Json.Formatting.Indented));
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            lbx_Display.Items.Clear();
            var users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(tbx_FileName.Text));
            foreach (var user in users)
            {
                lbx_Display.Items.Add(user);
                User.ID = user.ObjectID;
            }
            lbx_Display.SelectedIndex = 0;
            //lbx_Display.SelectionMode = SelectionMode.MultiSimple;
            lbx_Display.SelectionMode = SelectionMode.MultiExtended;
        }

        private void lbx_Display_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_Name.Text = (lbx_Display.SelectedItem as User)?.Name;
            tbx_Surname.Text = (lbx_Display.SelectedItem as User)?.Surname;
            tbx_Email.Text = (lbx_Display.SelectedItem as User)?.Email;
            mtb_Phone.Text = (lbx_Display.SelectedItem as User)?.Phone;
            dtp_DateOfBirth.Text = (lbx_Display.SelectedItem as User)?.DateOfBirth;
            if ((lbx_Display.SelectedItem as User)?.Name != null) btn_Add.Text = "Edit";
            else btn_Add.Text = "Add";
        }
    }
}