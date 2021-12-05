
namespace PlcDataCollector
{
    partial class FormDataCollector
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelConnectedVariables = new System.Windows.Forms.Label();
            this.buttonAddVariable = new System.Windows.Forms.Button();
            this.listBoxVariables = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelPlcConnections = new System.Windows.Forms.Label();
            this.listBoxPlcs = new System.Windows.Forms.ListBox();
            this.buttonAddPlc = new System.Windows.Forms.Button();
            this.buttonDeletePlc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPlcs = new System.Windows.Forms.ComboBox();
            this.timerSaveVariables = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(260, 71);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button_Connect);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(385, 71);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.button_Disconnect);
            // 
            // labelConnectedVariables
            // 
            this.labelConnectedVariables.AutoSize = true;
            this.labelConnectedVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectedVariables.Location = new System.Drawing.Point(260, 100);
            this.labelConnectedVariables.Name = "labelConnectedVariables";
            this.labelConnectedVariables.Size = new System.Drawing.Size(76, 17);
            this.labelConnectedVariables.TabIndex = 10;
            this.labelConnectedVariables.Text = "Variables";
            // 
            // buttonAddVariable
            // 
            this.buttonAddVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVariable.Location = new System.Drawing.Point(402, 400);
            this.buttonAddVariable.Name = "buttonAddVariable";
            this.buttonAddVariable.Size = new System.Drawing.Size(26, 26);
            this.buttonAddVariable.TabIndex = 11;
            this.buttonAddVariable.Text = "+";
            this.buttonAddVariable.UseVisualStyleBackColor = true;
            this.buttonAddVariable.Click += new System.EventHandler(this.buttonAddVariable_Click);
            // 
            // listBoxVariables
            // 
            this.listBoxVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVariables.FormattingEnabled = true;
            this.listBoxVariables.ItemHeight = 16;
            this.listBoxVariables.Location = new System.Drawing.Point(260, 120);
            this.listBoxVariables.Name = "listBoxVariables";
            this.listBoxVariables.Size = new System.Drawing.Size(200, 276);
            this.listBoxVariables.TabIndex = 12;
            this.listBoxVariables.SelectedIndexChanged += new System.EventHandler(this.listBoxVariables_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(434, 400);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(26, 26);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "-";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDeleteVariable_Click);
            // 
            // labelPlcConnections
            // 
            this.labelPlcConnections.AutoSize = true;
            this.labelPlcConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlcConnections.Location = new System.Drawing.Point(10, 10);
            this.labelPlcConnections.Name = "labelPlcConnections";
            this.labelPlcConnections.Size = new System.Drawing.Size(196, 20);
            this.labelPlcConnections.TabIndex = 14;
            this.labelPlcConnections.Text = "active PLC connections";
            // 
            // listBoxPlcs
            // 
            this.listBoxPlcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlcs.FormattingEnabled = true;
            this.listBoxPlcs.ItemHeight = 16;
            this.listBoxPlcs.Location = new System.Drawing.Point(10, 40);
            this.listBoxPlcs.Name = "listBoxPlcs";
            this.listBoxPlcs.Size = new System.Drawing.Size(200, 356);
            this.listBoxPlcs.TabIndex = 15;
            this.listBoxPlcs.SelectedIndexChanged += new System.EventHandler(this.listBoxPlcs_SelectedIndexChanged);
            // 
            // buttonAddPlc
            // 
            this.buttonAddPlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPlc.Location = new System.Drawing.Point(152, 400);
            this.buttonAddPlc.Name = "buttonAddPlc";
            this.buttonAddPlc.Size = new System.Drawing.Size(26, 26);
            this.buttonAddPlc.TabIndex = 16;
            this.buttonAddPlc.Text = "+";
            this.buttonAddPlc.UseVisualStyleBackColor = true;
            this.buttonAddPlc.Click += new System.EventHandler(this.buttonAddPlc_Click);
            // 
            // buttonDeletePlc
            // 
            this.buttonDeletePlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePlc.Location = new System.Drawing.Point(184, 400);
            this.buttonDeletePlc.Name = "buttonDeletePlc";
            this.buttonDeletePlc.Size = new System.Drawing.Size(26, 26);
            this.buttonDeletePlc.TabIndex = 17;
            this.buttonDeletePlc.Text = "-";
            this.buttonDeletePlc.UseVisualStyleBackColor = true;
            this.buttonDeletePlc.Click += new System.EventHandler(this.buttonDeletePlc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "selected connection";
            // 
            // comboBoxPlcs
            // 
            this.comboBoxPlcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlcs.FormattingEnabled = true;
            this.comboBoxPlcs.Location = new System.Drawing.Point(260, 41);
            this.comboBoxPlcs.Name = "comboBoxPlcs";
            this.comboBoxPlcs.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPlcs.TabIndex = 19;
            this.comboBoxPlcs.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlcs_SelectedIndexChanged);
            // 
            // timerSaveVariables
            // 
            this.timerSaveVariables.Tick += new System.EventHandler(this.timerSaveVariables_Tick);
            // 
            // FormDataCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.comboBoxPlcs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeletePlc);
            this.Controls.Add(this.buttonAddPlc);
            this.Controls.Add(this.listBoxPlcs);
            this.Controls.Add(this.labelPlcConnections);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxVariables);
            this.Controls.Add(this.buttonAddVariable);
            this.Controls.Add(this.labelConnectedVariables);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "FormDataCollector";
            this.Text = "PLC Data Collector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelConnectedVariables;
        private System.Windows.Forms.Button buttonAddVariable;
        private System.Windows.Forms.ListBox listBoxVariables;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPlcConnections;
        private System.Windows.Forms.ListBox listBoxPlcs;
        private System.Windows.Forms.Button buttonAddPlc;
        private System.Windows.Forms.Button buttonDeletePlc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPlcs;
        private System.Windows.Forms.Timer timerSaveVariables;
        // private System.Windows.Forms.ComboBox comboBoxDatatypes;
    }
}

