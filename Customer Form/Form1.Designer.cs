
namespace Customer_Form
{
    partial class customerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.telephoneInput = new System.Windows.Forms.TextBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.idNumberInput = new System.Windows.Forms.TextBox();
            this.customerInfoOutput = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mailingListCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(156, 21);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 23);
            this.nameInput.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 54);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(107, 15);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Customer Address:";
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(156, 51);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 23);
            this.addressInput.TabIndex = 3;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 84);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(119, 15);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Customer Telephone:";
            // 
            // telephoneInput
            // 
            this.telephoneInput.Location = new System.Drawing.Point(156, 81);
            this.telephoneInput.Name = "telephoneInput";
            this.telephoneInput.Size = new System.Drawing.Size(100, 23);
            this.telephoneInput.TabIndex = 5;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(12, 114);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(123, 15);
            this.idNumberLabel.TabIndex = 6;
            this.idNumberLabel.Text = "Customer ID Number:";
            // 
            // idNumberInput
            // 
            this.idNumberInput.Location = new System.Drawing.Point(156, 111);
            this.idNumberInput.Name = "idNumberInput";
            this.idNumberInput.Size = new System.Drawing.Size(100, 23);
            this.idNumberInput.TabIndex = 7;
            // 
            // customerInfoOutput
            // 
            this.customerInfoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfoOutput.Location = new System.Drawing.Point(12, 151);
            this.customerInfoOutput.Name = "customerInfoOutput";
            this.customerInfoOutput.Size = new System.Drawing.Size(440, 106);
            this.customerInfoOutput.TabIndex = 8;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(289, 21);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(92, 48);
            this.displayButton.TabIndex = 9;
            this.displayButton.Text = "Display Customer";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(289, 76);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mailingListCheckbox
            // 
            this.mailingListCheckbox.AutoSize = true;
            this.mailingListCheckbox.Location = new System.Drawing.Point(289, 114);
            this.mailingListCheckbox.Name = "mailingListCheckbox";
            this.mailingListCheckbox.Size = new System.Drawing.Size(163, 19);
            this.mailingListCheckbox.TabIndex = 11;
            this.mailingListCheckbox.Text = "Add me to the mailing list";
            this.mailingListCheckbox.UseVisualStyleBackColor = true;
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 277);
            this.Controls.Add(this.mailingListCheckbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.customerInfoOutput);
            this.Controls.Add(this.idNumberInput);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.telephoneInput);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Name = "customerForm";
            this.Text = "Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox telephoneInput;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.TextBox idNumberInput;
        private System.Windows.Forms.Label customerInfoOutput;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox mailingListCheckbox;
    }
}

