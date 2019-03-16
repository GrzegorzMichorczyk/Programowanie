namespace AnkietaNastroju
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxPytanie2 = new System.Windows.Forms.CheckedListBox();
            this.comboBoxPytanie1 = new System.Windows.Forms.ComboBox();
            this.radioButtonPytanie3Tak = new System.Windows.Forms.RadioButton();
            this.numericUpDownPytanie4 = new System.Windows.Forms.NumericUpDown();
            this.listBoxPytanie3bis = new System.Windows.Forms.ListBox();
            this.labelPytanie1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPytanie3Nie = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPodsumowanie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPytanie4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxPytanie2
            // 
            this.checkedListBoxPytanie2.FormattingEnabled = true;
            this.checkedListBoxPytanie2.Items.AddRange(new object[] {
            "radość",
            "zadowolenie",
            "podekscytowanie",
            "zdenerwowanie",
            "złość",
            "obojętność",
            "strach"});
            this.checkedListBoxPytanie2.Location = new System.Drawing.Point(385, 67);
            this.checkedListBoxPytanie2.MultiColumn = true;
            this.checkedListBoxPytanie2.Name = "checkedListBoxPytanie2";
            this.checkedListBoxPytanie2.Size = new System.Drawing.Size(120, 109);
            this.checkedListBoxPytanie2.TabIndex = 0;
            // 
            // comboBoxPytanie1
            // 
            this.comboBoxPytanie1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPytanie1.FormattingEnabled = true;
            this.comboBoxPytanie1.Items.AddRange(new object[] {
            "jestem bardzo zadowolony/a",
            "jestem zadowolony/a",
            "jestem średnio zadowolony/a",
            "jestem niezadowolony/a",
            "jestem bardzo niezadowolony/a"});
            this.comboBoxPytanie1.Location = new System.Drawing.Point(384, 26);
            this.comboBoxPytanie1.Name = "comboBoxPytanie1";
            this.comboBoxPytanie1.Size = new System.Drawing.Size(238, 21);
            this.comboBoxPytanie1.TabIndex = 1;
            this.comboBoxPytanie1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPytanie1_SelectedIndexChanged);
            // 
            // radioButtonPytanie3Tak
            // 
            this.radioButtonPytanie3Tak.AutoSize = true;
            this.radioButtonPytanie3Tak.Location = new System.Drawing.Point(385, 237);
            this.radioButtonPytanie3Tak.Name = "radioButtonPytanie3Tak";
            this.radioButtonPytanie3Tak.Size = new System.Drawing.Size(40, 17);
            this.radioButtonPytanie3Tak.TabIndex = 2;
            this.radioButtonPytanie3Tak.TabStop = true;
            this.radioButtonPytanie3Tak.Text = "tak";
            this.radioButtonPytanie3Tak.UseVisualStyleBackColor = true;
            this.radioButtonPytanie3Tak.CheckedChanged += new System.EventHandler(this.radioButtonPytanie3Tak_CheckedChanged);
            // 
            // numericUpDownPytanie4
            // 
            this.numericUpDownPytanie4.Location = new System.Drawing.Point(385, 348);
            this.numericUpDownPytanie4.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownPytanie4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPytanie4.Name = "numericUpDownPytanie4";
            this.numericUpDownPytanie4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPytanie4.TabIndex = 3;
            this.numericUpDownPytanie4.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // listBoxPytanie3bis
            // 
            this.listBoxPytanie3bis.Enabled = false;
            this.listBoxPytanie3bis.FormattingEnabled = true;
            this.listBoxPytanie3bis.Items.AddRange(new object[] {
            "Lepsza oferta od innego pracodawcy",
            "Dobry pomysł na własny biznes",
            "Zmiana życiowa ",
            "Brak możliwości rozwoju w danej firmie",
            "Brak motywacji",
            "Zbyt stresująca praca"});
            this.listBoxPytanie3bis.Location = new System.Drawing.Point(385, 260);
            this.listBoxPytanie3bis.Name = "listBoxPytanie3bis";
            this.listBoxPytanie3bis.Size = new System.Drawing.Size(218, 82);
            this.listBoxPytanie3bis.TabIndex = 4;
            // 
            // labelPytanie1
            // 
            this.labelPytanie1.AutoSize = true;
            this.labelPytanie1.Location = new System.Drawing.Point(12, 29);
            this.labelPytanie1.Name = "labelPytanie1";
            this.labelPytanie1.Size = new System.Drawing.Size(235, 13);
            this.labelPytanie1.TabIndex = 5;
            this.labelPytanie1.Text = "1. Czy jest Pan/i zadowolony/a ze swojej pracy?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "2 Jakie emocje towarzyszą Panu/i codziennie przed rozpoczęciem pracy?";
            // 
            // radioButtonPytanie3Nie
            // 
            this.radioButtonPytanie3Nie.AutoSize = true;
            this.radioButtonPytanie3Nie.Location = new System.Drawing.Point(431, 237);
            this.radioButtonPytanie3Nie.Name = "radioButtonPytanie3Nie";
            this.radioButtonPytanie3Nie.Size = new System.Drawing.Size(39, 17);
            this.radioButtonPytanie3Nie.TabIndex = 9;
            this.radioButtonPytanie3Nie.TabStop = true;
            this.radioButtonPytanie3Nie.Text = "nie";
            this.radioButtonPytanie3Nie.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "4 Ile czasu dziennie poświęca Pan/i na pracę? ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "3 Czy myśli Pan/i o zmianie obecnej pracy? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "3\' Z jakiego powodu myśli Pan/i o zmianie obecnej pracy?";
            // 
            // buttonPodsumowanie
            // 
            this.buttonPodsumowanie.Location = new System.Drawing.Point(384, 389);
            this.buttonPodsumowanie.Name = "buttonPodsumowanie";
            this.buttonPodsumowanie.Size = new System.Drawing.Size(121, 23);
            this.buttonPodsumowanie.TabIndex = 13;
            this.buttonPodsumowanie.Text = "podsumuj ankietę";
            this.buttonPodsumowanie.UseVisualStyleBackColor = true;
            this.buttonPodsumowanie.Click += new System.EventHandler(this.buttonPodsumowanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.buttonPodsumowanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonPytanie3Nie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPytanie1);
            this.Controls.Add(this.listBoxPytanie3bis);
            this.Controls.Add(this.numericUpDownPytanie4);
            this.Controls.Add(this.radioButtonPytanie3Tak);
            this.Controls.Add(this.comboBoxPytanie1);
            this.Controls.Add(this.checkedListBoxPytanie2);
            this.Name = "Form1";
            this.Text = "Ankieta nastroju";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPytanie4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPytanie2;
        private System.Windows.Forms.ComboBox comboBoxPytanie1;
        private System.Windows.Forms.RadioButton radioButtonPytanie3Tak;
        private System.Windows.Forms.NumericUpDown numericUpDownPytanie4;
        private System.Windows.Forms.ListBox listBoxPytanie3bis;
        private System.Windows.Forms.Label labelPytanie1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPytanie3Nie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPodsumowanie;
    }
}

