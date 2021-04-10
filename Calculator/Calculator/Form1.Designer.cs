
namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button_count = new System.Windows.Forms.Button();
            this.textBox_Screen = new System.Windows.Forms.TextBox();
            this.textBox_data_translation = new System.Windows.Forms.TextBox();
            this.TranslationScreen = new System.Windows.Forms.TextBox();
            this.MainScreen = new System.Windows.Forms.TextBox();
            this.banner = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typesOfCalculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviousOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Conversion_textBox1 = new System.Windows.Forms.TextBox();
            this.Conversion_textBox2 = new System.Windows.Forms.TextBox();
            this.Conversion_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Conversion_comboBox2 = new System.Windows.Forms.ComboBox();
            this.MainInputKeyboard = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_number_9 = new System.Windows.Forms.Button();
            this.button_number_0 = new System.Windows.Forms.Button();
            this.button_number_4 = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_number_3 = new System.Windows.Forms.Button();
            this.button_number_5 = new System.Windows.Forms.Button();
            this.button_number_2 = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_number_1 = new System.Windows.Forms.Button();
            this.button_number_7 = new System.Windows.Forms.Button();
            this.button_number_6 = new System.Windows.Forms.Button();
            this.button_number_8 = new System.Windows.Forms.Button();
            this.ConversionOfValues = new System.Windows.Forms.Panel();
            this.KeyboardMathOperations = new System.Windows.Forms.Panel();
            this.button_bracket_left = new System.Windows.Forms.Button();
            this.button_bracket_right = new System.Windows.Forms.Button();
            this.button_pi = new System.Windows.Forms.Button();
            this.button_tanx = new System.Windows.Forms.Button();
            this.button_cotx = new System.Windows.Forms.Button();
            this.button_plus_minus = new System.Windows.Forms.Button();
            this.button_sinx = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button_absx = new System.Windows.Forms.Button();
            this.button_cosx = new System.Windows.Forms.Button();
            this.button_atanx = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_acosx = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_power_of_ten = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_asinx = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_x = new System.Windows.Forms.Button();
            this.button_definite_integral = new System.Windows.Forms.Button();
            this.Screens = new System.Windows.Forms.Panel();
            this.button_formula_mode = new System.Windows.Forms.Button();
            this.button_next_line = new System.Windows.Forms.Button();
            this.button_memory_read = new System.Windows.Forms.Button();
            this.button_memory_clear = new System.Windows.Forms.Button();
            this.button_memory_add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.MainInputKeyboard.SuspendLayout();
            this.ConversionOfValues.SuspendLayout();
            this.KeyboardMathOperations.SuspendLayout();
            this.Screens.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_count
            // 
            this.button_count.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_count.Location = new System.Drawing.Point(1095, 122);
            this.button_count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(173, 98);
            this.button_count.TabIndex = 10;
            this.button_count.Text = "=";
            this.button_count.UseVisualStyleBackColor = false;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // textBox_Screen
            // 
            this.textBox_Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Screen.Location = new System.Drawing.Point(155, 19);
            this.textBox_Screen.Multiline = true;
            this.textBox_Screen.Name = "textBox_Screen";
            this.textBox_Screen.Size = new System.Drawing.Size(451, 217);
            this.textBox_Screen.TabIndex = 1;
            this.textBox_Screen.TabStop = false;
            this.textBox_Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_data_translation
            // 
            this.textBox_data_translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_data_translation.Location = new System.Drawing.Point(2, 19);
            this.textBox_data_translation.Multiline = true;
            this.textBox_data_translation.Name = "textBox_data_translation";
            this.textBox_data_translation.Size = new System.Drawing.Size(147, 217);
            this.textBox_data_translation.TabIndex = 29;
            this.textBox_data_translation.TabStop = false;
            // 
            // TranslationScreen
            // 
            this.TranslationScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TranslationScreen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslationScreen.Location = new System.Drawing.Point(4, 17);
            this.TranslationScreen.Margin = new System.Windows.Forms.Padding(4);
            this.TranslationScreen.Multiline = true;
            this.TranslationScreen.Name = "TranslationScreen";
            this.TranslationScreen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TranslationScreen.Size = new System.Drawing.Size(413, 201);
            this.TranslationScreen.TabIndex = 3;
            this.TranslationScreen.TabStop = false;
            // 
            // MainScreen
            // 
            this.MainScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainScreen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainScreen.Location = new System.Drawing.Point(427, 17);
            this.MainScreen.Margin = new System.Windows.Forms.Padding(4);
            this.MainScreen.Multiline = true;
            this.MainScreen.Name = "MainScreen";
            this.MainScreen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MainScreen.Size = new System.Drawing.Size(660, 201);
            this.MainScreen.TabIndex = 2;
            this.MainScreen.TabStop = false;
            this.MainScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // banner
            // 
            this.banner.AutoSize = true;
            this.banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.banner.Location = new System.Drawing.Point(20, 86);
            this.banner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(432, 135);
            this.banner.TabIndex = 85;
            this.banner.Text = "banner";
            this.banner.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typesOfCalculatorsToolStripMenuItem,
            this.MoveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1657, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typesOfCalculatorsToolStripMenuItem
            // 
            this.typesOfCalculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EngineeringToolStripMenuItem,
            this.LengthToolStripMenuItem,
            this.weightToolStripMenuItem,
            this.speedToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.typesOfCalculatorsToolStripMenuItem.Name = "typesOfCalculatorsToolStripMenuItem";
            this.typesOfCalculatorsToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.typesOfCalculatorsToolStripMenuItem.Text = "Типы калькуляторов";
            // 
            // EngineeringToolStripMenuItem
            // 
            this.EngineeringToolStripMenuItem.Name = "EngineeringToolStripMenuItem";
            this.EngineeringToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.EngineeringToolStripMenuItem.Text = "Инженерный";
            this.EngineeringToolStripMenuItem.Click += new System.EventHandler(this.EngineeringToolStripMenuItem_Click);
            // 
            // LengthToolStripMenuItem
            // 
            this.LengthToolStripMenuItem.Name = "LengthToolStripMenuItem";
            this.LengthToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.LengthToolStripMenuItem.Text = "Длина";
            this.LengthToolStripMenuItem.Click += new System.EventHandler(this.LengthToolStripMenuItem_Click);
            // 
            // weightToolStripMenuItem
            // 
            this.weightToolStripMenuItem.Name = "weightToolStripMenuItem";
            this.weightToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.weightToolStripMenuItem.Text = "Вес";
            this.weightToolStripMenuItem.Click += new System.EventHandler(this.weightToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.speedToolStripMenuItem.Text = "Скорость";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.timeToolStripMenuItem.Text = "Время";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.dataToolStripMenuItem.Text = "Данные";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviousOperationToolStripMenuItem,
            this.NextOperationToolStripMenuItem});
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.MoveToolStripMenuItem.Text = "История операций";
            // 
            // PreviousOperationToolStripMenuItem
            // 
            this.PreviousOperationToolStripMenuItem.Name = "PreviousOperationToolStripMenuItem";
            this.PreviousOperationToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.PreviousOperationToolStripMenuItem.Text = "Предыдущая операция";
            this.PreviousOperationToolStripMenuItem.Click += new System.EventHandler(this.PreviousOperationToolStripMenuItem_Click);
            // 
            // NextOperationToolStripMenuItem
            // 
            this.NextOperationToolStripMenuItem.Name = "NextOperationToolStripMenuItem";
            this.NextOperationToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.NextOperationToolStripMenuItem.Text = "Следующая операция";
            this.NextOperationToolStripMenuItem.Click += new System.EventHandler(this.NextOperationToolStripMenuItem_Click);
            // 
            // Conversion_textBox1
            // 
            this.Conversion_textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Conversion_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Conversion_textBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conversion_textBox1.Location = new System.Drawing.Point(180, 46);
            this.Conversion_textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.Conversion_textBox1.Name = "Conversion_textBox1";
            this.Conversion_textBox1.Size = new System.Drawing.Size(351, 31);
            this.Conversion_textBox1.TabIndex = 3;
            this.Conversion_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Conversion_textBox2
            // 
            this.Conversion_textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Conversion_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Conversion_textBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conversion_textBox2.Location = new System.Drawing.Point(180, 356);
            this.Conversion_textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.Conversion_textBox2.Name = "Conversion_textBox2";
            this.Conversion_textBox2.Size = new System.Drawing.Size(351, 31);
            this.Conversion_textBox2.TabIndex = 2;
            this.Conversion_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Conversion_comboBox1
            // 
            this.Conversion_comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.Conversion_comboBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conversion_comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Conversion_comboBox1.FormattingEnabled = true;
            this.Conversion_comboBox1.Location = new System.Drawing.Point(180, 153);
            this.Conversion_comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.Conversion_comboBox1.Name = "Conversion_comboBox1";
            this.Conversion_comboBox1.Size = new System.Drawing.Size(349, 39);
            this.Conversion_comboBox1.TabIndex = 1;
            this.Conversion_comboBox1.SelectedIndexChanged += new System.EventHandler(this.Conversion_comboBox1_SelectedIndexChanged);
            // 
            // Conversion_comboBox2
            // 
            this.Conversion_comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.Conversion_comboBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conversion_comboBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Conversion_comboBox2.FormattingEnabled = true;
            this.Conversion_comboBox2.Location = new System.Drawing.Point(180, 463);
            this.Conversion_comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.Conversion_comboBox2.Name = "Conversion_comboBox2";
            this.Conversion_comboBox2.Size = new System.Drawing.Size(349, 39);
            this.Conversion_comboBox2.TabIndex = 0;
            this.Conversion_comboBox2.SelectedIndexChanged += new System.EventHandler(this.Conversion_comboBox2_SelectedIndexChanged);
            // 
            // MainInputKeyboard
            // 
            this.MainInputKeyboard.Controls.Add(this.button_clear);
            this.MainInputKeyboard.Controls.Add(this.button_number_9);
            this.MainInputKeyboard.Controls.Add(this.button_number_0);
            this.MainInputKeyboard.Controls.Add(this.button_number_4);
            this.MainInputKeyboard.Controls.Add(this.button_point);
            this.MainInputKeyboard.Controls.Add(this.button_number_3);
            this.MainInputKeyboard.Controls.Add(this.button_number_5);
            this.MainInputKeyboard.Controls.Add(this.button_number_2);
            this.MainInputKeyboard.Controls.Add(this.button_CE);
            this.MainInputKeyboard.Controls.Add(this.button_number_1);
            this.MainInputKeyboard.Controls.Add(this.button_number_7);
            this.MainInputKeyboard.Controls.Add(this.button_number_6);
            this.MainInputKeyboard.Controls.Add(this.button_number_8);
            this.MainInputKeyboard.Location = new System.Drawing.Point(16, 273);
            this.MainInputKeyboard.Margin = new System.Windows.Forms.Padding(4);
            this.MainInputKeyboard.Name = "MainInputKeyboard";
            this.MainInputKeyboard.Size = new System.Drawing.Size(545, 530);
            this.MainInputKeyboard.TabIndex = 86;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Image = global::Calculator.Properties.Resources.icons8_стереть_символ_502;
            this.button_clear.Location = new System.Drawing.Point(357, 9);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(173, 98);
            this.button_clear.TabIndex = 9;
            this.button_clear.TabStop = false;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_number_9
            // 
            this.button_number_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_9.Image = global::Calculator.Properties.Resources.Screenshot_47;
            this.button_number_9.Location = new System.Drawing.Point(357, 112);
            this.button_number_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_9.Name = "button_number_9";
            this.button_number_9.Size = new System.Drawing.Size(173, 98);
            this.button_number_9.TabIndex = 9;
            this.button_number_9.UseVisualStyleBackColor = true;
            this.button_number_9.Click += new System.EventHandler(this.button_number_9_Click);
            // 
            // button_number_0
            // 
            this.button_number_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_0.Image = global::Calculator.Properties.Resources.Screenshot_40;
            this.button_number_0.Location = new System.Drawing.Point(179, 422);
            this.button_number_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_0.Name = "button_number_0";
            this.button_number_0.Size = new System.Drawing.Size(173, 98);
            this.button_number_0.TabIndex = 0;
            this.button_number_0.UseVisualStyleBackColor = true;
            this.button_number_0.Click += new System.EventHandler(this.button_number_0_Click);
            // 
            // button_number_4
            // 
            this.button_number_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_4.Image = global::Calculator.Properties.Resources.Screenshot_41;
            this.button_number_4.Location = new System.Drawing.Point(0, 215);
            this.button_number_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_4.Name = "button_number_4";
            this.button_number_4.Size = new System.Drawing.Size(173, 98);
            this.button_number_4.TabIndex = 4;
            this.button_number_4.UseVisualStyleBackColor = true;
            this.button_number_4.Click += new System.EventHandler(this.button_number_4_Click);
            // 
            // button_point
            // 
            this.button_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_point.Image = global::Calculator.Properties.Resources.Screenshot_42;
            this.button_point.Location = new System.Drawing.Point(357, 422);
            this.button_point.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(173, 98);
            this.button_point.TabIndex = 11;
            this.button_point.TabStop = false;
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_number_3
            // 
            this.button_number_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_3.Image = global::Calculator.Properties.Resources.Screenshot_39;
            this.button_number_3.Location = new System.Drawing.Point(357, 319);
            this.button_number_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_3.Name = "button_number_3";
            this.button_number_3.Size = new System.Drawing.Size(173, 98);
            this.button_number_3.TabIndex = 3;
            this.button_number_3.UseVisualStyleBackColor = true;
            this.button_number_3.Click += new System.EventHandler(this.button_number_3_Click);
            // 
            // button_number_5
            // 
            this.button_number_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_5.Image = global::Calculator.Properties.Resources.Screenshot_43;
            this.button_number_5.Location = new System.Drawing.Point(179, 215);
            this.button_number_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_5.Name = "button_number_5";
            this.button_number_5.Size = new System.Drawing.Size(173, 98);
            this.button_number_5.TabIndex = 5;
            this.button_number_5.UseVisualStyleBackColor = true;
            this.button_number_5.Click += new System.EventHandler(this.button_number_5_Click);
            // 
            // button_number_2
            // 
            this.button_number_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_2.Image = global::Calculator.Properties.Resources.Screenshot_38;
            this.button_number_2.Location = new System.Drawing.Point(179, 319);
            this.button_number_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_2.Name = "button_number_2";
            this.button_number_2.Size = new System.Drawing.Size(173, 98);
            this.button_number_2.TabIndex = 2;
            this.button_number_2.UseVisualStyleBackColor = true;
            this.button_number_2.Click += new System.EventHandler(this.button_number_2_Click);
            // 
            // button_CE
            // 
            this.button_CE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CE.Image = global::Calculator.Properties.Resources.Screenshot_36;
            this.button_CE.Location = new System.Drawing.Point(179, 9);
            this.button_CE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(173, 98);
            this.button_CE.TabIndex = 23;
            this.button_CE.TabStop = false;
            this.button_CE.UseVisualStyleBackColor = false;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_number_1
            // 
            this.button_number_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_1.Image = global::Calculator.Properties.Resources.Screenshot_37;
            this.button_number_1.Location = new System.Drawing.Point(0, 319);
            this.button_number_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_1.Name = "button_number_1";
            this.button_number_1.Size = new System.Drawing.Size(173, 98);
            this.button_number_1.TabIndex = 1;
            this.button_number_1.UseVisualStyleBackColor = true;
            this.button_number_1.Click += new System.EventHandler(this.button_number_1_Click);
            // 
            // button_number_7
            // 
            this.button_number_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_7.Image = global::Calculator.Properties.Resources.Screenshot_45;
            this.button_number_7.Location = new System.Drawing.Point(0, 112);
            this.button_number_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_7.Name = "button_number_7";
            this.button_number_7.Size = new System.Drawing.Size(173, 98);
            this.button_number_7.TabIndex = 7;
            this.button_number_7.UseVisualStyleBackColor = true;
            this.button_number_7.Click += new System.EventHandler(this.button_number_7_Click);
            // 
            // button_number_6
            // 
            this.button_number_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_6.Image = global::Calculator.Properties.Resources.Screenshot_44;
            this.button_number_6.Location = new System.Drawing.Point(357, 215);
            this.button_number_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_6.Name = "button_number_6";
            this.button_number_6.Size = new System.Drawing.Size(173, 98);
            this.button_number_6.TabIndex = 6;
            this.button_number_6.UseVisualStyleBackColor = true;
            this.button_number_6.Click += new System.EventHandler(this.button_number_6_Click);
            // 
            // button_number_8
            // 
            this.button_number_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_number_8.Image = global::Calculator.Properties.Resources.Screenshot_46;
            this.button_number_8.Location = new System.Drawing.Point(179, 112);
            this.button_number_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_number_8.Name = "button_number_8";
            this.button_number_8.Size = new System.Drawing.Size(173, 98);
            this.button_number_8.TabIndex = 8;
            this.button_number_8.UseVisualStyleBackColor = true;
            this.button_number_8.Click += new System.EventHandler(this.button_number_8_Click);
            // 
            // ConversionOfValues
            // 
            this.ConversionOfValues.Controls.Add(this.Conversion_textBox1);
            this.ConversionOfValues.Controls.Add(this.Conversion_comboBox1);
            this.ConversionOfValues.Controls.Add(this.Conversion_textBox2);
            this.ConversionOfValues.Controls.Add(this.Conversion_comboBox2);
            this.ConversionOfValues.Location = new System.Drawing.Point(755, 273);
            this.ConversionOfValues.Margin = new System.Windows.Forms.Padding(4);
            this.ConversionOfValues.Name = "ConversionOfValues";
            this.ConversionOfValues.Size = new System.Drawing.Size(715, 530);
            this.ConversionOfValues.TabIndex = 87;
            this.ConversionOfValues.Visible = false;
            // 
            // KeyboardMathOperations
            // 
            this.KeyboardMathOperations.Controls.Add(this.button_bracket_left);
            this.KeyboardMathOperations.Controls.Add(this.button_bracket_right);
            this.KeyboardMathOperations.Controls.Add(this.button_pi);
            this.KeyboardMathOperations.Controls.Add(this.button_tanx);
            this.KeyboardMathOperations.Controls.Add(this.button_cotx);
            this.KeyboardMathOperations.Controls.Add(this.button_plus_minus);
            this.KeyboardMathOperations.Controls.Add(this.button_sinx);
            this.KeyboardMathOperations.Controls.Add(this.button_plus);
            this.KeyboardMathOperations.Controls.Add(this.button_power);
            this.KeyboardMathOperations.Controls.Add(this.button_absx);
            this.KeyboardMathOperations.Controls.Add(this.button_cosx);
            this.KeyboardMathOperations.Controls.Add(this.button_atanx);
            this.KeyboardMathOperations.Controls.Add(this.button_sqrt);
            this.KeyboardMathOperations.Controls.Add(this.button_acosx);
            this.KeyboardMathOperations.Controls.Add(this.button_root);
            this.KeyboardMathOperations.Controls.Add(this.button_minus);
            this.KeyboardMathOperations.Controls.Add(this.button_square);
            this.KeyboardMathOperations.Controls.Add(this.button_power_of_ten);
            this.KeyboardMathOperations.Controls.Add(this.button_multiply);
            this.KeyboardMathOperations.Controls.Add(this.button_asinx);
            this.KeyboardMathOperations.Controls.Add(this.button_divide);
            this.KeyboardMathOperations.Controls.Add(this.button_x);
            this.KeyboardMathOperations.Controls.Add(this.button_definite_integral);
            this.KeyboardMathOperations.Location = new System.Drawing.Point(569, 273);
            this.KeyboardMathOperations.Margin = new System.Windows.Forms.Padding(4);
            this.KeyboardMathOperations.Name = "KeyboardMathOperations";
            this.KeyboardMathOperations.Size = new System.Drawing.Size(1079, 530);
            this.KeyboardMathOperations.TabIndex = 88;
            // 
            // button_bracket_left
            // 
            this.button_bracket_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bracket_left.Image = global::Calculator.Properties.Resources.Screenshot_11;
            this.button_bracket_left.Location = new System.Drawing.Point(5, 9);
            this.button_bracket_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_bracket_left.Name = "button_bracket_left";
            this.button_bracket_left.Size = new System.Drawing.Size(173, 98);
            this.button_bracket_left.TabIndex = 71;
            this.button_bracket_left.TabStop = false;
            this.button_bracket_left.UseVisualStyleBackColor = true;
            this.button_bracket_left.Visible = false;
            this.button_bracket_left.Click += new System.EventHandler(this.button_bracket_left_Click);
            // 
            // button_bracket_right
            // 
            this.button_bracket_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bracket_right.Image = global::Calculator.Properties.Resources.Screenshot_12;
            this.button_bracket_right.Location = new System.Drawing.Point(184, 9);
            this.button_bracket_right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_bracket_right.Name = "button_bracket_right";
            this.button_bracket_right.Size = new System.Drawing.Size(173, 98);
            this.button_bracket_right.TabIndex = 70;
            this.button_bracket_right.TabStop = false;
            this.button_bracket_right.UseVisualStyleBackColor = true;
            this.button_bracket_right.Visible = false;
            this.button_bracket_right.Click += new System.EventHandler(this.button_bracket_right_Click);
            // 
            // button_pi
            // 
            this.button_pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pi.Image = global::Calculator.Properties.Resources.Screenshot_13;
            this.button_pi.Location = new System.Drawing.Point(184, 112);
            this.button_pi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_pi.Name = "button_pi";
            this.button_pi.Size = new System.Drawing.Size(173, 98);
            this.button_pi.TabIndex = 84;
            this.button_pi.TabStop = false;
            this.button_pi.UseVisualStyleBackColor = true;
            this.button_pi.Click += new System.EventHandler(this.button_pi_Click);
            // 
            // button_tanx
            // 
            this.button_tanx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tanx.Image = global::Calculator.Properties.Resources.Screenshot_26;
            this.button_tanx.Location = new System.Drawing.Point(720, 215);
            this.button_tanx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tanx.Name = "button_tanx";
            this.button_tanx.Size = new System.Drawing.Size(173, 98);
            this.button_tanx.TabIndex = 72;
            this.button_tanx.TabStop = false;
            this.button_tanx.UseVisualStyleBackColor = true;
            this.button_tanx.Click += new System.EventHandler(this.button_tanx_Click);
            // 
            // button_cotx
            // 
            this.button_cotx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cotx.Image = global::Calculator.Properties.Resources.Screenshot_29;
            this.button_cotx.Location = new System.Drawing.Point(899, 215);
            this.button_cotx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cotx.Name = "button_cotx";
            this.button_cotx.Size = new System.Drawing.Size(173, 98);
            this.button_cotx.TabIndex = 73;
            this.button_cotx.TabStop = false;
            this.button_cotx.UseVisualStyleBackColor = true;
            this.button_cotx.Click += new System.EventHandler(this.button_cotx_Click);
            // 
            // button_plus_minus
            // 
            this.button_plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus_minus.Image = global::Calculator.Properties.Resources.Screenshot_15;
            this.button_plus_minus.Location = new System.Drawing.Point(5, 215);
            this.button_plus_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_plus_minus.Name = "button_plus_minus";
            this.button_plus_minus.Size = new System.Drawing.Size(173, 98);
            this.button_plus_minus.TabIndex = 67;
            this.button_plus_minus.TabStop = false;
            this.button_plus_minus.UseVisualStyleBackColor = true;
            this.button_plus_minus.Click += new System.EventHandler(this.button_plus_minus_Click);
            // 
            // button_sinx
            // 
            this.button_sinx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sinx.Image = global::Calculator.Properties.Resources.Screenshot_23;
            this.button_sinx.Location = new System.Drawing.Point(720, 9);
            this.button_sinx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sinx.Name = "button_sinx";
            this.button_sinx.Size = new System.Drawing.Size(173, 98);
            this.button_sinx.TabIndex = 74;
            this.button_sinx.TabStop = false;
            this.button_sinx.UseVisualStyleBackColor = true;
            this.button_sinx.Click += new System.EventHandler(this.button_sinx_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Image = global::Calculator.Properties.Resources.Screenshot_22;
            this.button_plus.Location = new System.Drawing.Point(363, 422);
            this.button_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(173, 98);
            this.button_plus.TabIndex = 62;
            this.button_plus.TabStop = false;
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_power
            // 
            this.button_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_power.Image = global::Calculator.Properties.Resources.Screenshot_51;
            this.button_power.Location = new System.Drawing.Point(541, 112);
            this.button_power.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(173, 98);
            this.button_power.TabIndex = 66;
            this.button_power.TabStop = false;
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // button_absx
            // 
            this.button_absx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_absx.Image = global::Calculator.Properties.Resources.Screenshot_14;
            this.button_absx.Location = new System.Drawing.Point(184, 215);
            this.button_absx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_absx.Name = "button_absx";
            this.button_absx.Size = new System.Drawing.Size(173, 98);
            this.button_absx.TabIndex = 83;
            this.button_absx.TabStop = false;
            this.button_absx.UseVisualStyleBackColor = true;
            this.button_absx.Click += new System.EventHandler(this.button_absx_Click);
            // 
            // button_cosx
            // 
            this.button_cosx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cosx.Image = global::Calculator.Properties.Resources.Screenshot_24;
            this.button_cosx.Location = new System.Drawing.Point(899, 9);
            this.button_cosx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cosx.Name = "button_cosx";
            this.button_cosx.Size = new System.Drawing.Size(173, 98);
            this.button_cosx.TabIndex = 75;
            this.button_cosx.TabStop = false;
            this.button_cosx.UseVisualStyleBackColor = true;
            this.button_cosx.Click += new System.EventHandler(this.button_cosx_Click);
            // 
            // button_atanx
            // 
            this.button_atanx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_atanx.Image = global::Calculator.Properties.Resources.Screenshot_28;
            this.button_atanx.Location = new System.Drawing.Point(720, 319);
            this.button_atanx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_atanx.Name = "button_atanx";
            this.button_atanx.Size = new System.Drawing.Size(173, 98);
            this.button_atanx.TabIndex = 82;
            this.button_atanx.TabStop = false;
            this.button_atanx.UseVisualStyleBackColor = true;
            this.button_atanx.Click += new System.EventHandler(this.button_atanx_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sqrt.Image = global::Calculator.Properties.Resources.Screenshot_7;
            this.button_sqrt.Location = new System.Drawing.Point(541, 319);
            this.button_sqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(173, 98);
            this.button_sqrt.TabIndex = 76;
            this.button_sqrt.TabStop = false;
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button_sqrt_Click);
            // 
            // button_acosx
            // 
            this.button_acosx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_acosx.Image = global::Calculator.Properties.Resources.Screenshot_25;
            this.button_acosx.Location = new System.Drawing.Point(899, 112);
            this.button_acosx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_acosx.Name = "button_acosx";
            this.button_acosx.Size = new System.Drawing.Size(173, 98);
            this.button_acosx.TabIndex = 81;
            this.button_acosx.TabStop = false;
            this.button_acosx.UseVisualStyleBackColor = true;
            this.button_acosx.Click += new System.EventHandler(this.button_acosx_Click);
            // 
            // button_root
            // 
            this.button_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_root.Image = global::Calculator.Properties.Resources.Screenshot_8;
            this.button_root.Location = new System.Drawing.Point(541, 422);
            this.button_root.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(173, 98);
            this.button_root.TabIndex = 69;
            this.button_root.TabStop = false;
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.button_root_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Image = global::Calculator.Properties.Resources.Screenshot_21;
            this.button_minus.Location = new System.Drawing.Point(363, 319);
            this.button_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(173, 98);
            this.button_minus.TabIndex = 63;
            this.button_minus.TabStop = false;
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_square
            // 
            this.button_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_square.Image = global::Calculator.Properties.Resources.Screenshot_9;
            this.button_square.Location = new System.Drawing.Point(541, 9);
            this.button_square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(173, 98);
            this.button_square.TabIndex = 77;
            this.button_square.TabStop = false;
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_power_of_ten
            // 
            this.button_power_of_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_power_of_ten.Image = global::Calculator.Properties.Resources.Screenshot_61;
            this.button_power_of_ten.Location = new System.Drawing.Point(541, 215);
            this.button_power_of_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_power_of_ten.Name = "button_power_of_ten";
            this.button_power_of_ten.Size = new System.Drawing.Size(173, 98);
            this.button_power_of_ten.TabIndex = 68;
            this.button_power_of_ten.TabStop = false;
            this.button_power_of_ten.UseVisualStyleBackColor = true;
            this.button_power_of_ten.Click += new System.EventHandler(this.button_power_of_ten_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Image = global::Calculator.Properties.Resources.Screenshot_20;
            this.button_multiply.Location = new System.Drawing.Point(363, 215);
            this.button_multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(173, 98);
            this.button_multiply.TabIndex = 64;
            this.button_multiply.TabStop = false;
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_asinx
            // 
            this.button_asinx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_asinx.Image = global::Calculator.Properties.Resources.Screenshot_27;
            this.button_asinx.Location = new System.Drawing.Point(720, 112);
            this.button_asinx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_asinx.Name = "button_asinx";
            this.button_asinx.Size = new System.Drawing.Size(173, 98);
            this.button_asinx.TabIndex = 80;
            this.button_asinx.TabStop = false;
            this.button_asinx.UseVisualStyleBackColor = true;
            this.button_asinx.Click += new System.EventHandler(this.button_asinx_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divide.Image = global::Calculator.Properties.Resources.Screenshot_19;
            this.button_divide.Location = new System.Drawing.Point(363, 112);
            this.button_divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(173, 98);
            this.button_divide.TabIndex = 65;
            this.button_divide.TabStop = false;
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_x
            // 
            this.button_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_x.Image = global::Calculator.Properties.Resources.Screenshot_10;
            this.button_x.Location = new System.Drawing.Point(363, 9);
            this.button_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(173, 98);
            this.button_x.TabIndex = 79;
            this.button_x.TabStop = false;
            this.button_x.UseVisualStyleBackColor = true;
            this.button_x.Visible = false;
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // button_definite_integral
            // 
            this.button_definite_integral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_definite_integral.Image = global::Calculator.Properties.Resources.Screenshot_18;
            this.button_definite_integral.Location = new System.Drawing.Point(5, 384);
            this.button_definite_integral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_definite_integral.Name = "button_definite_integral";
            this.button_definite_integral.Size = new System.Drawing.Size(267, 137);
            this.button_definite_integral.TabIndex = 78;
            this.button_definite_integral.TabStop = false;
            this.button_definite_integral.UseVisualStyleBackColor = true;
            this.button_definite_integral.Click += new System.EventHandler(this.button_definite_integral_Click);
            // 
            // Screens
            // 
            this.Screens.Controls.Add(this.button_formula_mode);
            this.Screens.Controls.Add(this.TranslationScreen);
            this.Screens.Controls.Add(this.button_next_line);
            this.Screens.Controls.Add(this.button_count);
            this.Screens.Controls.Add(this.button_memory_read);
            this.Screens.Controls.Add(this.MainScreen);
            this.Screens.Controls.Add(this.button_memory_clear);
            this.Screens.Controls.Add(this.button_memory_add);
            this.Screens.Location = new System.Drawing.Point(15, 32);
            this.Screens.Margin = new System.Windows.Forms.Padding(4);
            this.Screens.Name = "Screens";
            this.Screens.Size = new System.Drawing.Size(1633, 234);
            this.Screens.TabIndex = 89;
            // 
            // button_formula_mode
            // 
            this.button_formula_mode.BackColor = System.Drawing.Color.Salmon;
            this.button_formula_mode.Font = new System.Drawing.Font("Brush Script MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_formula_mode.Location = new System.Drawing.Point(1273, 122);
            this.button_formula_mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_formula_mode.Name = "button_formula_mode";
            this.button_formula_mode.Size = new System.Drawing.Size(173, 98);
            this.button_formula_mode.TabIndex = 30;
            this.button_formula_mode.TabStop = false;
            this.button_formula_mode.Text = "formula";
            this.button_formula_mode.UseVisualStyleBackColor = false;
            this.button_formula_mode.Click += new System.EventHandler(this.button_formula_mode_Click);
            // 
            // button_next_line
            // 
            this.button_next_line.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_next_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next_line.Image = global::Calculator.Properties.Resources.next;
            this.button_next_line.Location = new System.Drawing.Point(1095, 18);
            this.button_next_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_next_line.Name = "button_next_line";
            this.button_next_line.Size = new System.Drawing.Size(173, 98);
            this.button_next_line.TabIndex = 29;
            this.button_next_line.TabStop = false;
            this.button_next_line.UseVisualStyleBackColor = false;
            this.button_next_line.Click += new System.EventHandler(this.button_next_line_Click);
            // 
            // button_memory_read
            // 
            this.button_memory_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_read.Image = global::Calculator.Properties.Resources.Screenshot_34;
            this.button_memory_read.Location = new System.Drawing.Point(1452, 17);
            this.button_memory_read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_memory_read.Name = "button_memory_read";
            this.button_memory_read.Size = new System.Drawing.Size(173, 98);
            this.button_memory_read.TabIndex = 27;
            this.button_memory_read.TabStop = false;
            this.button_memory_read.UseVisualStyleBackColor = true;
            this.button_memory_read.Click += new System.EventHandler(this.button_memory_read_Click);
            // 
            // button_memory_clear
            // 
            this.button_memory_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_clear.Image = global::Calculator.Properties.Resources.Screenshot_35;
            this.button_memory_clear.Location = new System.Drawing.Point(1452, 122);
            this.button_memory_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_memory_clear.Name = "button_memory_clear";
            this.button_memory_clear.Size = new System.Drawing.Size(173, 98);
            this.button_memory_clear.TabIndex = 28;
            this.button_memory_clear.TabStop = false;
            this.button_memory_clear.UseVisualStyleBackColor = true;
            this.button_memory_clear.Click += new System.EventHandler(this.button_memory_clear_Click);
            // 
            // button_memory_add
            // 
            this.button_memory_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_memory_add.Image = global::Calculator.Properties.Resources.Screenshot_33;
            this.button_memory_add.Location = new System.Drawing.Point(1273, 18);
            this.button_memory_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_memory_add.Name = "button_memory_add";
            this.button_memory_add.Size = new System.Drawing.Size(173, 98);
            this.button_memory_add.TabIndex = 26;
            this.button_memory_add.TabStop = false;
            this.button_memory_add.UseVisualStyleBackColor = true;
            this.button_memory_add.Click += new System.EventHandler(this.button_memory_add_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1657, 803);
            this.Controls.Add(this.Screens);
            this.Controls.Add(this.MainInputKeyboard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.KeyboardMathOperations);
            this.Controls.Add(this.ConversionOfValues);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1675, 850);
            this.MinimumSize = new System.Drawing.Size(1675, 850);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainInputKeyboard.ResumeLayout(false);
            this.ConversionOfValues.ResumeLayout(false);
            this.ConversionOfValues.PerformLayout();
            this.KeyboardMathOperations.ResumeLayout(false);
            this.Screens.ResumeLayout(false);
            this.Screens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_number_3;
        private System.Windows.Forms.Button button_number_2;
        private System.Windows.Forms.Button button_number_1;
        private System.Windows.Forms.Button button_number_6;
        private System.Windows.Forms.Button button_number_5;
        private System.Windows.Forms.Button button_number_4;
        private System.Windows.Forms.Button button_number_9;
        private System.Windows.Forms.Button button_number_8;
        private System.Windows.Forms.Button button_number_7;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_number_0;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_Screen;
        private System.Windows.Forms.TextBox textBox_data_translation;
        private System.Windows.Forms.TextBox MainScreen;
        private System.Windows.Forms.TextBox TranslationScreen;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_memory_add;
        private System.Windows.Forms.Button button_memory_read;
        private System.Windows.Forms.Button button_memory_clear;
        private System.Windows.Forms.Button button_next_line;
        private System.Windows.Forms.Button button_formula_mode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviousOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextOperationToolStripMenuItem;
        private System.Windows.Forms.Button button_bracket_left;
        private System.Windows.Forms.Button button_pi;
        private System.Windows.Forms.Button button_bracket_right;
        private System.Windows.Forms.Button button_plus_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_absx;
        private System.Windows.Forms.Button button_atanx;
        private System.Windows.Forms.Button button_acosx;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_power_of_ten;
        private System.Windows.Forms.Button button_asinx;
        private System.Windows.Forms.Button button_x;
        private System.Windows.Forms.Button button_definite_integral;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_cosx;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button_sinx;
        private System.Windows.Forms.Button button_cotx;
        private System.Windows.Forms.Button button_tanx;
        private System.Windows.Forms.ToolStripMenuItem typesOfCalculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EngineeringToolStripMenuItem;
        private System.Windows.Forms.TextBox Conversion_textBox1;
        private System.Windows.Forms.TextBox Conversion_textBox2;
        private System.Windows.Forms.ComboBox Conversion_comboBox1;
        private System.Windows.Forms.ComboBox Conversion_comboBox2;
        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Panel MainInputKeyboard;
        private System.Windows.Forms.Panel ConversionOfValues;
        private System.Windows.Forms.Panel KeyboardMathOperations;
        private System.Windows.Forms.Panel Screens;
    }
}

