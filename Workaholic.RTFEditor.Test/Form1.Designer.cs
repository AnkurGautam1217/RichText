namespace Workaholic.RTFEditor.Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtfEditor2 = new Workaholic.RTFEditor.RTFEditor();
            this.rtfEditor1 = new Workaholic.RTFEditor.RTFEditor();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 91);
            this.textBox1.TabIndex = 3;
            // 
            // rtfEditor2
            // 
            this.rtfEditor2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.rtfEditor2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.rtfEditor2.DefaultFontColor = System.Drawing.Color.Black;
            this.rtfEditor2.DefaultFontFamily = "Arial";
            this.rtfEditor2.DefaultFontSize = 8;
            this.rtfEditor2.DefaultWordWrap = false;
            this.rtfEditor2.DocumentRtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\\" +
    "viewkind4\\uc1\\pard\\fs17\\par\r\n}\r\n";
            this.rtfEditor2.DocumentText = "";
            this.rtfEditor2.EnableNewDocument = false;
            this.rtfEditor2.EnableOpenDocument = false;
            this.rtfEditor2.EnableSaveDocument = false;
            this.rtfEditor2.FilePanelVisible = false;
            this.rtfEditor2.Location = new System.Drawing.Point(0, 206);
            this.rtfEditor2.MenuVisible = false;
            this.rtfEditor2.Name = "rtfEditor2";
            this.rtfEditor2.ReadOnly = false;
            this.rtfEditor2.Size = new System.Drawing.Size(300, 130);
            this.rtfEditor2.TabIndex = 2;
            this.rtfEditor2.ToolStripVisible = true;
            // 
            // rtfEditor1
            // 
            this.rtfEditor1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.rtfEditor1.DefaultFontColor = System.Drawing.Color.Black;
            this.rtfEditor1.DefaultFontFamily = "Arial";
            this.rtfEditor1.DefaultFontSize = 10;
            this.rtfEditor1.DefaultWordWrap = false;
            this.rtfEditor1.DocumentRtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\\" +
    "viewkind4\\uc1\\pard\\fs20\\par\r\n}\r\n";
            this.rtfEditor1.DocumentText = "";
            this.rtfEditor1.EnableNewDocument = false;
            this.rtfEditor1.EnableOpenDocument = false;
            this.rtfEditor1.EnableSaveDocument = false;
            this.rtfEditor1.FilePanelVisible = false;
            this.rtfEditor1.Location = new System.Drawing.Point(0, 0);
            this.rtfEditor1.MenuVisible = false;
            this.rtfEditor1.Name = "rtfEditor1";
            this.rtfEditor1.ReadOnly = false;
            this.rtfEditor1.Size = new System.Drawing.Size(746, 171);
            this.rtfEditor1.TabIndex = 0;
            this.rtfEditor1.ToolStripVisible = true;
            this.rtfEditor1.OnDocumentSave += new Workaholic.RTFEditor.RTFEditorOnSave(this.rtfEditor1_OnSave);
            this.rtfEditor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfEditor1_KeyDown);
            this.rtfEditor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfEditor1_KeyPress);
            this.rtfEditor1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtfEditor1_KeyUp);
            this.rtfEditor1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.rtfEditor1_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(758, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtfEditor2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtfEditor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RTFEditor rtfEditor1;
        private System.Windows.Forms.Button button1;
        private RTFEditor rtfEditor2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

