using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WFMusic
{
    public partial class musicList : UserControl
    {
        public musicList()
        {
            InitializeComponent();

            //Appel API
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44387/");
            HttpResponseMessage reponse = client.GetAsync("api/Music").Result;
            var data = reponse.Content.ReadAsAsync<IEnumerable<data>>().Result;
            dataGridView1.DataSource = data;
            textBox1.Text = data.ToString();









            /*// Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form.
            this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();*/


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void musicList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*var reponse = await APICall.GetALL();
            textBox1.Text = reponse;*/
        }
    }
}
