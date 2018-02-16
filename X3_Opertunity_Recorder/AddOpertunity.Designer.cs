namespace X3_Opertunity_Recorder
{
    partial class AddOpertunity
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.textBoxResource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(53, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 50);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(383, 243);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 50);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxResource);
            this.panel1.Controls.Add(this.textBoxSector);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 212);
            this.panel1.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(132, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(431, 39);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSector
            // 
            this.textBoxSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSector.Location = new System.Drawing.Point(132, 81);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.Size = new System.Drawing.Size(431, 39);
            this.textBoxSector.TabIndex = 1;
            // 
            // textBoxResource
            // 
            this.textBoxResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResource.Location = new System.Drawing.Point(132, 149);
            this.textBoxResource.Name = "textBoxResource";
            this.textBoxResource.Size = new System.Drawing.Size(431, 39);
            this.textBoxResource.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resource:";
            // 
            // AddOpertunity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddOpertunity";
            this.Text = "Add Opertunity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResource;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.TextBox textBoxName;
    }
}