﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class WorkerControls : Form
    {
        String userName = "";

        public WorkerControls(string workerName)
        {
            InitializeComponent();
            userName = workerName;
        }
    }
}
