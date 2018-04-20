using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kruskal_Graphs
{
    public partial class FormK : Form
    {
        public FormK()
        {
            InitializeComponent();
        }

        private void FormK_Load(object sender, EventArgs e)
        {
            FormPic Pic = new FormPic();
            Pic.ShowDialog();
            toolStriptxtNumEdge.Select();
            toolStriptxtNumEdge.Focus();
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripBtnAbout_Click(object sender, EventArgs e)
        {
            FormAbout About = new FormAbout();
            About.ShowDialog();
        }

        // Statice and public int for number of Edge
        public static int Edge;
        //Creat TextBox and ... In Dynamic Form  -------------------------------------------------
        public String[,] strV;
        public TextBox[,] txtV;
        public TextBox[] txtWeight;
        public int[] intWeight;
        public Label[,] lblV;
        public Label[] lblSpace;
        public Label[] lblAction;
        public Label[,] lblverteX;
        //----------------------------------------------------------------------------------------
        public bool ExistPage = false;
        private bool nonNumberEntered = false;

        private void toolStriptxtNumEdge_KeyDown(object sender, KeyEventArgs e)
        {
            //Creat TextBox and ... In Dynamic Form ***********************************************
            if (e.KeyCode == Keys.Enter && toolStriptxtNumEdge.Text != "Number of Edge")
            {
                // For First Page or Other New Page =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                if (ExistPage == false)
                    ExistPage = true;
                else
                {
                    string buffer = toolStriptxtNumEdge.Text.ToString();
                    toolStripBtnClean_Click(sender, e);
                    ExistPage = true;
                    toolStriptxtNumEdge.Text = buffer;
                    toolStriptxtNumEdge.ForeColor = Color.Black;
                }
                //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                Edge = int.Parse(toolStriptxtNumEdge.Text.ToString());
                toolStripBtnSolve.Enabled = true;
                // Give Amount of Number for Dynamic Array's ...................
                this.strV = new string[2, Edge];
                this.txtV = new TextBox[2, Edge];     // Need to Controls.Add
                this.txtWeight = new TextBox[Edge];   // Need to Controls.Add
                this.intWeight = new int[Edge];
                this.lblV = new Label[2, Edge];       // Need to Controls.Add
                this.lblSpace = new Label[Edge];      // Need to Controls.Add
                this.lblAction = new Label[Edge];     // Need to Controls.Add
                this.lblverteX = new Label[2, Edge];  // Need to Controls.Add
                //......................................................
                for (int i = 0; i < Edge; i++)
                {
                    //Creat lblV[0,i] ===> '('       
                    this.lblV[0, i] = new Label();
                    this.lblV[0, i].Size = new Size(14, 20);
                    this.lblV[0, i].Font = new Font(lblV[0, i].Font.Name, 12);
                    this.lblV[0, i].Text = "(";
                    this.lblV[0, i].Location = new Point(12, (i * 26) + 119);
                    this.Controls.Add(this.lblV[0, i]);

                    //Creat lblV[1,i] ===> ')'
                    this.lblV[1, i] = new Label();
                    this.lblV[1, i].Size = new Size(14, 20);
                    this.lblV[1, i].Font = new Font(lblV[1, i].Font.Name, 12);
                    this.lblV[1, i].Text = ")";
                    this.lblV[1, i].Location = new Point(123, (i * 26) + 119);
                    this.Controls.Add(this.lblV[1, i]);

                    //Craet lblSpace[i] ===> ','
                    this.lblSpace[i] = new Label();
                    this.lblSpace[i].Size = new Size(13, 20);
                    this.lblSpace[i].Font = new Font(lblSpace[i].Font.Name, 12);
                    this.lblSpace[i].Text = ",";
                    this.lblSpace[i].Location = new Point(67, (i * 26) + 123);
                    this.Controls.Add(this.lblSpace[i]);

                    //Creat lblverteX[0,i] ===> 'v'
                    this.lblverteX[0, i] = new Label();
                    this.lblverteX[0, i].Size = new Size(16, 20);
                    this.lblverteX[0, i].Font = new Font(lblverteX[0, i].Font.Name, 12);
                    this.lblverteX[0, i].Text = "v";
                    this.lblverteX[0, i].Location = new Point(24, (i * 26) + 121);
                    this.Controls.Add(this.lblverteX[0, i]);

                    //Creat lblverteX[1,i] ===> 'v'
                    this.lblverteX[1, i] = new Label();
                    this.lblverteX[1, i].Size = new Size(16, 20);
                    this.lblverteX[1, i].Font = new Font(lblverteX[1, i].Font.Name, 12);
                    this.lblverteX[1, i].Text = "v";
                    this.lblverteX[1, i].Location = new Point(77, (i * 26) + 121);
                    this.Controls.Add(this.lblverteX[1, i]);

                    //Creat txtV[0,i] ===> (v1, )
                    this.txtV[0, i] = new TextBox();
                    this.txtV[0, i].Location = new Point(38, (i * 26) + 121);
                    this.txtV[0, i].Size = new Size(31, 20);
                    this.txtV[0, i].MaxLength = 6;
                    this.txtV[0, i].TextAlign = HorizontalAlignment.Center;
                    this.txtV[0, i].BackColor = Color.LightBlue;
                    this.Controls.Add(this.txtV[0, i]);

                    //Creat txtV[1,i] ===> ( ,V2)
                    this.txtV[1, i] = new TextBox();
                    this.txtV[1, i].Location = new Point(90, (i * 26) + 121);
                    this.txtV[1, i].Size = new Size(31, 20);
                    this.txtV[1, i].MaxLength = 6;
                    this.txtV[1, i].TextAlign = HorizontalAlignment.Center;
                    this.txtV[1, i].BackColor = Color.LightBlue;
                    this.Controls.Add(this.txtV[1, i]);

                    //Creat txtWeight[i] ==> [Edge Amount]
                    this.txtWeight[i] = new TextBox();
                    this.txtWeight[i].Location = new Point(255, (i * 26) + 121);
                    this.txtWeight[i].Size = new Size(46, 20);
                    this.txtWeight[i].TextAlign = HorizontalAlignment.Center;
                    this.txtWeight[i].BackColor = Color.LightGreen;
                    this.Controls.Add(this.txtWeight[i]);
                }
            }
            //**************************************************************************************
            if (e.Shift == true && toolStriptxtNumEdge.Text == "Number of Edge")
            {
                toolStriptxtNumEdge.Text = string.Empty;
                toolStriptxtNumEdge.ForeColor = Color.Black;
            }
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (toolStriptxtNumEdge.Text == "Number of Edge")
                {
                    toolStriptxtNumEdge.Text = string.Empty;
                    toolStriptxtNumEdge.ForeColor = Color.Black;
                }
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void toolStriptxtNumEdge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
            if (nonNumberEntered == false)
            {
                if (toolStriptxtNumEdge.Text == "Number of Edge")
                {
                    toolStriptxtNumEdge.Text = string.Empty;
                    toolStriptxtNumEdge.ForeColor = Color.Black;
                }
            }
        }

        private void toolStriptxtNumEdge_KeyUp(object sender, KeyEventArgs e)
        {
            if (toolStriptxtNumEdge.Text == "")
            {
                toolStriptxtNumEdge.ForeColor = Color.DarkGray;
                toolStriptxtNumEdge.Text = "Number of Edge";
            }
        }

        private void toolStriptxtNumEdge_Click(object sender, EventArgs e)
        {
            if (toolStriptxtNumEdge.Text == "Number of Edge")
            {
                toolStriptxtNumEdge.Text = string.Empty;
                toolStriptxtNumEdge.ForeColor = Color.Black;
            }
        }

        private void toolStriptxtNumEdge_MouseLeave(object sender, EventArgs e)
        {
            if (toolStriptxtNumEdge.Text == "")
            {
                toolStriptxtNumEdge.ForeColor = Color.DarkGray;
                toolStriptxtNumEdge.Text = "Number of Edge";
            }
        }

        private void toolStriptxtNumEdge_TextChanged(object sender, EventArgs e)
        {
            if (toolStriptxtNumEdge.Text != "Number of Edge" && toolStriptxtNumEdge.Text != "")
            {
                char[] Spil = toolStriptxtNumEdge.Text.ToCharArray();
                for (int i = 0; i < Spil.Length; i++)
                {
                    if (Spil[i] == '0' || Spil[i] == '1' || Spil[i] == '2' || Spil[i] == '3' || Spil[i] == '4' ||
                        Spil[i] == '5' || Spil[i] == '6' || Spil[i] == '7' || Spil[i] == '8' || Spil[i] == '9')
                        continue;
                    else
                    {
                        MessageBox.Show("Please Enter Just Number. This TextBox don't Accept Other Key!" +
                            "\nلطفاً فقط عدد وارد کنید. این فیلد کلید دیگری را قبول نمی کند ", "Enter InCorrect Key"
                            , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //Undo Text -------------
                        // Declare a TextBox object and
                        // set it to the ActiveControl
                        TextBox objTextBox = (TextBox)this.ActiveControl;
                        // Undo the last operation
                        objTextBox.Undo();
                        if (toolStriptxtNumEdge.Text == "")
                        {
                            toolStriptxtNumEdge.ForeColor = Color.DarkGray;
                            toolStriptxtNumEdge.Text = "Number of Edge";
                        }
                        //-----------------------
                        break;
                    }
                }
                return;
            }
        }

        private void toolStripBtnClean_Click(object sender, EventArgs e)
        {
            ExistPage = false;
            for (int i = 0; i < Edge; i++)
            {
                this.Controls.Remove(this.txtV[0, i]);
                this.Controls.Remove(this.txtV[1, i]);
                this.Controls.Remove(this.txtWeight[i]);
                this.Controls.Remove(this.lblAction[i]);
                this.Controls.Remove(this.lblSpace[i]);
                this.Controls.Remove(this.lblV[0, i]);
                this.Controls.Remove(this.lblV[1, i]);
                this.Controls.Remove(this.lblverteX[0, i]);
                this.Controls.Remove(this.lblverteX[1, i]);
                this.Controls.Remove(this.lblAction[i]);
            }
            toolStriptxtNumEdge.Text = "Number of Edge";
            toolStriptxtNumEdge.ForeColor = Color.DarkGray;
            toolStripBtnSolve.Enabled = false;
        }
        public int n = 0; // for Number of Vertex
        private void toolStripBtnSolve_Click(object sender, EventArgs e)
        {
            //Check All TextBox and Saved ================================================================================================
            for (int i = 0; i < Edge; i++)
            {
                //Check and Save info of Textbox V ==> (V, );
                if (txtV[0, i].Text != "")
                    strV[0, i] = txtV[0, i].Text.ToString();
                else
                {
                    MessageBox.Show("The TextBox in Line " + (i + 1) + " is Empty!", "Empty Error");
                    txtV[0, i].Select();
                    txtV[0, i].Focus();
                    return;
                }
                //Check and Save info of Textbox V ==> ( ,V);
                if (txtV[1, i].Text != "")
                    strV[1, i] = txtV[1, i].Text.ToString();
                else
                {
                    MessageBox.Show("The TextBox in Line " + (i + 1) + " is Empty!", "Empty Error");
                    txtV[1, i].Select();
                    txtV[1, i].Focus();
                    return;
                }
                //Check and Save info of Textbox Weight to intWeight if is integer
                if (int.TryParse(txtWeight[i].Text.ToString(), out intWeight[i]))
                    intWeight[i] = int.Parse(txtWeight[i].Text.ToString());
                else
                {
                    MessageBox.Show("The TextBox in Line " + (i + 1) + " is incorrect! \nPlease Change it.", "Entry Number Error");
                    txtWeight[i].Select();
                    txtWeight[i].Focus();
                    return;
                }
            }//==========================================================================================================================

            //Sort Edge by weight
            SortbyWeight();

            //Find Number of Vertex and put in n
            //Compare strV[0, i] by other
            Boolean Repeat;
            for (int i = 0; i < Edge; i++)
            {
                Repeat = false;
                for (int j = i; j + 1 < Edge; j++)
                {
                    if (string.Compare(strV[0, i], strV[0, j + 1], true) == 0)
                    {
                        Repeat = true;
                        break;
                    }
                    if (string.Compare(strV[0, i], strV[1, j], true) == 0)
                    {
                        Repeat = true;
                        break;
                    }
                }
                if (string.Compare(strV[0, i], strV[1, Edge - 1], true) == 0)
                {
                    Repeat = true;
                    break;
                }

                if (Repeat == false) n++;
            }
            //Compare strV[1, i] by other in strV[1, i+1]
            for (int i = 0; i < Edge; i++)
            {
                Repeat = false;
                for (int j = i; j + 1 < Edge; j++)
                {
                    if (string.Compare(strV[1, i], strV[1, j + 1], true) == 0)
                    {
                        Repeat = true;
                        break;
                    }
                }

                if (Repeat == false) n++;
            }
            // Give Amount for strComplex
            strComplex = new string[n, n]; //Because Maximum Number of Complex in Array is Each a Vertex for self ==> [n, ]
            //And Maximum Number of Vertex in One Complex is Number of All Vertex ==> [ ,n]
            // Solve by Kruskal Algorithm ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Boolean[] Action = new bool[Edge];
            int EdgeFind;
            int index;
            // Peak number of EdgeFind (Edge in Spanning Tree) is one less than All Vertext Number (EdgeFind < n)
            // And maximum Number of index Can Only Edge-1  ==> (index < Edge) 
            for (index = 0, EdgeFind = 0; EdgeFind < n && index < Edge; index++)
            {
                if (string.Compare(strV[0, index], strV[1, index], true) == 0)//this Edge is only a point and no edge (Example Edge(V1,V1))
                {
                    Action[index] = false;
                    continue;
                }
                else
                {
                    int p = find(strV[0, index]); //Send Vertex to find function and receive Complex Name's
                    int q = find(strV[1, index]);
                    if (p != q)
                    {
                        Merge(p, q); //Merge 2 two Complex to One Complex (2 in 1) P <-- q   or   q <-- p
                        EdgeFind++;  //Kruskal found best edge and ... (Next Line Direction)
                        Action[index] = true; // The Best finded edge Added to Kruskal's List
                        continue;
                    }
                    else
                    {
                        Action[index] = false;
                        continue;
                    }
                }
            }// End of While
            while (Edge > index)  //Other Action Fill by false
            {
                Action[index] = false;
            }

            //Print Action -+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-
            for (int d = 0; d < Edge; d++)
            {
                this.lblAction[d] = new Label();
                this.lblAction[d].Font = new Font(lblAction[d].Font.Name, 12);
                this.lblAction[d].Location = new Point(431, (d * 26) + 121);
                if (Action[d] == true)
                    this.lblAction[d].Text = "Accepted";
                else
                {
                    this.lblAction[d].Text = "Rejected";
                    this.lblAction[d].ForeColor = Color.LightCoral;
                }
                this.Controls.Add(this.lblAction[d]);
            }

            //-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+--+-+-+-+-+-+-

            //END Kruskal's Algorithm
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }

        //Creat Complex Array for Vertex (this Variable has amount in toolStripBtnSolve_Click(sender, e) function)
        //Worst case for strComplex 2D Array is on time which Each two vertex be a complex (strComplex[n/2, n]) n = Number of All Vertex
        public static string[,] strComplex;
        private void Merge(int p, int q)
        {
            int indexEmpty = -1; //for Save Empty Place Address
            //for Easy find Complex, Merge Complex by Elder (big) number to lower Complex number
            if (p > q)
            {
                for (int i = 0; i < n; i++)
                {
                    if (strComplex[q, i] == null) // find empty place in lower complex q for add continuation it
                    {
                        indexEmpty = i;
                        break;
                    }
                }
                for (int i = 0; strComplex[p, i] != null; i++, indexEmpty++)
                {
                    strComplex[q, indexEmpty] = strComplex[p, i];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (strComplex[p, i] == null) // find empty place in lower complex q for add continuation it
                    {
                        indexEmpty = i;
                        break;
                    }
                }
                for (int i = 0; strComplex[q, i] != null; i++, indexEmpty++)
                {
                    strComplex[p, indexEmpty] = strComplex[q, i];
                }
            }
        }

        private int find(string StrVertex)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (strComplex[i, j] == StrVertex)
                        return i; //Find Vertex Complex and give it to Kruskal's function
                    if (strComplex[i, j] == null) break;
                }
            //Not find any complex for sending vertex
            //Create a Complex for vertex
            for (int i = 0; i < n; i++)  // find empty complex (Empty place)
                if (strComplex[i, 0] == null)
                {
                    strComplex[i, 0] = StrVertex;
                    return i;
                }
            return -1; //this code don't run Ever time (Error)
        }

        private void SortbyWeight()
        {
            //Sort All Array's by Bubble Algorithm in intWeight[] Array's
            for (int i = Edge - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                {
                    if (intWeight[j] > intWeight[j + 1]) // Change place
                    {
                        int bufferWeight = intWeight[j];
                        string bufferStrV0 = strV[0, j];
                        string bufferStrV1 = strV[1, j];

                        intWeight[j] = intWeight[j + 1];
                        strV[0, j] = strV[0, j + 1];
                        strV[1, j] = strV[1, j + 1];

                        intWeight[j + 1] = bufferWeight;
                        strV[0, j + 1] = bufferStrV0;
                        strV[1, j + 1] = bufferStrV1;
                    }
                    else continue;
                }
            //Clean All TextBox and Fill Sort them
            for (int i = 0; i < Edge; i++)
            {
                txtV[0, i].Text = strV[0, i];
                txtV[1, i].Text = strV[1, i];
                txtWeight[i].Text = intWeight[i].ToString();
            }
        }

        private void toolStripBtnHelp_Click(object sender, EventArgs e)
        {
            string strPathPDF = @"Resources\Kruskal graphs Help.pdf";
            System.Diagnostics.Process.Start(strPathPDF);
        }        
    }
}
