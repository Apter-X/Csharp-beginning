
namespace SimpleDataApp
{
    partial class AddClients
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAddAnoutherClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(602, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Client";
            // 
            // txtCity
            // 
            this.txtCity.AccessibleName = "";
            this.txtCity.Location = new System.Drawing.Point(311, 274);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(272, 31);
            this.txtCity.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleName = "";
            this.txtAddress.Location = new System.Drawing.Point(311, 204);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 31);
            this.txtAddress.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.AccessibleName = "";
            this.txtLastName.Location = new System.Drawing.Point(312, 132);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleName = "";
            this.txtFirstName.Location = new System.Drawing.Point(311, 62);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(272, 31);
            this.txtFirstName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "- City                          :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Customer LastName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Address                    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Customer FirstName :";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.AccessibleName = "";
            this.btnCreateClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateClient.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateClient.Location = new System.Drawing.Point(691, 102);
            this.btnCreateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(241, 189);
            this.btnCreateClient.TabIndex = 1;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleName = "";
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(32, 459);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(241, 74);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // btnAddAnoutherClient
            // 
            this.btnAddAnoutherClient.AccessibleName = "";
            this.btnAddAnoutherClient.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnoutherClient.Location = new System.Drawing.Point(545, 459);
            this.btnAddAnoutherClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAnoutherClient.Name = "btnAddAnoutherClient";
            this.btnAddAnoutherClient.Size = new System.Drawing.Size(424, 74);
            this.btnAddAnoutherClient.TabIndex = 7;
            this.btnAddAnoutherClient.Text = "Add Another Client";
            this.btnAddAnoutherClient.UseVisualStyleBackColor = true;
            this.btnAddAnoutherClient.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // AddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 552);
            this.Controls.Add(this.btnAddAnoutherClient);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddClients";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAddAnoutherClient;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
    }
}