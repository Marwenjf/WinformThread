using System.Drawing;
using System.Windows.Forms;

namespace winformThread
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Text = "JF Marwen";
            start = new Button();
            progressBar = new ProgressBar();
            evolutionLabel = new Label();
            evolution = new Label();
            result = new Label();
            resultLabel = new Label();
            start.Name = "start";
            start.Text = "Start";
            evolutionLabel.Text = "Evolution:";
            evolutionLabel.Font = new Font(evolutionLabel.Font, FontStyle.Bold);
            result.Text = "0";
            resultLabel.Text="Résultat:";
            resultLabel.Font = new Font(resultLabel.Font, FontStyle.Bold);
            evolution.Text = "0";
            start.Location = new System.Drawing.Point(10, 20);
            start.Size = new System.Drawing.Size(75, 35);
            progressBar.Location = new System.Drawing.Point(10, 80);
            progressBar.Size = new System.Drawing.Size(478, 80);
            evolutionLabel.Location = new System.Drawing.Point(10, 180);
            evolution.Location = new System.Drawing.Point(110, 180);
            resultLabel.Location = new System.Drawing.Point(10, 200);
            result.Location = new System.Drawing.Point(110, 200);
            this.Controls.Add(start);
            this.Controls.Add(progressBar);
            this.Controls.Add(evolutionLabel);
            this.Controls.Add(evolution);
            this.Controls.Add(resultLabel);
            this.Controls.Add(result);
        }

        private Button start;
        private ProgressBar progressBar;
        private Label evolutionLabel;
        private Label evolution;

        private Label result;
        private Label resultLabel;

        #endregion
    }
}

