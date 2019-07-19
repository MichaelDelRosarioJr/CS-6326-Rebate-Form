using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Asg2_mxd120830
{

    public partial class main : Form
    {
        //create customer list
        List<customer> c_List;
       

        public main()
        {
            InitializeComponent();

            c_List = new List<customer>();

            

        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int tempn;
            char tempc;
            bool diffCustomer = true;

            //Check to see if name exist and disable add if so.
            //for (int i = 0; i < c_List.Capacity; i++)
            //{
            //    if (firstNBox.Text == c_List.ElementAt(i).getFName() && middleIBox.Text == c_List.ElementAt(i).getFName() && LastNBox.Text == c_List.ElementAt(i).getFName())
            //    {
            //        diffCustomer = false;
            //    }
            //    else
            //    {
            //        diffCustomer = true;
            //    }

            //}

            //Enable save when all important data fields are typed in
            saveButton.Enabled = firstNBox.TextLength > 0 &&
                LastNBox.TextLength > 0 &&
                address1Box.TextLength > 0 &&
                cityBox.TextLength > 0 &&
                stateBox.TextLength > 0 &&
                zipBox.TextLength > 0 && int.TryParse(zipBox.Text, out tempn) &&
                phoneBox.TextLength > 0 &&
                emailBox.TextLength > 0 &&
                receivedBox.TextLength > 0 && char.TryParse(receivedBox.Text, out tempc) && (tempc == 'Y' || tempc == 'N' || tempc == 'y' || tempc == 'n') &&
                diffCustomer;

           


        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear boxes
            firstNBox.Text = string.Empty;
            middleIBox.Text = string.Empty;
            LastNBox.Text = string.Empty;
            address1Box.Text = string.Empty;
            address2Box.Text = string.Empty;
            cityBox.Text = string.Empty;
            stateBox.Text = string.Empty;
            zipBox.Text = string.Empty;
            phoneBox.Text = string.Empty;
            emailBox.Text = string.Empty;
            receivedBox.Text = string.Empty;
            dateBox.ResetText();

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Store temp variables
            string fname = firstNBox.Text;
            string MI = middleIBox.Text;
            string lname = LastNBox.Text;
            string address = address1Box.Text + address2Box.Text;
            string city = cityBox.Text;
            string state = stateBox.Text;
            string zipCode = zipBox.Text;
            string phone = phoneBox.Text;
            string email = emailBox.Text;
            char POP;// Proof of Purchase
            DateTime dateRecieved;

            char.TryParse(receivedBox.Text, out POP);
            DateTime.TryParse(dateBox.Text, out dateRecieved);

            //Create customer
            c_List.Add(new customer(fname, MI, lname, address, city, state, zipCode, phone, email, POP, dateRecieved));

            //Add name and phone to list
            //Store full name
            string name = lname + " " + MI + " " + fname;
            string[] row = {name, phone};
            ListViewItem insrt = new ListViewItem(row);
            Customer_List.Items.Add(insrt);

            string temp = c_List.ElementAt(c_List.Count-1).getInfo();
            File.AppendAllText("CS6326Asg2.txt", temp + Environment.NewLine);


            //Write date to text file
            //Create an I/O stream
            //FileStream F = new FileStream("CS6326Asg2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //for (int i = 0; i < c_List.Count; i++)
            //{
            //    UnicodeEncoding uniencoding = new UnicodeEncoding();
            //    string temp = c_List.ElementAt(i).getInfo();
            //    byte[] entr = uniencoding.GetBytes(temp);

            //    //F.Write(entr, 0, entr.Length);
            //    File.AppendAllText("CS6326Asg2.txt", temp + Environment.NewLine);
            //}

            //F.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void MILabel_Click(object sender, EventArgs e)
        {

        }

        private void Customer_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_List_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//Create an object for person
public class customer
{
    string fname;
    string MI;
    string lname;
    string address;
    string city;
    string state;
    string zipCode;
    string phone;
    string email;
    char POP;// Proof of Purchase
    DateTime dateRecieved;

    public customer(string fn, string m, string ln, string ph)
    {
        fname = fn;
        MI = m;
        lname = ln;
        phone = ph;
    }

    public customer(string fn, string m, string ln, string addr, string c, string st,
        string zip, string ph, string em, char p, DateTime dr)
    {
        fname = fn;
        MI = m;
        lname = ln;
        address = addr;
        city = c;
        state = st;
        zipCode = zip;
        phone = ph;
        email = em;
        POP = p;
        dateRecieved = dr;
    }

    public void modifyPerson(string fn, string m, string ln, string addr, string c, string st,
        string zip, string ph, string em, char p, DateTime dr)
    {
        fname = fn;
        MI = m;
        lname = ln;
        address = addr;
        city = c;
        state = st;
        zipCode = zip;
        phone = ph;
        email = em;
        POP = p;
        dateRecieved = dr;
    }

    public string getInfo()
    {
        string result ="";

        result = fname + " " + MI + " " + lname + " " + 
            address + " " + city + " " + state + " " + zipCode + " " + 
            phone + " " + email + " " + email + " " + POP + " " + dateRecieved.ToString();

        return result;
    }

    public string getFName()
    {
        return fname;
    }
    public string getLName()
    {
        return lname;
    }
    public string getMI()
    {
        return MI;
    }
}
