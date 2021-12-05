using System.ComponentModel;

namespace PlcDataCollector
{
    partial class FormVariableCreator
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
            this.labelVariableCreatorType = new System.Windows.Forms.Label();
            this.labelVariableCreatorName = new System.Windows.Forms.Label();
            this.buttonVariableCreatorOk = new System.Windows.Forms.Button();
            this.buttonVariableCreatorClose = new System.Windows.Forms.Button();
            this.comboBoxVariableCreatorType = new System.Windows.Forms.ComboBox();
            this.textBoxVariableCreatorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelVariableCreatorType
            // 
            this.labelVariableCreatorType.AutoSize = true;
            this.labelVariableCreatorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariableCreatorType.Location = new System.Drawing.Point(20, 10);
            this.labelVariableCreatorType.Name = "labelVariableCreatorType";
            this.labelVariableCreatorType.Size = new System.Drawing.Size(91, 17);
            this.labelVariableCreatorType.TabIndex = 0;
            this.labelVariableCreatorType.Text = "Variable type";
            // 
            // labelVariableCreatorName
            // 
            this.labelVariableCreatorName.AutoSize = true;
            this.labelVariableCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariableCreatorName.Location = new System.Drawing.Point(20, 90);
            this.labelVariableCreatorName.Name = "labelVariableCreatorName";
            this.labelVariableCreatorName.Size = new System.Drawing.Size(99, 17);
            this.labelVariableCreatorName.TabIndex = 1;
            this.labelVariableCreatorName.Text = "Variable name";
            // 
            // buttonVariableCreatorOk
            // 
            this.buttonVariableCreatorOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVariableCreatorOk.Location = new System.Drawing.Point(20, 174);
            this.buttonVariableCreatorOk.Name = "buttonVariableCreatorOk";
            this.buttonVariableCreatorOk.Size = new System.Drawing.Size(75, 24);
            this.buttonVariableCreatorOk.TabIndex = 2;
            this.buttonVariableCreatorOk.Text = "Ok";
            this.buttonVariableCreatorOk.UseVisualStyleBackColor = true;
            this.buttonVariableCreatorOk.Click += new System.EventHandler(this.buttonVariableCreatorOk_Click);
            // 
            // buttonVariableCreatorClose
            // 
            this.buttonVariableCreatorClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVariableCreatorClose.Location = new System.Drawing.Point(101, 174);
            this.buttonVariableCreatorClose.Name = "buttonVariableCreatorClose";
            this.buttonVariableCreatorClose.Size = new System.Drawing.Size(75, 24);
            this.buttonVariableCreatorClose.TabIndex = 3;
            this.buttonVariableCreatorClose.Text = "Close";
            this.buttonVariableCreatorClose.UseVisualStyleBackColor = true;
            this.buttonVariableCreatorClose.Click += new System.EventHandler(this.buttonVariableCreatorClose_Click);
            // 
            // comboBoxVariableCreatorType
            // 
            this.comboBoxVariableCreatorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVariableCreatorType.FormattingEnabled = true;
            this.comboBoxVariableCreatorType.Location = new System.Drawing.Point(20, 40);
            this.comboBoxVariableCreatorType.Name = "comboBoxVariableCreatorType";
            this.comboBoxVariableCreatorType.Size = new System.Drawing.Size(156, 24);
            this.comboBoxVariableCreatorType.TabIndex = 4;
            // 
            // textBoxVariableCreatorName
            // 
            this.textBoxVariableCreatorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVariableCreatorName.Location = new System.Drawing.Point(20, 120);
            this.textBoxVariableCreatorName.Name = "textBoxVariableCreatorName";
            this.textBoxVariableCreatorName.Size = new System.Drawing.Size(156, 23);
            this.textBoxVariableCreatorName.TabIndex = 5;
            // 
            // FormVariableCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(201, 216);
            this.Controls.Add(this.textBoxVariableCreatorName);
            this.Controls.Add(this.comboBoxVariableCreatorType);
            this.Controls.Add(this.buttonVariableCreatorClose);
            this.Controls.Add(this.buttonVariableCreatorOk);
            this.Controls.Add(this.labelVariableCreatorName);
            this.Controls.Add(this.labelVariableCreatorType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVariableCreator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormVariableCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVariableCreatorType;
        private System.Windows.Forms.Label labelVariableCreatorName;
        private System.Windows.Forms.Button buttonVariableCreatorOk;
        private System.Windows.Forms.Button buttonVariableCreatorClose;
        private System.Windows.Forms.ComboBox comboBoxVariableCreatorType;
        private System.Windows.Forms.TextBox textBoxVariableCreatorName;
    }
}