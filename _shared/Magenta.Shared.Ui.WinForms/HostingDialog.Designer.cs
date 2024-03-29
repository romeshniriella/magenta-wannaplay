﻿namespace Magenta.Shared.UI.WinForms
{
    partial class HostingDialog
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
            this.content = new System.Windows.Forms.Panel();
            this._separator = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(757, 433);
            this.content.TabIndex = 0;
            // 
            // _separator
            // 
            this._separator.BackColor = System.Drawing.Color.Silver;
            this._separator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._separator.Location = new System.Drawing.Point(0, 431);
            this._separator.Name = "_separator";
            this._separator.Size = new System.Drawing.Size(757, 2);
            this._separator.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 433);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.Size = new System.Drawing.Size(757, 8);
            this.buttonsPanel.TabIndex = 1;
            // 
            // HostingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 441);
            this.Controls.Add(this._separator);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HostingDialog";
            this.ShowInTaskbar = false;
            this.Text = "HostingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Panel _separator;


    }
}