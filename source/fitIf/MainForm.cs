﻿// Copyright © 2011 Syterra Software Inc. All rights reserved.
// The use and distribution terms for this software are covered by the Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file license.txt at the root of this distribution. By using this software in any fashion, you are agreeing
// to be bound by the terms of this license. You must not remove this notice, or any other, from this software.

using fitSharp.Machine.Model;
using System;
using System.Windows.Forms;

namespace fitIf {
    public partial class MainForm: Form {
        public MainForm(): this(Environment.GetCommandLineArgs()) {}

        public MainForm(string[] commandLineArgs) {
            InitializeComponent();
            label1.Text = commandLineArgs.Join(" ");
            shell = new Shell(commandLineArgs);
        }

        void button1_Click(object sender, EventArgs e) {
            var result = shell.Run(textBox1.Text);
            webBrowser1.DocumentText = result;
        }

        readonly Shell shell;
    }
}
