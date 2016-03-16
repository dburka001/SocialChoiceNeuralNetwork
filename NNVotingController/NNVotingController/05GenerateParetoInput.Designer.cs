﻿namespace NNVotingController
{
    partial class _05GenerateParetoInput
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
            this.lblRepetition = new System.Windows.Forms.Label();
            this.nudRepetition = new System.Windows.Forms.NumericUpDown();
            this.lblSamples = new System.Windows.Forms.Label();
            this.nudSamples = new System.Windows.Forms.NumericUpDown();
            this.lblNominees = new System.Windows.Forms.Label();
            this.nudNominees = new System.Windows.Forms.NumericUpDown();
            this.lblVoters = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.rdbBoth = new System.Windows.Forms.RadioButton();
            this.rdbInput = new System.Windows.Forms.RadioButton();
            this.lblSeed = new System.Windows.Forms.Label();
            this.rdbTraining = new System.Windows.Forms.RadioButton();
            this.panelCoding = new System.Windows.Forms.Panel();
            this.rdbBinary = new System.Windows.Forms.RadioButton();
            this.rdbAttila = new System.Windows.Forms.RadioButton();
            this.rdbBorda = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.lblCoding = new System.Windows.Forms.Label();
            this.panelType = new System.Windows.Forms.Panel();
            this.nudVoters = new System.Windows.Forms.NumericUpDown();
            this.lblDone = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.chkTimeStamp = new System.Windows.Forms.CheckBox();
            this.chkDiffVoterOrder = new System.Windows.Forms.CheckBox();
            this.rdbSum = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNominees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.panelCoding.SuspendLayout();
            this.panelType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepetition
            // 
            this.lblRepetition.AutoSize = true;
            this.lblRepetition.Location = new System.Drawing.Point(15, 156);
            this.lblRepetition.Name = "lblRepetition";
            this.lblRepetition.Size = new System.Drawing.Size(55, 13);
            this.lblRepetition.TabIndex = 51;
            this.lblRepetition.Text = "Repetition";
            // 
            // nudRepetition
            // 
            this.nudRepetition.Location = new System.Drawing.Point(76, 154);
            this.nudRepetition.Name = "nudRepetition";
            this.nudRepetition.Size = new System.Drawing.Size(120, 20);
            this.nudRepetition.TabIndex = 50;
            this.nudRepetition.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblSamples
            // 
            this.lblSamples.AutoSize = true;
            this.lblSamples.Location = new System.Drawing.Point(23, 121);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(47, 13);
            this.lblSamples.TabIndex = 49;
            this.lblSamples.Text = "Samples";
            // 
            // nudSamples
            // 
            this.nudSamples.Location = new System.Drawing.Point(76, 119);
            this.nudSamples.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSamples.Name = "nudSamples";
            this.nudSamples.Size = new System.Drawing.Size(120, 20);
            this.nudSamples.TabIndex = 48;
            this.nudSamples.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSamples.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblNominees
            // 
            this.lblNominees.AutoSize = true;
            this.lblNominees.Location = new System.Drawing.Point(16, 86);
            this.lblNominees.Name = "lblNominees";
            this.lblNominees.Size = new System.Drawing.Size(54, 13);
            this.lblNominees.TabIndex = 47;
            this.lblNominees.Text = "Nominees";
            // 
            // nudNominees
            // 
            this.nudNominees.Location = new System.Drawing.Point(76, 84);
            this.nudNominees.Name = "nudNominees";
            this.nudNominees.Size = new System.Drawing.Size(120, 20);
            this.nudNominees.TabIndex = 46;
            this.nudNominees.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNominees.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblVoters
            // 
            this.lblVoters.AutoSize = true;
            this.lblVoters.Location = new System.Drawing.Point(33, 51);
            this.lblVoters.Name = "lblVoters";
            this.lblVoters.Size = new System.Drawing.Size(37, 13);
            this.lblVoters.TabIndex = 45;
            this.lblVoters.Text = "Voters";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(409, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 100);
            this.btnStart.TabIndex = 43;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(76, 14);
            this.nudSeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(120, 20);
            this.nudSeed.TabIndex = 52;
            this.nudSeed.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            this.nudSeed.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbBoth
            // 
            this.rdbBoth.AutoSize = true;
            this.rdbBoth.Location = new System.Drawing.Point(16, 72);
            this.rdbBoth.Name = "rdbBoth";
            this.rdbBoth.Size = new System.Drawing.Size(47, 17);
            this.rdbBoth.TabIndex = 25;
            this.rdbBoth.Text = "Both";
            this.rdbBoth.UseVisualStyleBackColor = true;
            this.rdbBoth.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbInput
            // 
            this.rdbInput.AutoSize = true;
            this.rdbInput.Location = new System.Drawing.Point(16, 48);
            this.rdbInput.Name = "rdbInput";
            this.rdbInput.Size = new System.Drawing.Size(49, 17);
            this.rdbInput.TabIndex = 24;
            this.rdbInput.Text = "Input";
            this.rdbInput.UseVisualStyleBackColor = true;
            this.rdbInput.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(38, 16);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(32, 13);
            this.lblSeed.TabIndex = 53;
            this.lblSeed.Text = "Seed";
            // 
            // rdbTraining
            // 
            this.rdbTraining.AutoSize = true;
            this.rdbTraining.Checked = true;
            this.rdbTraining.Location = new System.Drawing.Point(16, 25);
            this.rdbTraining.Name = "rdbTraining";
            this.rdbTraining.Size = new System.Drawing.Size(63, 17);
            this.rdbTraining.TabIndex = 23;
            this.rdbTraining.TabStop = true;
            this.rdbTraining.Text = "Training";
            this.rdbTraining.UseVisualStyleBackColor = true;
            this.rdbTraining.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // panelCoding
            // 
            this.panelCoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCoding.Controls.Add(this.rdbSum);
            this.panelCoding.Controls.Add(this.rdbBinary);
            this.panelCoding.Controls.Add(this.rdbAttila);
            this.panelCoding.Controls.Add(this.rdbBorda);
            this.panelCoding.Controls.Add(this.rdbNormal);
            this.panelCoding.Controls.Add(this.lblCoding);
            this.panelCoding.Location = new System.Drawing.Point(369, 16);
            this.panelCoding.Name = "panelCoding";
            this.panelCoding.Size = new System.Drawing.Size(130, 157);
            this.panelCoding.TabIndex = 55;
            // 
            // rdbBinary
            // 
            this.rdbBinary.AutoSize = true;
            this.rdbBinary.Checked = true;
            this.rdbBinary.Location = new System.Drawing.Point(18, 95);
            this.rdbBinary.Name = "rdbBinary";
            this.rdbBinary.Size = new System.Drawing.Size(54, 17);
            this.rdbBinary.TabIndex = 60;
            this.rdbBinary.TabStop = true;
            this.rdbBinary.Text = "Binary";
            this.rdbBinary.UseVisualStyleBackColor = true;
            this.rdbBinary.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbAttila
            // 
            this.rdbAttila.AutoSize = true;
            this.rdbAttila.Location = new System.Drawing.Point(18, 72);
            this.rdbAttila.Name = "rdbAttila";
            this.rdbAttila.Size = new System.Drawing.Size(48, 17);
            this.rdbAttila.TabIndex = 22;
            this.rdbAttila.Text = "Attila";
            this.rdbAttila.UseVisualStyleBackColor = true;
            this.rdbAttila.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbBorda
            // 
            this.rdbBorda.AutoSize = true;
            this.rdbBorda.Location = new System.Drawing.Point(18, 48);
            this.rdbBorda.Name = "rdbBorda";
            this.rdbBorda.Size = new System.Drawing.Size(53, 17);
            this.rdbBorda.TabIndex = 21;
            this.rdbBorda.Text = "Borda";
            this.rdbBorda.UseVisualStyleBackColor = true;
            this.rdbBorda.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(18, 25);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 20;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblCoding
            // 
            this.lblCoding.AutoSize = true;
            this.lblCoding.Location = new System.Drawing.Point(3, 4);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Size = new System.Drawing.Size(40, 13);
            this.lblCoding.TabIndex = 19;
            this.lblCoding.Text = "Coding";
            // 
            // panelType
            // 
            this.panelType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelType.Controls.Add(this.rdbBoth);
            this.panelType.Controls.Add(this.lblType);
            this.panelType.Controls.Add(this.rdbInput);
            this.panelType.Controls.Add(this.rdbTraining);
            this.panelType.Location = new System.Drawing.Point(221, 16);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(130, 157);
            this.panelType.TabIndex = 54;
            // 
            // nudVoters
            // 
            this.nudVoters.Location = new System.Drawing.Point(76, 49);
            this.nudVoters.Name = "nudVoters";
            this.nudVoters.Size = new System.Drawing.Size(120, 20);
            this.nudVoters.TabIndex = 44;
            this.nudVoters.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudVoters.ValueChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDone.Location = new System.Drawing.Point(327, 341);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(76, 25);
            this.lblDone.TabIndex = 59;
            this.lblDone.Text = "DONE";
            this.lblDone.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(76, 187);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(423, 20);
            this.txtDescription.TabIndex = 57;
            this.txtDescription.Text = "_Pareto";
            this.txtDescription.TextChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(10, 190);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 56;
            this.lblDesc.Text = "Description";
            // 
            // chkTimeStamp
            // 
            this.chkTimeStamp.AutoSize = true;
            this.chkTimeStamp.Location = new System.Drawing.Point(76, 213);
            this.chkTimeStamp.Name = "chkTimeStamp";
            this.chkTimeStamp.Size = new System.Drawing.Size(98, 17);
            this.chkTimeStamp.TabIndex = 58;
            this.chkTimeStamp.Text = "Use time stamp";
            this.chkTimeStamp.UseVisualStyleBackColor = true;
            this.chkTimeStamp.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // chkDiffVoterOrder
            // 
            this.chkDiffVoterOrder.AutoSize = true;
            this.chkDiffVoterOrder.Checked = true;
            this.chkDiffVoterOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiffVoterOrder.Location = new System.Drawing.Point(76, 236);
            this.chkDiffVoterOrder.Name = "chkDiffVoterOrder";
            this.chkDiffVoterOrder.Size = new System.Drawing.Size(177, 17);
            this.chkDiffVoterOrder.TabIndex = 60;
            this.chkDiffVoterOrder.Text = "Allow different ordering of voters";
            this.chkDiffVoterOrder.UseVisualStyleBackColor = true;
            this.chkDiffVoterOrder.CheckedChanged += new System.EventHandler(this.InputValueChanged);
            // 
            // rdbSum
            // 
            this.rdbSum.AutoSize = true;
            this.rdbSum.Location = new System.Drawing.Point(18, 118);
            this.rdbSum.Name = "rdbSum";
            this.rdbSum.Size = new System.Drawing.Size(82, 17);
            this.rdbSum.TabIndex = 61;
            this.rdbSum.Text = "Summarized";
            this.rdbSum.UseVisualStyleBackColor = true;
            // 
            // _05GenerateParetoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkDiffVoterOrder);
            this.Controls.Add(this.lblRepetition);
            this.Controls.Add(this.nudRepetition);
            this.Controls.Add(this.lblSamples);
            this.Controls.Add(this.nudSamples);
            this.Controls.Add(this.lblNominees);
            this.Controls.Add(this.nudNominees);
            this.Controls.Add(this.lblVoters);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.panelCoding);
            this.Controls.Add(this.panelType);
            this.Controls.Add(this.nudVoters);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.chkTimeStamp);
            this.Name = "_05GenerateParetoInput";
            this.Size = new System.Drawing.Size(559, 406);
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNominees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.panelCoding.ResumeLayout(false);
            this.panelCoding.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepetition;
        private System.Windows.Forms.NumericUpDown nudRepetition;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.NumericUpDown nudSamples;
        private System.Windows.Forms.Label lblNominees;
        private System.Windows.Forms.NumericUpDown nudNominees;
        private System.Windows.Forms.Label lblVoters;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.RadioButton rdbBoth;
        private System.Windows.Forms.RadioButton rdbInput;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.RadioButton rdbTraining;
        private System.Windows.Forms.Panel panelCoding;
        private System.Windows.Forms.RadioButton rdbAttila;
        private System.Windows.Forms.RadioButton rdbBorda;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.Label lblCoding;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.NumericUpDown nudVoters;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.CheckBox chkTimeStamp;
        private System.Windows.Forms.RadioButton rdbBinary;
        private System.Windows.Forms.CheckBox chkDiffVoterOrder;
        private System.Windows.Forms.RadioButton rdbSum;

    }
}
