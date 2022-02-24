﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    public partial class MainForm : Form
    {
        public enum Enums
        {
            Color,
            EducationForm,
            Genre,
            Manufactures,
            Season,
            Weekday
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Enums d in Enum.GetValues(typeof(Enums)))
            {
                EnumListBox.Items.Add(d);
            }
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var c = EnumListBox.SelectedIndex;
            switch ((Enums)c)
            {
                case Enums.Color:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Color)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                case Enums.Season:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
            }
        }


        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var i = Convert.ToString(ValuesListBox.SelectedIndex);
            textBox1.Text = i;
        }

        private void ParseBtn_Click_1(object sender, EventArgs e)
        {
            var text = ParseInput.Text;
            if (Enum.IsDefined(typeof(Weekday), text))
            {
                var day = Enum.Parse(typeof(Weekday), text, true);
                OutText.Text = $"Это день недели ({day} = {day.GetHashCode()})";
            }
            else
            {
                OutText.Text = "Нет такого дня недели!";
            }
        }
    }
}
