namespace TextToSpeech.View.WinForm
{
    partial class frm_Main_Speech
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
            this.txt_Speech = new System.Windows.Forms.TextBox();
            this.btn_Speech = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Recognize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Speech
            // 
            this.txt_Speech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Speech.Location = new System.Drawing.Point(12, 12);
            this.txt_Speech.Multiline = true;
            this.txt_Speech.Name = "txt_Speech";
            this.txt_Speech.Size = new System.Drawing.Size(407, 190);
            this.txt_Speech.TabIndex = 0;
            // 
            // btn_Speech
            // 
            this.btn_Speech.Location = new System.Drawing.Point(42, 24);
            this.btn_Speech.Name = "btn_Speech";
            this.btn_Speech.Size = new System.Drawing.Size(117, 23);
            this.btn_Speech.TabIndex = 2;
            this.btn_Speech.Text = "Speech";
            this.btn_Speech.UseVisualStyleBackColor = true;
            this.btn_Speech.Click += new System.EventHandler(this.Btn_Speech_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(42, 53);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save To File(*.Wav)";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Recognize);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speech To Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Recognize From Mic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_Recognize
            // 
            this.btn_Recognize.Location = new System.Drawing.Point(42, 24);
            this.btn_Recognize.Name = "btn_Recognize";
            this.btn_Recognize.Size = new System.Drawing.Size(117, 23);
            this.btn_Recognize.TabIndex = 6;
            this.btn_Recognize.Text = "Recognize From Mic";
            this.btn_Recognize.UseVisualStyleBackColor = true;
            this.btn_Recognize.Click += new System.EventHandler(this.Btn_Recognize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Speech);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Location = new System.Drawing.Point(218, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text To Speech";
            // 
            // frm_Main_Speech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Speech);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Speech";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_Speech;
        public System.Windows.Forms.Button btn_Speech;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_Recognize;
    }
}

