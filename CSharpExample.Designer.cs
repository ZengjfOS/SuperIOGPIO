namespace InpOut32.Net
{
    partial class CSharpExample
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
            this.readByte = new System.Windows.Forms.Button();
            this.writeByte = new System.Windows.Forms.Button();
            this.portAddr = new System.Windows.Forms.TextBox();
            this.portValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.readMode = new System.Windows.Forms.Button();
            this.writeMode = new System.Windows.Forms.Button();
            this.readValue = new System.Windows.Forms.Button();
            this.writeValue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getPinValue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.setPinValue = new System.Windows.Forms.Button();
            this.pinIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pinValue = new System.Windows.Forms.TextBox();
            this.pinMode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // readByte
            // 
            this.readByte.Location = new System.Drawing.Point(15, 132);
            this.readByte.Name = "readByte";
            this.readByte.Size = new System.Drawing.Size(85, 23);
            this.readByte.TabIndex = 2;
            this.readByte.Text = "Read BYTE";
            this.readByte.UseVisualStyleBackColor = true;
            this.readByte.Click += new System.EventHandler(this.readByte_Click);
            // 
            // writeByte
            // 
            this.writeByte.Location = new System.Drawing.Point(118, 132);
            this.writeByte.Name = "writeByte";
            this.writeByte.Size = new System.Drawing.Size(86, 23);
            this.writeByte.TabIndex = 3;
            this.writeByte.Text = "Write BYTE";
            this.writeByte.UseVisualStyleBackColor = true;
            this.writeByte.Click += new System.EventHandler(this.writeByte_Click);
            // 
            // portAddr
            // 
            this.portAddr.Location = new System.Drawing.Point(19, 56);
            this.portAddr.Name = "portAddr";
            this.portAddr.Size = new System.Drawing.Size(182, 21);
            this.portAddr.TabIndex = 0;
            this.portAddr.Text = "2E";
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(19, 99);
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(182, 21);
            this.portValue.TabIndex = 1;
            this.portValue.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Address (Hex)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port Value (Hex)";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 120);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 7;
            // 
            // readMode
            // 
            this.readMode.Location = new System.Drawing.Point(15, 161);
            this.readMode.Name = "readMode";
            this.readMode.Size = new System.Drawing.Size(85, 23);
            this.readMode.TabIndex = 4;
            this.readMode.Text = "Read Mode";
            this.readMode.UseVisualStyleBackColor = true;
            this.readMode.Click += new System.EventHandler(this.readMode_Click);
            // 
            // writeMode
            // 
            this.writeMode.Location = new System.Drawing.Point(118, 161);
            this.writeMode.Name = "writeMode";
            this.writeMode.Size = new System.Drawing.Size(86, 23);
            this.writeMode.TabIndex = 5;
            this.writeMode.Text = "Write Mode";
            this.writeMode.UseVisualStyleBackColor = true;
            this.writeMode.Click += new System.EventHandler(this.writeMode_Click);
            // 
            // readValue
            // 
            this.readValue.Location = new System.Drawing.Point(16, 191);
            this.readValue.Name = "readValue";
            this.readValue.Size = new System.Drawing.Size(84, 23);
            this.readValue.TabIndex = 6;
            this.readValue.Text = "Read Value";
            this.readValue.UseVisualStyleBackColor = true;
            this.readValue.Click += new System.EventHandler(this.readValue_Click);
            // 
            // writeValue
            // 
            this.writeValue.Location = new System.Drawing.Point(118, 190);
            this.writeValue.Name = "writeValue";
            this.writeValue.Size = new System.Drawing.Size(86, 23);
            this.writeValue.TabIndex = 7;
            this.writeValue.Text = "Write Value";
            this.writeValue.UseVisualStyleBackColor = true;
            this.writeValue.Click += new System.EventHandler(this.writeValue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.writeValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.readValue);
            this.groupBox1.Controls.Add(this.readByte);
            this.groupBox1.Controls.Add(this.writeMode);
            this.groupBox1.Controls.Add(this.writeByte);
            this.groupBox1.Controls.Add(this.readMode);
            this.groupBox1.Controls.Add(this.portAddr);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.portValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 226);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug Tools";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getPinValue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.setPinValue);
            this.groupBox3.Controls.Add(this.pinIndex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pinValue);
            this.groupBox3.Controls.Add(this.pinMode);
            this.groupBox3.Location = new System.Drawing.Point(219, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 201);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pin Info";
            // 
            // getPinValue
            // 
            this.getPinValue.Location = new System.Drawing.Point(106, 160);
            this.getPinValue.Name = "getPinValue";
            this.getPinValue.Size = new System.Drawing.Size(86, 23);
            this.getPinValue.TabIndex = 12;
            this.getPinValue.Text = "Get Value";
            this.getPinValue.UseVisualStyleBackColor = true;
            this.getPinValue.Click += new System.EventHandler(this.getPinValue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pin Index (Hex)";
            // 
            // setPinValue
            // 
            this.setPinValue.Location = new System.Drawing.Point(9, 160);
            this.setPinValue.Name = "setPinValue";
            this.setPinValue.Size = new System.Drawing.Size(84, 23);
            this.setPinValue.TabIndex = 11;
            this.setPinValue.Text = "Set Value";
            this.setPinValue.UseVisualStyleBackColor = true;
            this.setPinValue.Click += new System.EventHandler(this.setPinValue_Click);
            // 
            // pinIndex
            // 
            this.pinIndex.Location = new System.Drawing.Point(10, 36);
            this.pinIndex.Name = "pinIndex";
            this.pinIndex.Size = new System.Drawing.Size(182, 21);
            this.pinIndex.TabIndex = 8;
            this.pinIndex.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pin Value (Hex)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pin Mode (Hex)";
            // 
            // pinValue
            // 
            this.pinValue.Location = new System.Drawing.Point(9, 122);
            this.pinValue.Name = "pinValue";
            this.pinValue.Size = new System.Drawing.Size(182, 21);
            this.pinValue.TabIndex = 10;
            this.pinValue.Text = "0";
            // 
            // pinMode
            // 
            this.pinMode.Location = new System.Drawing.Point(10, 79);
            this.pinMode.Name = "pinMode";
            this.pinMode.Size = new System.Drawing.Size(182, 21);
            this.pinMode.TabIndex = 9;
            this.pinMode.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 201);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 7;
            // 
            // CSharpExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CSharpExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InpOut SuperIO C# Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSharpExample_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readByte;
        private System.Windows.Forms.Button writeByte;
        private System.Windows.Forms.TextBox portAddr;
        private System.Windows.Forms.TextBox portValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button readMode;
        private System.Windows.Forms.Button writeMode;
        private System.Windows.Forms.Button readValue;
        private System.Windows.Forms.Button writeValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button getPinValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button setPinValue;
        private System.Windows.Forms.TextBox pinIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinValue;
        private System.Windows.Forms.TextBox pinMode;
        private System.Windows.Forms.Label label4;
    }
}

