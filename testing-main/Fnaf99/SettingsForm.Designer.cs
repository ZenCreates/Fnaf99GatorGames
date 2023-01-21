
namespace Fnaf99
{
    partial class SettingsForm
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
            this.aes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exeName = new System.Windows.Forms.TextBox();
            this.unrealVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pakPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sb = new System.Windows.Forms.Button();
            this.hw = new System.Windows.Forms.Button();
            this.mv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aes
            // 
            this.aes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.aes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aes.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aes.ForeColor = System.Drawing.Color.White;
            this.aes.Location = new System.Drawing.Point(165, 12);
            this.aes.Name = "aes";
            this.aes.Size = new System.Drawing.Size(485, 29);
            this.aes.TabIndex = 0;
            this.aes.Text = "AESKey";
            this.aes.TextChanged += new System.EventHandler(this.aes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "AES Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exeName
            // 
            this.exeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.exeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exeName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exeName.ForeColor = System.Drawing.Color.White;
            this.exeName.Location = new System.Drawing.Point(261, 83);
            this.exeName.Name = "exeName";
            this.exeName.Size = new System.Drawing.Size(201, 29);
            this.exeName.TabIndex = 2;
            this.exeName.Text = "AESKey";
            this.exeName.Visible = false;
            this.exeName.TextChanged += new System.EventHandler(this.exeName_TextChanged);
            // 
            // unrealVersion
            // 
            this.unrealVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unrealVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.unrealVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unrealVersion.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unrealVersion.ForeColor = System.Drawing.Color.White;
            this.unrealVersion.Location = new System.Drawing.Point(261, 115);
            this.unrealVersion.Name = "unrealVersion";
            this.unrealVersion.Size = new System.Drawing.Size(201, 29);
            this.unrealVersion.TabIndex = 3;
            this.unrealVersion.Text = "AESKey";
            this.unrealVersion.Visible = false;
            this.unrealVersion.TextChanged += new System.EventHandler(this.unrealVersion_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exe Name";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "UE4 Version";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pakPath
            // 
            this.pakPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.pakPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pakPath.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pakPath.ForeColor = System.Drawing.Color.White;
            this.pakPath.Location = new System.Drawing.Point(165, 47);
            this.pakPath.Name = "pakPath";
            this.pakPath.Size = new System.Drawing.Size(485, 29);
            this.pakPath.TabIndex = 6;
            this.pakPath.Text = "AESKey";
            this.pakPath.TextChanged += new System.EventHandler(this.pakPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path to pak";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Location = new System.Drawing.Point(573, 107);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(77, 34);
            this.settingBtn.TabIndex = 11;
            this.settingBtn.Text = "Apply";
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(6, 114);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(90, 32);
            this.aboutBtn.TabIndex = 13;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(656, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(656, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sb
            // 
            this.sb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.sb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sb.ForeColor = System.Drawing.Color.White;
            this.sb.Location = new System.Drawing.Point(656, 11);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(41, 29);
            this.sb.TabIndex = 16;
            this.sb.Text = "SB";
            this.sb.UseVisualStyleBackColor = false;
            this.sb.Click += new System.EventHandler(this.sb_Click);
            // 
            // hw
            // 
            this.hw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.hw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hw.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hw.ForeColor = System.Drawing.Color.White;
            this.hw.Location = new System.Drawing.Point(703, 11);
            this.hw.Name = "hw";
            this.hw.Size = new System.Drawing.Size(41, 29);
            this.hw.TabIndex = 17;
            this.hw.Text = "HW";
            this.hw.UseVisualStyleBackColor = false;
            this.hw.Click += new System.EventHandler(this.hw_Click);
            // 
            // mv
            // 
            this.mv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.mv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mv.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mv.ForeColor = System.Drawing.Color.White;
            this.mv.Location = new System.Drawing.Point(468, 107);
            this.mv.Name = "mv";
            this.mv.Size = new System.Drawing.Size(99, 34);
            this.mv.TabIndex = 18;
            this.mv.Text = "Manual";
            this.mv.UseVisualStyleBackColor = false;
            this.mv.Click += new System.EventHandler(this.mv_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(759, 158);
            this.Controls.Add(this.mv);
            this.Controls.Add(this.hw);
            this.Controls.Add(this.sb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pakPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unrealVersion);
            this.Controls.Add(this.exeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exeName;
        private System.Windows.Forms.TextBox unrealVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pakPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sb;
        private System.Windows.Forms.Button hw;
        private System.Windows.Forms.Button mv;
    }
}