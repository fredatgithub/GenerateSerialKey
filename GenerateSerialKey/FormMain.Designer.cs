namespace GenerateSerialKey
{
  partial class FormMain
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
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.textBoxKey = new System.Windows.Forms.TextBox();
      this.buttonVerifyKey = new System.Windows.Forms.Button();
      this.textBoxCheckKeyValidity = new System.Windows.Forms.TextBox();
      this.textBoxKeyGenerationDate = new System.Windows.Forms.TextBox();
      this.textBoxKeyExpiration = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(82, 78);
      this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(152, 54);
      this.buttonGenerate.TabIndex = 0;
      this.buttonGenerate.Text = "Generate";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
      // 
      // textBoxKey
      // 
      this.textBoxKey.Location = new System.Drawing.Point(272, 100);
      this.textBoxKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxKey.Name = "textBoxKey";
      this.textBoxKey.Size = new System.Drawing.Size(348, 26);
      this.textBoxKey.TabIndex = 1;
      // 
      // buttonVerifyKey
      // 
      this.buttonVerifyKey.Location = new System.Drawing.Point(82, 232);
      this.buttonVerifyKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonVerifyKey.Name = "buttonVerifyKey";
      this.buttonVerifyKey.Size = new System.Drawing.Size(152, 54);
      this.buttonVerifyKey.TabIndex = 2;
      this.buttonVerifyKey.Text = "Check Key";
      this.buttonVerifyKey.UseVisualStyleBackColor = true;
      this.buttonVerifyKey.Click += new System.EventHandler(this.ButtonVerifyKey_Click);
      // 
      // textBoxCheckKeyValidity
      // 
      this.textBoxCheckKeyValidity.Location = new System.Drawing.Point(272, 245);
      this.textBoxCheckKeyValidity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxCheckKeyValidity.Name = "textBoxCheckKeyValidity";
      this.textBoxCheckKeyValidity.Size = new System.Drawing.Size(348, 26);
      this.textBoxCheckKeyValidity.TabIndex = 3;
      this.textBoxCheckKeyValidity.Text = "Key is valid or not";
      // 
      // textBoxKeyGenerationDate
      // 
      this.textBoxKeyGenerationDate.Location = new System.Drawing.Point(272, 302);
      this.textBoxKeyGenerationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxKeyGenerationDate.Name = "textBoxKeyGenerationDate";
      this.textBoxKeyGenerationDate.Size = new System.Drawing.Size(348, 26);
      this.textBoxKeyGenerationDate.TabIndex = 4;
      this.textBoxKeyGenerationDate.Text = "Key was generated on ";
      // 
      // textBoxKeyExpiration
      // 
      this.textBoxKeyExpiration.Location = new System.Drawing.Point(272, 356);
      this.textBoxKeyExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxKeyExpiration.Name = "textBoxKeyExpiration";
      this.textBoxKeyExpiration.Size = new System.Drawing.Size(348, 26);
      this.textBoxKeyExpiration.TabIndex = 5;
      this.textBoxKeyExpiration.Text = "Key will expire on";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(814, 426);
      this.Controls.Add(this.textBoxKeyExpiration);
      this.Controls.Add(this.textBoxKeyGenerationDate);
      this.Controls.Add(this.textBoxCheckKeyValidity);
      this.Controls.Add(this.buttonVerifyKey);
      this.Controls.Add(this.textBoxKey);
      this.Controls.Add(this.buttonGenerate);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormMain";
      this.Text = "Generate key valid one month";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.TextBox textBoxKey;
    private System.Windows.Forms.Button buttonVerifyKey;
    private System.Windows.Forms.TextBox textBoxCheckKeyValidity;
    private System.Windows.Forms.TextBox textBoxKeyGenerationDate;
    private System.Windows.Forms.TextBox textBoxKeyExpiration;
  }
}

