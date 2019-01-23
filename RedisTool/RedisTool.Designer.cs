namespace RedisTool
{
    partial class RedisTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lableRedisKeyGet = new System.Windows.Forms.Label();
            this.txtBoxKeyGet = new System.Windows.Forms.TextBox();
            this.btnRedisKeyGet = new System.Windows.Forms.Button();
            this.txtBoxValueGet = new System.Windows.Forms.TextBox();
            this.titleRedisValue = new System.Windows.Forms.Label();
            this.labelObjectNameGet = new System.Windows.Forms.Label();
            this.comboBoxKeyGet = new System.Windows.Forms.ComboBox();
            this.labelTitleGetOrDefault = new System.Windows.Forms.Label();
            this.labelSplitLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSet = new System.Windows.Forms.Label();
            this.lableRedisKeySet = new System.Windows.Forms.Label();
            this.txtBoxKeySet = new System.Windows.Forms.TextBox();
            this.labelValueTypeSet = new System.Windows.Forms.Label();
            this.comboBoxKeySet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxValueSet = new System.Windows.Forms.TextBox();
            this.btnRedisKeySet = new System.Windows.Forms.Button();
            this.labelSplitMiddle = new System.Windows.Forms.Label();
            this.labelDel = new System.Windows.Forms.Label();
            this.lableRedisKeyDel = new System.Windows.Forms.Label();
            this.txtBoxKeyDel = new System.Windows.Forms.TextBox();
            this.btnRedisKeyDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableRedisKeyGet
            // 
            this.lableRedisKeyGet.AutoSize = true;
            this.lableRedisKeyGet.Location = new System.Drawing.Point(12, 33);
            this.lableRedisKeyGet.Name = "lableRedisKeyGet";
            this.lableRedisKeyGet.Size = new System.Drawing.Size(23, 12);
            this.lableRedisKeyGet.TabIndex = 0;
            this.lableRedisKeyGet.Text = "键:";
            // 
            // txtBoxKeyGet
            // 
            this.txtBoxKeyGet.Location = new System.Drawing.Point(69, 30);
            this.txtBoxKeyGet.Name = "txtBoxKeyGet";
            this.txtBoxKeyGet.Size = new System.Drawing.Size(121, 21);
            this.txtBoxKeyGet.TabIndex = 1;
            // 
            // btnRedisKeyGet
            // 
            this.btnRedisKeyGet.Location = new System.Drawing.Point(81, 133);
            this.btnRedisKeyGet.Name = "btnRedisKeyGet";
            this.btnRedisKeyGet.Size = new System.Drawing.Size(75, 23);
            this.btnRedisKeyGet.TabIndex = 2;
            this.btnRedisKeyGet.Text = "获取值";
            this.btnRedisKeyGet.UseVisualStyleBackColor = true;
            this.btnRedisKeyGet.Click += new System.EventHandler(this.btnRedisKeyGet_Click);
            // 
            // txtBoxValueGet
            // 
            this.txtBoxValueGet.Location = new System.Drawing.Point(69, 187);
            this.txtBoxValueGet.Multiline = true;
            this.txtBoxValueGet.Name = "txtBoxValueGet";
            this.txtBoxValueGet.Size = new System.Drawing.Size(121, 187);
            this.txtBoxValueGet.TabIndex = 1;
            // 
            // titleRedisValue
            // 
            this.titleRedisValue.AutoSize = true;
            this.titleRedisValue.Location = new System.Drawing.Point(12, 187);
            this.titleRedisValue.Name = "titleRedisValue";
            this.titleRedisValue.Size = new System.Drawing.Size(23, 12);
            this.titleRedisValue.TabIndex = 0;
            this.titleRedisValue.Text = "值:";
            // 
            // labelObjectNameGet
            // 
            this.labelObjectNameGet.AutoSize = true;
            this.labelObjectNameGet.Location = new System.Drawing.Point(12, 85);
            this.labelObjectNameGet.Name = "labelObjectNameGet";
            this.labelObjectNameGet.Size = new System.Drawing.Size(47, 12);
            this.labelObjectNameGet.TabIndex = 0;
            this.labelObjectNameGet.Text = "对象名:";
            // 
            // comboBoxKeyGet
            // 
            this.comboBoxKeyGet.FormattingEnabled = true;
            this.comboBoxKeyGet.Location = new System.Drawing.Point(69, 82);
            this.comboBoxKeyGet.Name = "comboBoxKeyGet";
            this.comboBoxKeyGet.Size = new System.Drawing.Size(121, 20);
            this.comboBoxKeyGet.TabIndex = 3;
            // 
            // labelTitleGetOrDefault
            // 
            this.labelTitleGetOrDefault.AutoSize = true;
            this.labelTitleGetOrDefault.Location = new System.Drawing.Point(12, 9);
            this.labelTitleGetOrDefault.Name = "labelTitleGetOrDefault";
            this.labelTitleGetOrDefault.Size = new System.Drawing.Size(47, 12);
            this.labelTitleGetOrDefault.TabIndex = 0;
            this.labelTitleGetOrDefault.Text = "获取值:";
            // 
            // labelSplitLeft
            // 
            this.labelSplitLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSplitLeft.Location = new System.Drawing.Point(229, -1);
            this.labelSplitLeft.Name = "labelSplitLeft";
            this.labelSplitLeft.Size = new System.Drawing.Size(2, 452);
            this.labelSplitLeft.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "获取值:";
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Location = new System.Drawing.Point(247, 9);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(59, 12);
            this.labelSet.TabIndex = 0;
            this.labelSet.Text = "设置键值:";
            // 
            // lableRedisKeySet
            // 
            this.lableRedisKeySet.AutoSize = true;
            this.lableRedisKeySet.Location = new System.Drawing.Point(247, 33);
            this.lableRedisKeySet.Name = "lableRedisKeySet";
            this.lableRedisKeySet.Size = new System.Drawing.Size(23, 12);
            this.lableRedisKeySet.TabIndex = 0;
            this.lableRedisKeySet.Text = "键:";
            // 
            // txtBoxKeySet
            // 
            this.txtBoxKeySet.Location = new System.Drawing.Point(307, 30);
            this.txtBoxKeySet.Name = "txtBoxKeySet";
            this.txtBoxKeySet.Size = new System.Drawing.Size(121, 21);
            this.txtBoxKeySet.TabIndex = 1;
            // 
            // labelValueTypeSet
            // 
            this.labelValueTypeSet.AutoSize = true;
            this.labelValueTypeSet.Location = new System.Drawing.Point(247, 85);
            this.labelValueTypeSet.Name = "labelValueTypeSet";
            this.labelValueTypeSet.Size = new System.Drawing.Size(47, 12);
            this.labelValueTypeSet.TabIndex = 0;
            this.labelValueTypeSet.Text = "值类型:";
            // 
            // comboBoxKeySet
            // 
            this.comboBoxKeySet.FormattingEnabled = true;
            this.comboBoxKeySet.Location = new System.Drawing.Point(307, 82);
            this.comboBoxKeySet.Name = "comboBoxKeySet";
            this.comboBoxKeySet.Size = new System.Drawing.Size(121, 20);
            this.comboBoxKeySet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "值:";
            // 
            // txtBoxValueSet
            // 
            this.txtBoxValueSet.Location = new System.Drawing.Point(307, 138);
            this.txtBoxValueSet.Multiline = true;
            this.txtBoxValueSet.Name = "txtBoxValueSet";
            this.txtBoxValueSet.Size = new System.Drawing.Size(121, 187);
            this.txtBoxValueSet.TabIndex = 1;
            // 
            // btnRedisKeySet
            // 
            this.btnRedisKeySet.Location = new System.Drawing.Point(332, 350);
            this.btnRedisKeySet.Name = "btnRedisKeySet";
            this.btnRedisKeySet.Size = new System.Drawing.Size(75, 23);
            this.btnRedisKeySet.TabIndex = 5;
            this.btnRedisKeySet.Text = "设置键值对";
            this.btnRedisKeySet.UseVisualStyleBackColor = true;
            this.btnRedisKeySet.Click += new System.EventHandler(this.btnRedisKeySet_Click);
            // 
            // labelSplitMiddle
            // 
            this.labelSplitMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSplitMiddle.Location = new System.Drawing.Point(461, -1);
            this.labelSplitMiddle.Name = "labelSplitMiddle";
            this.labelSplitMiddle.Size = new System.Drawing.Size(2, 452);
            this.labelSplitMiddle.TabIndex = 6;
            this.labelSplitMiddle.Text = "label1";
            // 
            // labelDel
            // 
            this.labelDel.AutoSize = true;
            this.labelDel.Location = new System.Drawing.Point(490, 9);
            this.labelDel.Name = "labelDel";
            this.labelDel.Size = new System.Drawing.Size(59, 12);
            this.labelDel.TabIndex = 0;
            this.labelDel.Text = "删除键值:";
            // 
            // lableRedisKeyDel
            // 
            this.lableRedisKeyDel.AutoSize = true;
            this.lableRedisKeyDel.Location = new System.Drawing.Point(489, 33);
            this.lableRedisKeyDel.Name = "lableRedisKeyDel";
            this.lableRedisKeyDel.Size = new System.Drawing.Size(23, 12);
            this.lableRedisKeyDel.TabIndex = 7;
            this.lableRedisKeyDel.Text = "键:";
            // 
            // txtBoxKeyDel
            // 
            this.txtBoxKeyDel.Location = new System.Drawing.Point(549, 30);
            this.txtBoxKeyDel.Name = "txtBoxKeyDel";
            this.txtBoxKeyDel.Size = new System.Drawing.Size(121, 21);
            this.txtBoxKeyDel.TabIndex = 1;
            // 
            // btnRedisKeyDel
            // 
            this.btnRedisKeyDel.Location = new System.Drawing.Point(525, 74);
            this.btnRedisKeyDel.Name = "btnRedisKeyDel";
            this.btnRedisKeyDel.Size = new System.Drawing.Size(75, 23);
            this.btnRedisKeyDel.TabIndex = 5;
            this.btnRedisKeyDel.Text = "删除键值对";
            this.btnRedisKeyDel.UseVisualStyleBackColor = true;
            this.btnRedisKeyDel.Click += new System.EventHandler(this.btnRedisKeyDel_Click);
            // 
            // RedisTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.lableRedisKeyDel);
            this.Controls.Add(this.labelSplitMiddle);
            this.Controls.Add(this.btnRedisKeyDel);
            this.Controls.Add(this.btnRedisKeySet);
            this.Controls.Add(this.labelSplitLeft);
            this.Controls.Add(this.comboBoxKeySet);
            this.Controls.Add(this.comboBoxKeyGet);
            this.Controls.Add(this.btnRedisKeyGet);
            this.Controls.Add(this.txtBoxValueSet);
            this.Controls.Add(this.txtBoxValueGet);
            this.Controls.Add(this.txtBoxKeyDel);
            this.Controls.Add(this.txtBoxKeySet);
            this.Controls.Add(this.txtBoxKeyGet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleRedisValue);
            this.Controls.Add(this.labelValueTypeSet);
            this.Controls.Add(this.labelObjectNameGet);
            this.Controls.Add(this.labelDel);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitleGetOrDefault);
            this.Controls.Add(this.lableRedisKeySet);
            this.Controls.Add(this.lableRedisKeyGet);
            this.Name = "RedisTool";
            this.Text = "RedisFormTool";
            this.Load += new System.EventHandler(this.RedisTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableRedisKeyGet;
        private System.Windows.Forms.TextBox txtBoxKeyGet;
        private System.Windows.Forms.Button btnRedisKeyGet;
        private System.Windows.Forms.TextBox txtBoxValueGet;
        private System.Windows.Forms.Label titleRedisValue;
        private System.Windows.Forms.Label labelObjectNameGet;
        private System.Windows.Forms.ComboBox comboBoxKeyGet;
        private System.Windows.Forms.Label labelTitleGetOrDefault;
        private System.Windows.Forms.Label labelSplitLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.Label lableRedisKeySet;
        private System.Windows.Forms.TextBox txtBoxKeySet;
        private System.Windows.Forms.Label labelValueTypeSet;
        private System.Windows.Forms.ComboBox comboBoxKeySet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxValueSet;
        private System.Windows.Forms.Button btnRedisKeySet;
        private System.Windows.Forms.Label labelSplitMiddle;
        private System.Windows.Forms.Label labelDel;
        private System.Windows.Forms.Label lableRedisKeyDel;
        private System.Windows.Forms.TextBox txtBoxKeyDel;
        private System.Windows.Forms.Button btnRedisKeyDel;
    }
}

