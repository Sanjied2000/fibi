
namespace Fibi
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
            this.friend = new System.Windows.Forms.Button();
            this.tbd = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.birthday = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.agebox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // friend
            // 
            this.friend.BackColor = System.Drawing.Color.Aqua;
            this.friend.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friend.ForeColor = System.Drawing.Color.Black;
            this.friend.Location = new System.Drawing.Point(12, 304);
            this.friend.Name = "friend";
            this.friend.Size = new System.Drawing.Size(144, 42);
            this.friend.TabIndex = 0;
            this.friend.Text = "Friends";
            this.friend.UseVisualStyleBackColor = false;
            this.friend.Click += new System.EventHandler(this.friend_Click);
            // 
            // tbd
            // 
            this.tbd.BackColor = System.Drawing.Color.Gold;
            this.tbd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbd.Location = new System.Drawing.Point(201, 118);
            this.tbd.Name = "tbd";
            this.tbd.Size = new System.Drawing.Size(194, 35);
            this.tbd.TabIndex = 2;
            this.tbd.Text = "Birthdays";
            this.tbd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(560, 142);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.Color.Aqua;
            this.birthday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.ForeColor = System.Drawing.Color.Black;
            this.birthday.Location = new System.Drawing.Point(162, 304);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(144, 42);
            this.birthday.TabIndex = 4;
            this.birthday.Text = "Birthdays";
            this.birthday.UseVisualStyleBackColor = false;
            this.birthday.Click += new System.EventHandler(this.birthday_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(598, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Aqua;
            this.add.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(312, 304);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 42);
            this.add.TabIndex = 6;
            this.add.Text = "+Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(462, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(110, 42);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // agebox
            // 
            this.agebox.AutoSize = true;
            this.agebox.BackColor = System.Drawing.Color.Transparent;
            this.agebox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agebox.Location = new System.Drawing.Point(578, 239);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(28, 35);
            this.agebox.TabIndex = 9;
            this.agebox.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Fibi.Properties.Resources.rsz_fibbi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 398);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.friend);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button friend;
        private System.Windows.Forms.Label tbd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button birthday;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label agebox;
    }
}

