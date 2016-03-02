using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld {
    public partial class HelloWorldForm : Form {
        public HelloWorldForm( ) {
            InitializeComponent( );
        }

        private void buttonOK_Click( object sender, EventArgs e ) {
            this.DialogResult = DialogResult.OK;
            this.Close( );
        }

        private void buttonCancel_Click( object sender, EventArgs e ) {
            this.DialogResult = DialogResult.Cancel;
            this.Close( );
        }
    }
}
