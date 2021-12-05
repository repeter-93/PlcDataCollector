using System.ComponentModel;

namespace PlcDataCollector
{
    partial class FormPlcCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonPlcCreatorOk = new System.Windows.Forms.Button();
            this.buttonPlcCreatorClose = new System.Windows.Forms.Button();
            this.labelPlcCreatorName = new System.Windows.Forms.Label();
            this.labelPlcCreatorIp = new System.Windows.Forms.Label();
            this.labelPlcCreatorPort = new System.Windows.Forms.Label();
            this.textBoxPlcCreatorName = new System.Windows.Forms.TextBox();
            this.textBoxPlcCreatorIp = new System.Windows.Forms.TextBox();
            this.textBoxPlcCreatorPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPlcCreatorOk
            // 
            this.buttonPlcCreatorOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlcCreatorOk.Location = new System.Drawing.Point(20, 246);
            this.buttonPlcCreatorOk.Name = "buttonPlcCreatorOk";
            this.buttonPlcCreatorOk.Size = new System.Drawing.Size(75, 24);
            this.buttonPlcCreatorOk.TabIndex = 0;
            this.buttonPlcCreatorOk.Text = "Ok";
            this.buttonPlcCreatorOk.UseVisualStyleBackColor = true;
            this.buttonPlcCreatorOk.Click += new System.EventHandler(this.buttonPlcCreatorOk_Click);
            // 
            // buttonPlcCreatorClose
            // 
            this.buttonPlcCreatorClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlcCreatorClose.Location = new System.Drawing.Point(105, 246);
            this.buttonPlcCreatorClose.Name = "buttonPlcCreatorClose";
            this.buttonPlcCreatorClose.Size = new System.Drawing.Size(75, 24);
            this.buttonPlcCreatorClose.TabIndex = 1;
            this.buttonPlcCreatorClose.Text = "Close";
            this.buttonPlcCreatorClose.UseVisualStyleBackColor = true;
            this.buttonPlcCreatorClose.Click += new System.EventHandler(this.buttonPlcCreatorClose_Click);
            // 
            // labelPlcCreatorName
            // 
            this.labelPlcCreatorName.AutoSize = true;
            this.labelPlcCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlcCreatorName.Location = new System.Drawing.Point(20, 20);
            this.labelPlcCreatorName.Name = "labelPlcCreatorName";
            this.labelPlcCreatorName.Size = new System.Drawing.Size(45, 17);
            this.labelPlcCreatorName.TabIndex = 2;
            this.labelPlcCreatorName.Text = "Name";
            // 
            // labelPlcCreatorIp
            // 
            this.labelPlcCreatorIp.AutoSize = true;
            this.labelPlcCreatorIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlcCreatorIp.Location = new System.Drawing.Point(20, 90);
            this.labelPlcCreatorIp.Name = "labelPlcCreatorIp";
            this.labelPlcCreatorIp.Size = new System.Drawing.Size(75, 17);
            this.labelPlcCreatorIp.TabIndex = 3;
            this.labelPlcCreatorIp.Text = "IP address";
            // 
            // labelPlcCreatorPort
            // 
            this.labelPlcCreatorPort.AutoSize = true;
            this.labelPlcCreatorPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlcCreatorPort.Location = new System.Drawing.Point(20, 160);
            this.labelPlcCreatorPort.Name = "labelPlcCreatorPort";
            this.labelPlcCreatorPort.Size = new System.Drawing.Size(34, 17);
            this.labelPlcCreatorPort.TabIndex = 4;
            this.labelPlcCreatorPort.Text = "Port";
            // 
            // textBoxPlcCreatorName
            // 
            this.textBoxPlcCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlcCreatorName.Location = new System.Drawing.Point(20, 45);
            this.textBoxPlcCreatorName.Name = "textBoxPlcCreatorName";
            this.textBoxPlcCreatorName.Size = new System.Drawing.Size(160, 23);
            this.textBoxPlcCreatorName.TabIndex = 5;
            // 
            // textBoxPlcCreatorIp
            // 
            this.textBoxPlcCreatorIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlcCreatorIp.Location = new System.Drawing.Point(20, 115);
            this.textBoxPlcCreatorIp.Name = "textBoxPlcCreatorIp";
            this.textBoxPlcCreatorIp.Size = new System.Drawing.Size(160, 23);
            this.textBoxPlcCreatorIp.TabIndex = 6;
            // 
            // textBoxPlcCreatorPort
            // 
            this.textBoxPlcCreatorPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlcCreatorPort.Location = new System.Drawing.Point(20, 185);
            this.textBoxPlcCreatorPort.Name = "textBoxPlcCreatorPort";
            this.textBoxPlcCreatorPort.Size = new System.Drawing.Size(160, 23);
            this.textBoxPlcCreatorPort.TabIndex = 7;
            // 
            // FormPlcCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 298);
            this.Controls.Add(this.textBoxPlcCreatorPort);
            this.Controls.Add(this.textBoxPlcCreatorIp);
            this.Controls.Add(this.textBoxPlcCreatorName);
            this.Controls.Add(this.labelPlcCreatorPort);
            this.Controls.Add(this.labelPlcCreatorIp);
            this.Controls.Add(this.labelPlcCreatorName);
            this.Controls.Add(this.buttonPlcCreatorClose);
            this.Controls.Add(this.buttonPlcCreatorOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlcCreator";
            this.ShowIcon = false;
            this.Text = "FormPlcCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlcCreatorOk;
        private System.Windows.Forms.Button buttonPlcCreatorClose;
        private System.Windows.Forms.Label labelPlcCreatorName;
        private System.Windows.Forms.Label labelPlcCreatorIp;
        private System.Windows.Forms.Label labelPlcCreatorPort;
        private System.Windows.Forms.TextBox textBoxPlcCreatorName;
        private System.Windows.Forms.TextBox textBoxPlcCreatorIp;
        private System.Windows.Forms.TextBox textBoxPlcCreatorPort;
    }
}