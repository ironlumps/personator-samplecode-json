using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace PersonJSON
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Initialize the request through the request form
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(RestJson());
            request.Method = "GET";
            request.Accept = "application/json";

            try
            {
               // Sends the request form to the webservice to get a response
                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                // The string is the resoonse in JSON format
                string jsonResponse = sr.ReadToEnd();
                
                // Must close and dispose of stream reader to not overload the system memory
                sr.Close();
                sr.Dispose();

                try
                {
                    // Deserializes the JSON format with NewtonSoft
                    Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(jsonResponse);
                    // Creates the reocrd array from the record data of the deserialized JSON
                    Record[] records = ro.Records;

                    // Clears the outbox after each time through to clean the results
                    outputBox.Clear();
                    outputBox.AppendText(records[0].ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
     
               
             }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // The REST request that the personator program understands with the text from the windows form substituted in
        private String RestJson()
        {
            // This request for JSON is found at: http://wiki.melissadata.com/index.php?title=Personator%3AREST_JSON 

            string temp = $"https://personator.melissadata.net/v3/WEB/ContactVerify/doContactVerify?t ={ txtTransRef.Text}" + 
                $"&id={ txtCustomerID.Text}&act={ SetActions()}&opt={ SetOptions()}&a1={ txtAddress.Text}&a2 ={txtAddress2.Text}" + 
                $"&city={txtCity.Text}&comp={ txtCompany.Text}&ctry={ txtCountry.Text}&email={ txtEmail.Text}&first={ txtFirstName.Text}" + 
                $"&full={ txtFullName.Text}&last ={txtLastName.Text}" + 
                $"&phone={ txtPhone.Text}&postal={ txtZipCode.Text}&state ={ txtState.Text}&format=JSON";

            return temp;
        }

        // This method sets the options to add to the string that gets sent to Personator for every additonal option
        public string SetOptions()
        {
            string options = "";

            if (chkUsePreferredCity.Checked)
                options += "UsePreferredCity:on;";

            if (chkAdvancedAddressCorrection.Checked)
                options += "AdvancedAddressCorrection:on;";

            switch (comboBoxCentricHint.SelectedIndex)
            {
                case 0: options += "CentricHint:Auto;"; break;
                case 1: options += "CentricHint:Address;"; break;
                case 2: options += "CentricHint:Phone;"; break;
                case 3: options += "CentricHint:Email;"; break;
                default:
                    break;
            }

            switch (comboBoxAppend.SelectedIndex)
            {
                case 0: options += "Append:CheckError;"; break;
                case 1: options += "Append:Always;"; break;
                case 2: options += "Append:Blank;"; break;
            }

            // Must trim the end of the string in order for the right string to go through 
            options = options.TrimEnd(';');
            return options;
        }

        // This Method sets the actions to add to the string that gets sent to Personator for every addditional check
        public string SetActions()
        {
            string actions = "";

            if (chkActionCheck.Checked)
                actions += "Check,";
            if (chkActionVerify.Checked)
                actions += "Verify,";
            if (chkActionAppend.Checked)
                actions += "Append,";
            if (chkActionMove.Checked)
                actions += "Move,";

            // Must trim the end of string in order for the right string to go through
            actions = actions.TrimEnd(',');

            return actions;
        }

    
    }
}
