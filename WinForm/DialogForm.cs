﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class DialogForm : Form
    {
        public DialogForm( string message, Color bgColor)
        {
            InitializeComponent();
            this.BackColor = bgColor;

        }
    }
}
