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
      this.textBoxCheckKey = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(55, 51);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(101, 35);
      this.buttonGenerate.TabIndex = 0;
      this.buttonGenerate.Text = "Generate";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
      // 
      // textBoxKey
      // 
      this.textBoxKey.Location = new System.Drawing.Point(181, 65);
      this.textBoxKey.Name = "textBoxKey";
      this.textBoxKey.Size = new System.Drawing.Size(384, 20);
      this.textBoxKey.TabIndex = 1;
      // 
      // buttonVerifyKey
      // 
      this.buttonVerifyKey.Location = new System.Drawing.Point(55, 151);
      this.buttonVerifyKey.Name = "buttonVerifyKey";
      this.buttonVerifyKey.Size = new System.Drawing.Size(101, 35);
      this.buttonVerifyKey.TabIndex = 2;
      this.buttonVerifyKey.Text = "Check Key";
      this.buttonVerifyKey.UseVisualStyleBackColor = true;
      // 
      // textBoxCheckKey
      // 
      this.textBoxCheckKey.Location = new System.Drawing.Point(181, 159);
      this.textBoxCheckKey.Name = "textBoxCheckKey";
      this.textBoxCheckKey.Size = new System.Drawing.Size(384, 20);
      this.textBoxCheckKey.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 246);
      this.Controls.Add(this.textBoxCheckKey);
      this.Controls.Add(this.buttonVerifyKey);
      this.Controls.Add(this.textBoxKey);
      this.Controls.Add(this.buttonGenerate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.TextBox textBoxKey;
    private System.Windows.Forms.Button buttonVerifyKey;
    private System.Windows.Forms.TextBox textBoxCheckKey;
  }
}

