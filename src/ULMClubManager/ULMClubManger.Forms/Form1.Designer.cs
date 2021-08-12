
namespace ULMClubManger.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this._dgvMembers = new System.Windows.Forms.DataGridView();
            this._splitContainerLayout = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerLayout)).BeginInit();
            this._splitContainerLayout.Panel1.SuspendLayout();
            this._splitContainerLayout.Panel2.SuspendLayout();
            this._splitContainerLayout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvMembers
            // 
            this._dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvMembers.Location = new System.Drawing.Point(3, 3);
            this._dgvMembers.Name = "_dgvMembers";
            this._dgvMembers.RowHeadersWidth = 51;
            this._dgvMembers.RowTemplate.Height = 24;
            this._dgvMembers.Size = new System.Drawing.Size(661, 810);
            this._dgvMembers.TabIndex = 0;
            // 
            // _splitContainerLayout
            // 
            this._splitContainerLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainerLayout.Location = new System.Drawing.Point(12, 12);
            this._splitContainerLayout.Name = "_splitContainerLayout";
            // 
            // _splitContainerLayout.Panel1
            // 
            this._splitContainerLayout.Panel1.Controls.Add(this._dgvMembers);
            // 
            // _splitContainerLayout.Panel2
            // 
            this._splitContainerLayout.Panel2.Controls.Add(this.button1);
            this._splitContainerLayout.Size = new System.Drawing.Size(1358, 816);
            this._splitContainerLayout.SplitterDistance = 667;
            this._splitContainerLayout.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1382, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(249, 20);
            this.toolStripStatusLabel1.Text = "Développé par Laure D\'Este en 2021";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._splitContainerLayout);
            this.Name = "Form1";
            this.Text = "ULM Club Manager Liège";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvMembers)).EndInit();
            this._splitContainerLayout.Panel1.ResumeLayout(false);
            this._splitContainerLayout.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerLayout)).EndInit();
            this._splitContainerLayout.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvMembers;
        private System.Windows.Forms.SplitContainer _splitContainerLayout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
    }
}

