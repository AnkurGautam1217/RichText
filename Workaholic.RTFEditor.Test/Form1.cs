using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Workaholic.RTFEditor.Test
{
    public partial class Form1 : Form
    {
        static string textBoxText;
        public Form1()
        {
            InitializeComponent();
        }

        private void rtfEditor1_OnSave(object sender, RTFEditorEventArgs e)
        {
            e.Cancel = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] stringSeparators = new string[] { "pard" };
            //string stringSeparators = "pard" ;
            string[] postedData =  rtfEditor1.DocumentRtf.Split(stringSeparators, StringSplitOptions.None);
            List<string> seperatedData = new List<string>();
            StringBuilder builder = new StringBuilder();

            for(int i=1; i<=postedData.Length -1 ;i++)
            {
                if(postedData[i].Contains("B7"))
                {
                    string[] bulletSeparators = new string[] { @"\par" };
                    string[] bulletSeperated = postedData[i].Replace(@"{\pntext\f1\'B7\tab}", "").Replace(@"{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}", "").Replace("\r\n","").Split(bulletSeparators, StringSplitOptions.None);
                    foreach (var seperatedval in bulletSeperated)
                    {
                        if (seperatedval != "\\" && seperatedval.Length > 0)
                        {
                            builder.Append(seperatedval);
                            builder.Append("$$$$$");
                        }
                    }
                    seperatedData.Add(builder.ToString());
                }
                else 
                {
                    string[] paraSeparators = new string[] { "\\par\r\n" };
                    string[] paraSeperated = postedData[i].Replace("\\fs20", "").Replace("}\r\n", "").Split(paraSeparators, StringSplitOptions.None);
                    foreach (var seperatedval in paraSeperated)
                    {
                        if (seperatedval != "\\" && seperatedval.Length > 0)
                        {
                            seperatedData.Add(seperatedval);
                        }
                    }
                }
            }
            rtfEditor2.DocumentRtf = rtfEditor1.DocumentRtf;



            MessageBox.Show(rtfEditor1.DocumentText);
        }

        private void rtfEditor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                rtfEditor1.DocumentRtf += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }

        private void rtfEditor1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void rtfEditor1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rtfEditor1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                rtfEditor1.DocumentRtf += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }
    }
}