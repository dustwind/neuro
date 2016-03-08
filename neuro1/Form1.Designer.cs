namespace neuro1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnGo = new System.Windows.Forms.Button();
            this.nudLayer = new System.Windows.Forms.NumericUpDown();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.cbXray = new System.Windows.Forms.CheckBox();
            this.cbFactor = new System.Windows.Forms.CheckBox();
            this.cbUzli = new System.Windows.Forms.CheckBox();
            this.cbSimmetria = new System.Windows.Forms.CheckBox();
            this.cbKist = new System.Windows.Forms.CheckBox();
            this.cbSustav = new System.Windows.Forms.CheckBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNeuro = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_done = new System.Windows.Forms.Label();
            this.button_diagnos = new System.Windows.Forms.Button();
            this.lbl_diagnos = new System.Windows.Forms.Label();
            this.chart_errorDynamic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sick = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_check = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayer)).BeginInit();
            this.gbCheck.SuspendLayout();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_errorDynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sick)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(233, 136);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(123, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "отправить в школу";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudLayer
            // 
            this.nudLayer.Location = new System.Drawing.Point(137, 19);
            this.nudLayer.Name = "nudLayer";
            this.nudLayer.Size = new System.Drawing.Size(74, 20);
            this.nudLayer.TabIndex = 1;
            this.nudLayer.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.cbXray);
            this.gbCheck.Controls.Add(this.cbFactor);
            this.gbCheck.Controls.Add(this.cbUzli);
            this.gbCheck.Controls.Add(this.cbSimmetria);
            this.gbCheck.Controls.Add(this.cbKist);
            this.gbCheck.Controls.Add(this.cbSustav);
            this.gbCheck.Controls.Add(this.cbMorning);
            this.gbCheck.Location = new System.Drawing.Point(12, 12);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Size = new System.Drawing.Size(217, 181);
            this.gbCheck.TabIndex = 2;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Показатели пациента";
            // 
            // cbXray
            // 
            this.cbXray.AutoSize = true;
            this.cbXray.Location = new System.Drawing.Point(7, 158);
            this.cbXray.Name = "cbXray";
            this.cbXray.Size = new System.Drawing.Size(126, 17);
            this.cbXray.TabIndex = 6;
            this.cbXray.Text = "Рентген-изменения";
            this.cbXray.UseVisualStyleBackColor = true;
            // 
            // cbFactor
            // 
            this.cbFactor.AutoSize = true;
            this.cbFactor.Location = new System.Drawing.Point(7, 135);
            this.cbFactor.Name = "cbFactor";
            this.cbFactor.Size = new System.Drawing.Size(189, 17);
            this.cbFactor.TabIndex = 5;
            this.cbFactor.Text = "Ревматоидный ф-р в сыворотке";
            this.cbFactor.UseVisualStyleBackColor = true;
            // 
            // cbUzli
            // 
            this.cbUzli.AutoSize = true;
            this.cbUzli.Location = new System.Drawing.Point(6, 112);
            this.cbUzli.Name = "cbUzli";
            this.cbUzli.Size = new System.Drawing.Size(140, 17);
            this.cbUzli.TabIndex = 4;
            this.cbUzli.Text = "Ревматоидные узелки";
            this.cbUzli.UseVisualStyleBackColor = true;
            // 
            // cbSimmetria
            // 
            this.cbSimmetria.AutoSize = true;
            this.cbSimmetria.Location = new System.Drawing.Point(6, 89);
            this.cbSimmetria.Name = "cbSimmetria";
            this.cbSimmetria.Size = new System.Drawing.Size(209, 17);
            this.cbSimmetria.TabIndex = 3;
            this.cbSimmetria.Text = "Симметричное поражение суставов";
            this.cbSimmetria.UseVisualStyleBackColor = true;
            // 
            // cbKist
            // 
            this.cbKist.AutoSize = true;
            this.cbKist.Location = new System.Drawing.Point(7, 66);
            this.cbKist.Name = "cbKist";
            this.cbKist.Size = new System.Drawing.Size(171, 17);
            this.cbKist.TabIndex = 2;
            this.cbKist.Text = "Поражение суставов кистей";
            this.cbKist.UseVisualStyleBackColor = true;
            // 
            // cbSustav
            // 
            this.cbSustav.AutoSize = true;
            this.cbSustav.Location = new System.Drawing.Point(7, 43);
            this.cbSustav.Name = "cbSustav";
            this.cbSustav.Size = new System.Drawing.Size(148, 17);
            this.cbSustav.TabIndex = 1;
            this.cbSustav.Text = "Поражение >2 суставов";
            this.cbSustav.UseVisualStyleBackColor = true;
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Location = new System.Drawing.Point(7, 20);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(143, 17);
            this.cbMorning.TabIndex = 0;
            this.cbMorning.Text = "Утренняя скованность";
            this.cbMorning.UseVisualStyleBackColor = true;
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.nudAge);
            this.gbConfig.Controls.Add(this.btnDefault);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.nudNeuro);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.nudLayer);
            this.gbConfig.Location = new System.Drawing.Point(233, 12);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(217, 118);
            this.gbConfig.TabIndex = 3;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Конфигурация сети";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество эпох";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(137, 71);
            this.nudAge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(74, 20);
            this.nudAge.TabIndex = 6;
            this.nudAge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(9, 89);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество нейронов";
            // 
            // nudNeuro
            // 
            this.nudNeuro.Location = new System.Drawing.Point(137, 45);
            this.nudNeuro.Name = "nudNeuro";
            this.nudNeuro.Size = new System.Drawing.Size(74, 20);
            this.nudNeuro.TabIndex = 3;
            this.nudNeuro.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество слоев";
            // 
            // lbl_done
            // 
            this.lbl_done.AutoSize = true;
            this.lbl_done.Location = new System.Drawing.Point(367, 141);
            this.lbl_done.Name = "lbl_done";
            this.lbl_done.Size = new System.Drawing.Size(62, 13);
            this.lbl_done.TabIndex = 4;
            this.lbl_done.Text = "не обучена";
            // 
            // button_diagnos
            // 
            this.button_diagnos.Location = new System.Drawing.Point(12, 199);
            this.button_diagnos.Name = "button_diagnos";
            this.button_diagnos.Size = new System.Drawing.Size(123, 23);
            this.button_diagnos.TabIndex = 5;
            this.button_diagnos.Text = "поставить диагноз";
            this.button_diagnos.UseVisualStyleBackColor = true;
            this.button_diagnos.Click += new System.EventHandler(this.button_diagnos_Click);
            // 
            // lbl_diagnos
            // 
            this.lbl_diagnos.AutoSize = true;
            this.lbl_diagnos.Location = new System.Drawing.Point(146, 204);
            this.lbl_diagnos.Name = "lbl_diagnos";
            this.lbl_diagnos.Size = new System.Drawing.Size(66, 13);
            this.lbl_diagnos.TabIndex = 6;
            this.lbl_diagnos.Text = "неизвестно";
            // 
            // chart_errorDynamic
            // 
            chartArea1.AxisX.Title = "эпохи";
            chartArea1.AxisY.Title = "ошибка";
            chartArea1.Name = "Динамика обучения";
            this.chart_errorDynamic.ChartAreas.Add(chartArea1);
            this.chart_errorDynamic.Location = new System.Drawing.Point(12, 243);
            this.chart_errorDynamic.Name = "chart_errorDynamic";
            this.chart_errorDynamic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "Динамика обучения";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart_errorDynamic.Series.Add(series1);
            this.chart_errorDynamic.Size = new System.Drawing.Size(438, 252);
            this.chart_errorDynamic.TabIndex = 7;
            this.chart_errorDynamic.Text = "Динамика обучения";
            title1.Name = "Title1";
            title1.Text = "Динамика обучения";
            this.chart_errorDynamic.Titles.Add(title1);
            // 
            // chart_sick
            // 
            chartArea2.AxisX.Title = "выход";
            chartArea2.AxisY.Title = "эпохи";
            chartArea2.Name = "Динамика обучения";
            this.chart_sick.ChartAreas.Add(chartArea2);
            this.chart_sick.Location = new System.Drawing.Point(478, 7);
            this.chart_sick.Name = "chart_sick";
            this.chart_sick.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "Динамика обучения";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Green;
            series2.LegendText = "Не болен";
            series2.MarkerBorderWidth = 0;
            series2.MarkerSize = 3;
            series2.Name = "Series3";
            series3.ChartArea = "Динамика обучения";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Maroon;
            series3.LegendText = "Болен";
            series3.MarkerColor = System.Drawing.Color.Maroon;
            series3.MarkerSize = 4;
            series3.Name = "sick_positive";
            this.chart_sick.Series.Add(series2);
            this.chart_sick.Series.Add(series3);
            this.chart_sick.Size = new System.Drawing.Size(699, 523);
            this.chart_sick.TabIndex = 8;
            title2.Name = "Title1";
            title2.Text = "Визуализация обучения";
            this.chart_sick.Titles.Add(title2);
            // 
            // button_check
            // 
            this.button_check.Enabled = false;
            this.button_check.Location = new System.Drawing.Point(233, 165);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(123, 23);
            this.button_check.TabIndex = 9;
            this.button_check.Text = "проверить выборку";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(233, 194);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(84, 23);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(327, 194);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(83, 23);
            this.button_load.TabIndex = 11;
            this.button_load.Text = "load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 525);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.chart_sick);
            this.Controls.Add(this.chart_errorDynamic);
            this.Controls.Add(this.lbl_diagnos);
            this.Controls.Add(this.button_diagnos);
            this.Controls.Add(this.lbl_done);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.gbCheck);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "Гагарин";
            ((System.ComponentModel.ISupportInitialize)(this.nudLayer)).EndInit();
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_errorDynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudLayer;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.CheckBox cbXray;
        private System.Windows.Forms.CheckBox cbFactor;
        private System.Windows.Forms.CheckBox cbUzli;
        private System.Windows.Forms.CheckBox cbSimmetria;
        private System.Windows.Forms.CheckBox cbKist;
        private System.Windows.Forms.CheckBox cbSustav;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNeuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_done;
        private System.Windows.Forms.Button button_diagnos;
        private System.Windows.Forms.Label lbl_diagnos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_errorDynamic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sick;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}

