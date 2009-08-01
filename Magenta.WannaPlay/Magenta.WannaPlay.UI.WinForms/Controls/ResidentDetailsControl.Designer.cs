﻿using Magenta.WannaPlay.UI.WinForms.Domain.UI;
namespace Magenta.WannaPlay.UI.WinForms.Controls
{
    partial class ResidentDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressBlockNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.facilityCardNumber = new System.Windows.Forms.TextBox();
            this.addressUnitNumber = new System.Windows.Forms.MaskedTextBox();
            this.dataContext = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.name.Location = new System.Drawing.Point(38, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Weis Mei Yunis Semenovich";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Block";
            // 
            // addressBlockNumber
            // 
            this.addressBlockNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "AddressBlockNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addressBlockNumber.Location = new System.Drawing.Point(38, 48);
            this.addressBlockNumber.Name = "addressBlockNumber";
            this.addressBlockNumber.Size = new System.Drawing.Size(39, 20);
            this.addressBlockNumber.TabIndex = 2;
            this.addressBlockNumber.Text = "1398A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Facility card number";
            // 
            // facilityCardNumber
            // 
            this.facilityCardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "FactilityCardNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.facilityCardNumber.Location = new System.Drawing.Point(104, 0);
            this.facilityCardNumber.Name = "facilityCardNumber";
            this.facilityCardNumber.Size = new System.Drawing.Size(34, 20);
            this.facilityCardNumber.TabIndex = 0;
            this.facilityCardNumber.Text = "9999";
            this.facilityCardNumber.Leave += new System.EventHandler(this.facilityCardNumber_Leave);
            // 
            // addressUnitNumber
            // 
            this.addressUnitNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataContext, "AddressUnitNumber", true));
            this.addressUnitNumber.Location = new System.Drawing.Point(115, 48);
            this.addressUnitNumber.Mask = "\\#00-00";
            this.addressUnitNumber.Name = "addressUnitNumber";
            this.addressUnitNumber.Size = new System.Drawing.Size(42, 20);
            this.addressUnitNumber.TabIndex = 19;
            // 
            // dataContext
            // 
            this.dataContext.DataSource = typeof(Magenta.WannaPlay.UI.WinForms.Domain.UI.ResidentDetailsUI);
            // 
            // ResidentDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressUnitNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.name);
            this.Controls.Add(this.facilityCardNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBlockNumber);
            this.Controls.Add(this.label6);
            this.Name = "ResidentDetailsControl";
            this.Size = new System.Drawing.Size(178, 68);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressBlockNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox facilityCardNumber;
        private System.Windows.Forms.BindingSource dataContext;
        private System.Windows.Forms.MaskedTextBox addressUnitNumber;
    }
}
