using System;
using System.Windows.Forms;

namespace Kruskal_Graphs
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // Create new links using the Add method of the LinkCollection class.
            // Underline the appropriate words in the LinkLabel's Text property.
            // all be underlined and behave as hyperlinks.
            // First check that the Text property is long enough to accommodate
            // the desired hyperlinked areas.  If it's not, don't add hyperlinks.

            if (this.linkLabelS1.Text.Length >= 19)
            {
                // Below Code mean's this.linkLabelS1.Links.Add(0, 19, "www.Azarabadegan.net");
                this.linkLabelS1.Links[0].LinkData = "www.Azarabadegan.net";
                this.linkLabelS2.Links[0].LinkData = "www.Azerbaycan.ir";
            }
            if (this.linkLabelE.Text.Length >= 20)
            {
                this.linkLabelE.Links[0].LinkData = "mailto:Behzad.kh.2006@Gmail.com";
            }
        }

        private void linkLabelS1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.linkLabelS1.Links[linkLabelS1.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target);
            }
        }

        private void linkLabelS2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            this.linkLabelS2.Links[linkLabelS2.Links.IndexOf(e.Link)].Visited = true;

            // Display the appropriate link based on the value of the 
            // LinkData property of the Link object.
            string target2 = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target2 && target2.StartsWith("www"))
            {
                System.Diagnostics.Process.Start(target2);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target2);
            }
        }

        private void linkLabelE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelE.Links[linkLabelE.Links.IndexOf(e.Link)].Visited = true;
            string target3 = e.Link.LinkData as string;
            if (null != target3)
            {
                System.Diagnostics.Process.Start(target3);
            }
            else
            {
                MessageBox.Show("Item clicked: " + target3);
            }
        }

        private void FormAbout_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
