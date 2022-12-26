
namespace Fnaf99
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Levels = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reconnectToProc = new System.Windows.Forms.Button();
            this.isConnected = new System.Windows.Forms.Label();
            this.dumpButton = new System.Windows.Forms.Button();
            this.mapsToDump = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.actortodumplabel = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.umodelInsts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Levels
            // 
            this.Levels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.Levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Levels.ForeColor = System.Drawing.Color.White;
            this.Levels.FormattingEnabled = true;
            this.Levels.Location = new System.Drawing.Point(17, 143);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(268, 494);
            this.Levels.TabIndex = 1;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.Levels_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maps loaded:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reconnectToProc
            // 
            this.reconnectToProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reconnectToProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.reconnectToProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reconnectToProc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reconnectToProc.ForeColor = System.Drawing.Color.White;
            this.reconnectToProc.Location = new System.Drawing.Point(745, 12);
            this.reconnectToProc.Name = "reconnectToProc";
            this.reconnectToProc.Size = new System.Drawing.Size(195, 34);
            this.reconnectToProc.TabIndex = 3;
            this.reconnectToProc.Text = "Connect to game";
            this.reconnectToProc.UseVisualStyleBackColor = false;
            this.reconnectToProc.Click += new System.EventHandler(this.reconnectToProc_Click);
            // 
            // isConnected
            // 
            this.isConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isConnected.AutoSize = true;
            this.isConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.isConnected.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isConnected.ForeColor = System.Drawing.Color.White;
            this.isConnected.Location = new System.Drawing.Point(535, 12);
            this.isConnected.Name = "isConnected";
            this.isConnected.Size = new System.Drawing.Size(194, 27);
            this.isConnected.TabIndex = 4;
            this.isConnected.Text = "Not connected";
            // 
            // dumpButton
            // 
            this.dumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dumpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dumpButton.ForeColor = System.Drawing.Color.White;
            this.dumpButton.Location = new System.Drawing.Point(745, 627);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Size = new System.Drawing.Size(195, 34);
            this.dumpButton.TabIndex = 5;
            this.dumpButton.Text = "Dump selected";
            this.dumpButton.UseVisualStyleBackColor = false;
            this.dumpButton.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // mapsToDump
            // 
            this.mapsToDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.mapsToDump.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mapsToDump.ForeColor = System.Drawing.Color.White;
            this.mapsToDump.FormattingEnabled = true;
            this.mapsToDump.Location = new System.Drawing.Point(291, 143);
            this.mapsToDump.Name = "mapsToDump";
            this.mapsToDump.Size = new System.Drawing.Size(264, 481);
            this.mapsToDump.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(745, 587);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(195, 34);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maps to dump:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actortodumplabel
            // 
            this.actortodumplabel.AutoSize = true;
            this.actortodumplabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.actortodumplabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actortodumplabel.ForeColor = System.Drawing.Color.White;
            this.actortodumplabel.Location = new System.Drawing.Point(16, 14);
            this.actortodumplabel.Name = "actortodumplabel";
            this.actortodumplabel.Size = new System.Drawing.Size(178, 18);
            this.actortodumplabel.TabIndex = 9;
            this.actortodumplabel.Text = "Meshes to dump: 0";
            this.actortodumplabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actortodumplabel.Click += new System.EventHandler(this.actortodumplabel_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Location = new System.Drawing.Point(745, 52);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(195, 34);
            this.settingBtn.TabIndex = 10;
            this.settingBtn.Text = "Settings";
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // umodelInsts
            // 
            this.umodelInsts.AutoSize = true;
            this.umodelInsts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.umodelInsts.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umodelInsts.ForeColor = System.Drawing.Color.White;
            this.umodelInsts.Location = new System.Drawing.Point(16, 32);
            this.umodelInsts.Name = "umodelInsts";
            this.umodelInsts.Size = new System.Drawing.Size(198, 18);
            this.umodelInsts.TabIndex = 11;
            this.umodelInsts.Text = "UModel Instances: 0";
            this.umodelInsts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.umodelInsts.Click += new System.EventHandler(this.umodelInsts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::Fnaf99.Properties.Resources.gg_logos;
            this.pictureBox1.Location = new System.Drawing.Point(636, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(952, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.umodelInsts);
            this.Controls.Add(this.settingBtn);
            this.Controls.Add(this.actortodumplabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.mapsToDump);
            this.Controls.Add(this.dumpButton);
            this.Controls.Add(this.isConnected);
            this.Controls.Add(this.reconnectToProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Levels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " Ripper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Levels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reconnectToProc;
        private System.Windows.Forms.Label isConnected;
        private System.Windows.Forms.Button dumpButton;
        private System.Windows.Forms.ListBox mapsToDump;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label actortodumplabel;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Label umodelInsts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}