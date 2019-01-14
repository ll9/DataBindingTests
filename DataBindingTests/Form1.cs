using DataBindingTests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingTests
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();

            bindingSource = new BindingSource();
            bindingSource.DataSource = new Person();

            nameTextBox2.DataBindings.Add("Text", bindingSource, "Name");
            nameTextBox3.DataBindings.Add("Text", bindingSource, "Name");
            ageTextBox2.DataBindings.Add("Text", bindingSource, "Age");
            ageTextBox3.DataBindings.Add("Text", bindingSource, "Age");
        }
    }
}
